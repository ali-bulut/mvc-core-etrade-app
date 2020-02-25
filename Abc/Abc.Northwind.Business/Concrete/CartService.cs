using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Concrete
{
    public class CartService:ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);

            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine{Product = product,Quantity = 1});
        }

        public CartLine RemoveFromCart(Cart cart, int productId)
        {
            var result = cart.CartLines.Any(p => p.Product.ProductId==productId && p.Quantity > 1);
            if (result)
            {
                var product = cart.CartLines.FirstOrDefault(p => p.Product.ProductId == productId);
                int quantity = cart.CartLines.Find(p => p.Product.ProductId == productId).Quantity;
                quantity = quantity - 1;

                CartLine cartLine = new CartLine {Quantity = quantity, Product = product.Product};
                cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
                return cartLine;
            }
            else
            {
               cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
               CartLine cartLine = new CartLine();
               return cartLine;
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
