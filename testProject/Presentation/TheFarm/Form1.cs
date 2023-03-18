using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testProject.TheFarm;

namespace TheFarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productButton_Click_1(object sender, EventArgs e)
        {
            var product = new Product();
            product.Show();
            this.Hide();
        }

        private void machineButton_Click_1(object sender, EventArgs e)
        {
            var machine = new Machine();
            machine.Show();
            this.Hide();
        }

        private void energySourcesButton_Click_1(object sender, EventArgs e)
        {
            var energySources = new EnergySource();
            energySources.Show();
            this.Hide();
        }

        private void bankButton_Click_1(object sender, EventArgs e)
        {
            var bank = new Bank();
            bank.Show();
            this.Hide();
        }
    }
}
