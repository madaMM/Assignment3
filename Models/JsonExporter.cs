using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MvcAppShop.Models
{
    public class JsonExporter : Exporter
    {
        public void exportProducts(List<Product> prodL)
        {
            
            foreach (Product prod in prodL){

                string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(prod);
               
                File.WriteAllText(Environment.CurrentDirectory + @"\JSON.txt", json);
            }

        }
    }
}