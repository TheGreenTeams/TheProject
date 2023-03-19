using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Data
{
    class BankContext : DbContext
    {
        public BankContext() : base("name=BankContext")
        {

        }
        public DbSet<Bank> Banks { get; set; }
    }
}
