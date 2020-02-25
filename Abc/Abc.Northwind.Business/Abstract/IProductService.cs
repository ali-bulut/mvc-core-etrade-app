using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Abstract
{
    public interface IProductService
    {
        //IEntityRepository'yi direkt olarak implemente etmememizin sebebi 
        //business katmanında farklı işlemler yapabiliriz ekstra parametre vb gönderebiliriz.
        //client'ların (arayüzün) ihtiyaç duyduğu operasyonları yazarız.
        List<Product> GetAll();
        List<Product> GetbyCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
