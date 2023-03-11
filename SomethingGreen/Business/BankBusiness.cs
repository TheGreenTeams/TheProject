using SomethingGreen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Business
{
    class BankBusiness
    {
        public BankContext bankContext;

        public List<Bank> GetAll()
        {
            using (bankContext = new BankContext())
            {
                return bankContext.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (bankContext = new BankContext())
            {
                return bankContext.Products.Find(id);

            }
        }

        public void Add(Product product)
        {
            using (bankContext = new BankContext())
            {
                bankContext.Products.Add(product);
                bankContext.SaveChanges();

            }
        }

        public void Update(Product product)
        {
            using (bankContext = new BankContext())
            {
                var item = bankContext.Products.Find(product.Id);
                if (item != null)
                {
                    bankContext.Entry(item).CurrentValues.SetValues(product);
                    bankContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (bankContext = new BankContext())
            {
                var product = bankContext.Products.Find(id);
                if (product != null)
                {
                    bankContext.Products.Remove(product);
                    bankContext.SaveChanges();
                }
            }
        }

        public void Sell(int id, int quantity)
        {
            using (bankContext = new BankContext())
            {
                var product = bankContext.Products.Find(id);
                if (product != null && quantity > 0)
                {
                    
                    bankContext.Products.Update(product);
                    bankContext.SaveChanges();
                }
            }
        }
    }
}
