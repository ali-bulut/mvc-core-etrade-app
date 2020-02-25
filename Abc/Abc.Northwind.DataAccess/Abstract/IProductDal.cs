using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //IEntityRepository'deki tüm oluşturulan operasyonlar artık IProductDal için de geçerlidir.
        //Bunu oluşturma sebebimiz IEntityRepository'de oluşturulan operasyonlar dışında
        //product nesnesine özel operasyonlar yazmak içindir.
    }

    
}
