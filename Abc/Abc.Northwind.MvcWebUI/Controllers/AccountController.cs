using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.MvcWebUI.Entities;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(SignInManager<CustomIdentityUser> signInManager, RoleManager<CustomIdentityRole> roleManager, UserManager<CustomIdentityUser> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email
                };

                //burada işlemin başarılı olup olmadığını belirlemek amaç
                //burada kullanıcı eklenir.
                IdentityResult result =
                    _userManager.CreateAsync(user, registerViewModel.Password).Result;

                //işlem başarılıysa
                if (result.Succeeded)
                {
                    //sistemde Admin diye bir rol yok ise;
                    if (!_roleManager.RoleExistsAsync("Admin").Result)
                    {
                        //direkt eklenen kullanıcının rolü admin olarak atanır
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Admin"
                        };

                        //burada işlemin başarılı olup olmadığını belirlemek amaç
                        //burada kullanıcı rolü eklenir.
                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        //rol ekleme işlemi başarılı değilse;
                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "We can't add the role!");
                            return View(registerViewModel);
                        }
                    }

                    //Eğer sistemde Admin diye bir rol varsa bile yine gelen user'a Admin'i ata.
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                    return RedirectToAction("Login", "Account");
                }
            }

            return View(registerViewModel);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                //sisteme giriş yapma aşaması
                var result = _signInManager.PasswordSignInAsync(loginViewModel.UserName,
                    loginViewModel.Password, loginViewModel.RememberMe, false).Result;

                //giriş yapma başarılıysa;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }

                ModelState.AddModelError("", "Invalid login!");
            }

            return View(loginViewModel);
        }

        public ActionResult LogOff()
        {
            //sistemden çıkış yapılma aşaması
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }
    }
}