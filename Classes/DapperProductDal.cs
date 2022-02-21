using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DapperProductDal:IProductDal
    {
        List<Product> products;

        public DapperProductDal()
        {
            products = new List<Product>();
        }
        public List<Product> GetAll()
        {
            return products;
        }

        public void Add(Product product)
        {
            products.Add(product);
            Console.WriteLine("Dapper ile eklendi");
        }

        public void Update(Product product)
        {
            Product productToUpdate = products.FirstOrDefault(p => p.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.DiscountRate = product.DiscountRate;
            productToUpdate.ImageUrl = product.ImageUrl;


        }

        public void Delete(Product product)
        {
            Product productToDelete = products.FirstOrDefault(p => p.Id == product.Id);
            products.Remove(productToDelete);
        }
    }
}
