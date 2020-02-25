using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abc.Core.Entitites;

namespace Abc.Northwind.Entities.Concrete
{
    //Devart->Entity Generator

    //IEntity'den implemente olmuşsa anlarız ki bu class bir veritabanı nesnesidir.
    //add-reference'tan diğer projeleri ekleyip diğer projelerdeki classlara vs erişebiliriz.
    public class Product:IEntity
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public short UnitsInStock { get; set; }
    }
}
