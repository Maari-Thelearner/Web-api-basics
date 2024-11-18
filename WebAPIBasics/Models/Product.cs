using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIBasics.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}