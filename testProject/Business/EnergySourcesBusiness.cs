using testProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Business
{
    class EnergySourcesBusiness
    {
        private EnergySourcesContext energySourcesContext;

        public List<EnergySources> GetAll()
        {
            using (energySourcesContext = new EnergySourcesContext())
            {
                return energySourcesContext.EnergySources.ToList();
            }
        }

        public EnergySources Get(int id)
        {
            using (energySourcesContext = new EnergySourcesContext())
            {
                return energySourcesContext.EnergySources.Find(id);
            }
        }

        public void Add(EnergySources energySources)
        {
            using (energySourcesContext = new EnergySourcesContext())
            {
                energySourcesContext.EnergySources.Add(energySources);
                energySourcesContext.SaveChanges();
            }
        }

        public void Update(EnergySources energySources)
        {
            using (energySourcesContext = new EnergySourcesContext())
            {
                var item = energySourcesContext.EnergySources.Find(energySources.Id);
                if (item != null)
                {
                    energySourcesContext.Entry(item).CurrentValues.SetValues(energySources);
                    energySourcesContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (energySourcesContext = new EnergySourcesContext())
            {
                var product = energySourcesContext.EnergySources.Find(id);
                if (product != null)
                {
                    energySourcesContext.EnergySources.Remove(product);
                    energySourcesContext.SaveChanges();
                }
            }
        }
    }
}
