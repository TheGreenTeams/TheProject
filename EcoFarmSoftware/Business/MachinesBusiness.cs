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
    public class MachinesBusiness
    {
        private EcoFarmSoftwareContext ecoFarmSoftwareContext;

        public List<Machines> GetAll()
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Machines.ToList();
            }
        }

        public Machines Get(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Machines.Find(id);
            }
        }

        public void Add(Machines machines)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                ecoFarmSoftwareContext.Machines.Add(machines);
                ecoFarmSoftwareContext.SaveChanges();

            }
        }

        public void Update(Machines machines)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var item = ecoFarmSoftwareContext.Machines.Find(machines.Id);
                if (item != null)
                {
                    ecoFarmSoftwareContext.Entry(item).CurrentValues.SetValues(machines);
                    ecoFarmSoftwareContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var product = ecoFarmSoftwareContext.Machines.Find(id);
                if (product != null)
                {
                    ecoFarmSoftwareContext.Machines.Remove(product);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }
    }
}
