﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=ProductContext")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
