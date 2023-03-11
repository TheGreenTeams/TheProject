using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingGreen.Data
{
    class Bank
    {
        private int id;
        private string name;
        private double availability; 
        private string type;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Availability { get; set; }
        public string Type { get; set; }
    }
}
