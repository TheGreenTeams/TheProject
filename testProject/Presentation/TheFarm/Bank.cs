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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void helpBankButton_Click(object sender, EventArgs e)
        {
            var helpBank = new BankHelp();
            helpBank.Show();
        }

        private void backBankButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double currency1 = double.Parse(textBox1.Text);
            
            if (comboBox1.Text == "Lev (lv.)" && comboBox2.Text == "Euro (€)")
            {
                currency1 *= 0.51;
                textBox2.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Euro (€)" && comboBox2.Text == "Lev (lv.)")
            {
                currency1 *= 1.91;
                textBox2.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Lev (lv.)" && comboBox2.Text == "Dollar ($)")
            {
                currency1 *= 0.55;
                textBox2.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Dollar ($)" && comboBox2.Text == "Lev (lv.)")
            {
                currency1 *= 1.83;
                textBox2.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Dollar ($)" && comboBox2.Text == "Euro (€)")
            {
                currency1 *= 0.94;
                textBox2.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Euro (€)" && comboBox2.Text == "Dollar ($)")
            {
                currency1 *= 1.07;
                textBox2.Text = $"{currency1}";
            }
        }
    }
}
