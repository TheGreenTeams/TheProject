using testProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Business
{
    class UsersBusiness
    {
        public UsersContext usersContext;

        public List<Users> GetAll()
        {
            using (usersContext = new UsersContext())
            {
                return usersContext.Userss.ToList();
            }
        }

        public Users Get(int id)
        {
            using (usersContext = new UsersContext())
            {
                return usersContext.Userss.Find(id);
            }
        }

        public void Add(Users users)
        {
            using (usersContext = new UsersContext())
            {
                bool un = true;
                foreach (var item in usersContext.Userss)
                {
                    if (item.Username == users.Username)
                    {
                        un = false;
                    }
                }
                if (un == true)
                {
                    usersContext.Userss.Add(users);
                    usersContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Username is already taken!");
                }

                
            }
        }

        public void Update(Users users)
        {
            using (usersContext = new UsersContext())
            {
                var item = usersContext.Userss.Find(users.Id);
                if (item != null)
                {
                    usersContext.Entry(item).CurrentValues.SetValues(users);
                    usersContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (usersContext = new UsersContext())
            {
                var user = usersContext.Userss.Find(id);
                if (user != null)
                {
                    usersContext.Userss.Remove(user);
                    usersContext.SaveChanges();
                }
            }
        }
    }   
}
