using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Data
{
    class Bank
    {
        [Key]
        private int id;
        private string name;
        private decimal balance;
        private string type;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Type { get; set; }
    }
}
