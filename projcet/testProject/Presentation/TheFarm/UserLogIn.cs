﻿using Business;
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheFarm
{
    public partial class UserLogIn : Form
    {
        private UsersBusiness usersBusiness = new UsersBusiness();

        public UserLogIn()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var userSignIn = new Form2();
            userSignIn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usersContext = new EcoFarmSoftwareContext();

            string Username = textBox1.Text;
            string Password = textBox2.Text;

            foreach (var item in usersContext.Userss)
            {
                if (item.Username == Username && item.Password == Password)
                {
                    var mainMenu = new Form1();
                    mainMenu.Show();
                    this.Hide();
                    break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}