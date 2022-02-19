using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountedPrice { 
            get 
            {
                return UnitPrice - (UnitPrice * DiscountRate / 100);
            } 
        }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, double unitPrice, double discountRate, string imageUrl)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            DiscountRate = discountRate;
            ImageUrl = imageUrl;
        }

        public Product() { }
    }
}
