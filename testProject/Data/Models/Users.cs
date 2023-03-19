using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace testProject.Data
{
    public class Users
    {
        [Key]
        private int id;
        private string firstName ;
        private string lastName;
        private string username;
        private string eMail;
        private string password;
        

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

    }
}
