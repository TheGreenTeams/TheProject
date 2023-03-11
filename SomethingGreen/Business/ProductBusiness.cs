using SomethingGreen.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Business
{
    class ProductBusiness
    {
        private ProductContext productContext;

        public List<Product> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.ToList();
            }
        }


    }
}
