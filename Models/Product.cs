using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcAppShop.Models
{
    public class Product
    {

        public int ID { get; set; }

     
        public string Name { get; set; }

       
        public decimal Price { get; set; }


    }
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}