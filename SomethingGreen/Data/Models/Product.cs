using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Data
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private int stock;
        private string type;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }
    }
}
