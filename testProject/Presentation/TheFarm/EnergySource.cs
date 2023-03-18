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
    public partial class EnergySource : Form
    {
        public EnergySource()
        {
            InitializeComponent();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnergySource_Load(object sender, EventArgs e)
        {

        }

        private void productButton_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.Show();
            this.Hide();
        }

        private void machineButton_Click(object sender, EventArgs e)
        {
            var machine = new Machine();
            machine.Show();
            this.Hide();
        }

        private void energySourcesButton_Click(object sender, EventArgs e)
        {
            var energySources = new EnergySource();
            energySources.Show();
            this.Hide();
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            var bank = new Bank();
            bank.Show();
            this.Hide();
        }


        private void backEnergySourcesButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void helpEnergySourcesButton_Click(object sender, EventArgs e)
        {
            var helpEnergySources = new EnergySourceHelp();
            helpEnergySources.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
