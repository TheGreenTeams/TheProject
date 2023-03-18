using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addProduct = new AddNewProductForm();
            addProduct.Show();
            this.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var updateProduct = new UpdateProductForm();
            updateProduct.Show();
            this.Hide();

        }

        private void productInfoButton_Click(object sender, EventArgs e)
        {
            var productInfo = new InfoProductForm();
            productInfo.Show();
            this.Hide();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var deleteProduct = new DeleteProductForm();
            deleteProduct.Show();
            this.Hide();

        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            var sellProduct = new SellProductForm();
            sellProduct.Show();
            this.Hide();

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.Show();
            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
