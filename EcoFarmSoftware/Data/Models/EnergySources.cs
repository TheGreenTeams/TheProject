using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EnergySources
    {
        [Key]
        private int id;
        private string name;
        private decimal price;
        private string type;
        private decimal kWh;
        private decimal area;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public decimal KWh { get; set; }
        public decimal Area { get; set; }
    }
}
