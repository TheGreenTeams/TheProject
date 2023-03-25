using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductsBusiness
    {
        public EcoFarmSoftwareContext ecoFarmSoftwareContext;

        public List<Products> GetAll()
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Products.ToList();
            }
        }

        public Products Get(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Products.Find(id);

            }
        }

        public void Add(Products product)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                ecoFarmSoftwareContext.Products.Add(product);
                ecoFarmSoftwareContext.SaveChanges();
            }
        }

        public void Update(Products product)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var item = ecoFarmSoftwareContext.Products.Find(product.Id);
                if (item != null)
                {
                    ecoFarmSoftwareContext.Entry(item).CurrentValues.SetValues(product);
                    ecoFarmSoftwareContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var product = ecoFarmSoftwareContext.Products.Find(id);
                if (product != null)
                {
                    ecoFarmSoftwareContext.Products.Remove(product);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }

        public void Sell(int id, int quantity)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                Products product = ecoFarmSoftwareContext.Products.Find(id);
                if (product != null && quantity > 0 && product.Stock > quantity)
                {
                    int a = product.Stock - quantity;
                    ecoFarmSoftwareContext.Entry(product.Id).CurrentValues.SetValues(a);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }
    }
}
