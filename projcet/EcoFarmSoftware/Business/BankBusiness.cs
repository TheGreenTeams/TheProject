using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business;
using Data.Models;
using Data;
using System.Threading.Tasks;

namespace Business
{
    public class BankBusiness
    {
        public EcoFarmSoftwareContext ecoFarmSoftwareContext;

        public List<Bank> GetAll()
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Banks.ToList();
            }
        }

        public Bank Get(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Banks.Find(id);
            }
        }

        public void Add(Bank bank)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                //bool a = false;

                //foreach (var item in ecoFarmSoftwareContext.Banks)
                //{
                //    if (bank.Name != item.Name)
                //    {
                //        ecoFarmSoftwareContext.Banks.Add(bank);
                //        ecoFarmSoftwareContext.SaveChanges();
                //        a = true;
                //        break;
                //    }
                //}
                //if (a == false)
                //{
                //    Console.WriteLine("The name is already taken");
                //}
                
                ecoFarmSoftwareContext.Banks.Add(bank);
                ecoFarmSoftwareContext.SaveChanges();
            }
        }

        public void Update(Bank bank)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var item = ecoFarmSoftwareContext.Banks.Find(bank.Id);
                if (item != null)
                {
                    ecoFarmSoftwareContext.Entry(item).CurrentValues.SetValues(bank);
                    ecoFarmSoftwareContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var bank = ecoFarmSoftwareContext.Banks.Find(id);
                if (bank != null)
                {
                    ecoFarmSoftwareContext.Banks.Remove(bank);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }

        public void AddMoney(int id, decimal quantity)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var bank = ecoFarmSoftwareContext.Banks.Find(id);
                if (bank != null && quantity > 0)
                {

                    ecoFarmSoftwareContext.Entry(bank.Id).CurrentValues.SetValues(bank.Balance + quantity);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }

        public void TakeMoney(int id, decimal quantity)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var bank = ecoFarmSoftwareContext.Banks.Find(id);
                if (bank != null && quantity > 0)
                {

                    ecoFarmSoftwareContext.Entry(bank.Id).CurrentValues.SetValues(bank.Balance - quantity);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }
    }
}
