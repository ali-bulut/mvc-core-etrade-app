using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.MvcWebUI.ExtensionMethods;
using Microsoft.AspNetCore.Http;

namespace Abc.Northwind.MvcWebUI.Services
{
    public class CartSessionService:ICartSessionService
    {
        //httpcontext.session sadece controller classlarına özel bir yapıdır.
        //bunu burada da kullanmak için aşağıdaki dependency Injection'ı yapıyoruz.
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
           Cart cartToCheck= _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");

           if (cartToCheck==null)
           {
               _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
               cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
           }

           return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
