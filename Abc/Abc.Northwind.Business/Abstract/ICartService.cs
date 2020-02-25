using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        CartLine RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
