﻿using SomethingGreen.Data;
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

        public Product Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.Find(id);

            }
        }

        public void Add(Product product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Products.Add(product);
                productContext.SaveChanges();

            }
        }

        public void Update(Product product)
        {
            using (productContext = new ProductContext())
            {
                var item = productContext.Products.Find(product.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    productContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var product = productContext.Products.Find(id);
                if (product != null)
                {
                    productContext.Products.Remove(product);
                    productContext.SaveChanges();
                }
            }
        }

        public void Sell(int id, int quantity)
        {
            using (productContext = new ProductContext())
            {
                Product product = productContext.Products.Find(id);
                if (product != null && quantity > 0 && product.Stock > quantity)
                {
                    //Product product1 = product.Id;
                    productContext.Entry(product.Id).CurrentValues.SetValues(product.Stock-quantity);
                    productContext.SaveChanges();
                }
            }
        }

    }
}
