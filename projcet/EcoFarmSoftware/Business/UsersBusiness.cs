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
    public class UsersBusiness
    {
        public EcoFarmSoftwareContext ecoFarmSoftwareContext;

        public List<Users> GetAll()
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Userss.ToList();
            }
        }

        public Users Get(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                return ecoFarmSoftwareContext.Userss.Find(id);
            }
        }

        public void Add(Users users)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                bool un = true;
                foreach (var item in ecoFarmSoftwareContext.Userss)
                {
                    if (item.Username == users.Username)
                    {
                        un = false;
                    }
                }
                if (un == true)
                {
                    ecoFarmSoftwareContext.Userss.Add(users);
                    ecoFarmSoftwareContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Username is already taken!");
                }


            }
        }

        public void Update(Users users)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var item = ecoFarmSoftwareContext.Userss.Find(users.Id);
                if (item != null)
                {
                    ecoFarmSoftwareContext.Entry(item).CurrentValues.SetValues(users);
                    ecoFarmSoftwareContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (ecoFarmSoftwareContext = new EcoFarmSoftwareContext())
            {
                var user = ecoFarmSoftwareContext.Userss.Find(id);
                if (user != null)
                {
                    ecoFarmSoftwareContext.Userss.Remove(user);
                    ecoFarmSoftwareContext.SaveChanges();
                }
            }
        }
    }
}
