using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EcoFarmSoftwareContext : DbContext
    {
        public EcoFarmSoftwareContext() : base("EcoFarmSoftwareContext")
        {

        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<EnergySources> EnergySources { get; set; }
        public DbSet<Machines> Machines { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Userss { get; set; }
    }
}
