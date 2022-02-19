using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Business kodları buraya yazılır
    public class ProductManager
    {
        
        EfProductDal productDal = new EfProductDal();
        public void Add(Product product) 
        { 
            //Kurallar
            productDal.Add(product);
        }

        public void Update(Product product)
        {
            //Kurallar
            productDal.Update(product);
        }

        public void Delete(Product product)
        {
            //Kurallar
            productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //Kurallar
            return productDal.GetAll();
        }
    }
}
