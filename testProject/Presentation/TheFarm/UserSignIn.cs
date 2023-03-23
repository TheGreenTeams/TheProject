using System;
using Business;
using Data;
using Data.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarm
{
    public partial class Form2 : Form
    {
        private UsersBusiness usersBusiness = new UsersBusiness();

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userLogIn = new UserLogIn();
            userLogIn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();

            users.FirstName = textBox1.Text;
            users.LastName = textBox2.Text;
            users.EMail = textBox4.Text;

            if (!users.EMail.Contains("@email.com"))
            {
                label4.Visible = true;
                label4.Text = "Invalid Email Address! Try again!";
                users.EMail = textBox4.Text;
                return;
            }
            users.EMail = users.EMail;
            users.Username = textBox3.Text;
            users.Password = textBox5.Text;
            usersBusiness.Add(users);

            var mainMenu = new Form1();
            mainMenu.Show();
            this.Hide();
        }
    }
}
