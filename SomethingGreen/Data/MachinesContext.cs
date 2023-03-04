using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Data
{
    class MachinesContext : DbContext
    {
        public MachinesContext() : base("name=MachinesContext")
        {

        }
        public DbSet<Machines> Machines { get; set; }
    }
}
