using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Products
    {
        [Key]
        private int id;
        private string name;
        private decimal price;
        private int stock;
        private string type;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }
    }
}
