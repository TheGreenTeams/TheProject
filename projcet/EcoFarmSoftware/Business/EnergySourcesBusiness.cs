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
    public class EnergySourcesBusiness
    {
        private EcoFarmSoftwareContext ecoFarmSoftwareContext;

        public List<EnergySources> GetAll()
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.EnergySources.ToList();
            }
        }

        public EnergySources Get(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.EnergySources.Find(id);
            }
        }

        public void Add(EnergySources energySources)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                ecoFarmSoftwareContext.EnergySources.Add(energySources);
                ecoFarmSoftwareContext.SaveChanges();
            }
        }

        public void Update(EnergySources energySources)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var item = ecoFarmSoftwareContext.EnergySources.Find(energySources.Id);
                if (item != null)
                {
                    ecoFarmSoftwareContext.Entry(item).CurrentValues.SetValues(energySources);
                    ecoFarmSoftwareContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var product = ecoFarmSoftwareContext.EnergySources.Find(id);
                if (product != null)
                {
                    ecoFarmSoftwareContext.EnergySources.Remove(product);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }
    }
}
