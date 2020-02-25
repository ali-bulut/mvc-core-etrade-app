using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page=1,int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetbyCategory(category);

            ProductListViewModel model= new ProductListViewModel
            {
                //yani 2.sayfa için ilk 10 ürünü atla sonraki ilk 10 ürünü yazdır
                //3.sayfa için ilk 20 ürünü atla sonraki ilk 10 ürünü yazdır gibi
                Products=products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                //sonuç 4,4 gibi birşey çıkarsa direkt olarak 5'i alır.
                PageCount=(int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize=pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };
            //view'e direkt nesne göndermek yerine viewmodel oluşturup öyle göndermek daha iyidir.
            return View(model);
        }
    }
}