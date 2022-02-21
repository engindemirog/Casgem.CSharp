using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Business kodları buraya yazılır
    //Bir katman diğerini new'leyemez
    public class ProductManager
    {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product) 
        { 
            //Kurallar
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            //Kurallar
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            //Kurallar
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //Kurallar
            return _productDal.GetAll();
        }
    }
}
