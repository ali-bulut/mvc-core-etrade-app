using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Abc.Northwind.MvcWebUI.ExtensionMethods
{
    //extension methodları barındırması için static olması lazım.
    //tıpkı middleware gibi. Özünde middleware de bir extensiondır.
    public static class SessionExtensionMethods
    {
        //this kullanımı da middleware'deki gibi. Extension method olduğunu bu şekilde belirtiriz.
        public static void SetObject(this ISession session, string key, object value)
        {
            //object olan value'yi string'e çevirdik.
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T:class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }

            T value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}
