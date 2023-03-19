using System;
using testProject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheFarm;

namespace testProject.TheFarm
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGrid()
        {
            //productDataView.DataSource = productDataView.GetAll();
            //productDataView.ReadOnly = true;
            //productDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void backProductButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpProductButton_Click(object sender, EventArgs e)
        {
            var helpProducts = new ProductHelp();
            helpProducts.Show();
        }

        private void productButton_Click_1(object sender, EventArgs e)
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

        private void addProductButton_Click_1(object sender, EventArgs e)
        {

        }

        private void listAllProductButton_Click(object sender, EventArgs e)
        {

        }

        private void infoProductButton_Click(object sender, EventArgs e)
        {
            var info = new ProductInfo();
            info.Show();
        }
    }
}
