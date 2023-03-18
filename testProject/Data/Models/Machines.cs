using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Data
{
    class Machines
    {
        [Key]
        private int id;
        private string name;
        private string type;
        private decimal workingCapacity;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal WorkingCapacity { get; set; }
    }
}
