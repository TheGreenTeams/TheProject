using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Data
{
    class BankContext : DbContext 
    {
        public BankContext() : base("name=BankContext")
        {

        }
        public DbSet<Bank> Bank { get; set; }
    }
}
