using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Data
{
    class EnergySourcesContext : DbContext
    {
        public EnergySourcesContext() : base("name=EnergySourcesContext")
        {

        }
        public DbSet<EnergySources> EnergySources { get; set; }
    }
}
