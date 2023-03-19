using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("name=UsersContext")
        {

        }
        public DbSet<Users> Userss { get; set; }
    }
}
