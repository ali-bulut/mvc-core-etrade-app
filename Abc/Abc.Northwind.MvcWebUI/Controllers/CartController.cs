using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.MvcWebUI.Models;
using Abc.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message",
                string.Format("Your product, {0}, has been added to the cart!", productToBeAdded.ProductName));


            return RedirectToAction("Index", "Product");
        }


        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel cartSummaryViewModel = new CartSummaryViewModel {Cart = cart};

            return View(cartSummaryViewModel);
        }

        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart(); 
            var product = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            var index = cart.CartLines.FindIndex(p => p.Product.ProductId == productId);
            var result = _cartService.RemoveFromCart(cart, productId);
            if (result.Quantity>=1)
            {
                product = result;
                cart.CartLines.Insert(index, product);
            }


            _cartSessionService.SetCart(cart);

            TempData.Add("message",
                string.Format("Your product has been removed from the cart!"));

            return RedirectToAction("List");
        }

        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails=new ShippingDetails()
            };

            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            TempData.Add("message", $"Thank you {shippingDetails.FirstName}, your order is in process");
            HttpContext.Session.Remove("cart");
            return RedirectToAction("Index","Product");

            
        }
    }
}