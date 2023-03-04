using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Data
{
    class EnergySources
    {
        private int id;
        private string name;
        private double price;
        private string type;
        private double kWh;
        private double area;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string KWh { get; set; }
        public string Area { get; set; }
    }
}
