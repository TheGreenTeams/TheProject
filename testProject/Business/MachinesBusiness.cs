using testProject.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Business
{
    class MachinesBusiness
    {
        private MachinesContext machinesContext;

        public List<Machines> GetAll()
        {
            using (machinesContext = new MachinesContext())
            {
                return machinesContext.Machines.ToList();
            }
        }

        public Machines Get(int id)
        {
            using (machinesContext = new MachinesContext())
            {
                return machinesContext.Machines.Find(id);
            }
        }

        public void Add(Machines machines)
        {
            using (machinesContext = new MachinesContext())
            {
                machinesContext.Machines.Add(machines);
                machinesContext.SaveChanges();

            }
        }

        public void Update(Machines machines)
        {
            using (machinesContext = new MachinesContext())
            {
                var item = machinesContext.Machines.Find(machines.Id);
                if (item != null)
                {
                    machinesContext.Entry(item).CurrentValues.SetValues(machines);
                    machinesContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (machinesContext = new MachinesContext())
            {
                var product = machinesContext.Machines.Find(id);
                if (product != null)
                {
                    machinesContext.Machines.Remove(product);
                    machinesContext.SaveChanges();
                }
            }
        }
    }
}
