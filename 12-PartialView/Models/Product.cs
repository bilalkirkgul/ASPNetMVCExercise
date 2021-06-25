using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_PartialView.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}