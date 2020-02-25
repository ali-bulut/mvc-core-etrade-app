using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetbyCategory(int categoryId)
        {
            //yani eğer categoryId default olarak yaptığımız için 0 gelirse categoryId==0 sorgusu çalışacak
            //bu sorgudan da true aldığı için tüm ürünler listelenecek.
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product{ProductId = productId});
        }

        public Product GetById(int productId)
        {
           return _productDal.Get(p => p.ProductId == productId);
        }
    }
}
