using System;
using Business;
using System.Windows.Forms;
using TheFarm;
using Data;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace testProject.TheFarm
{
    public partial class Product : Form
    {
        private ProductsBusiness productBusiness = new ProductsBusiness();
        private int editId = 0;

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        #region Form Buttons
        private void backProductButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            var bank = new BankInterface();
            bank.Show();
            this.Hide();
        }

        private void infoProductButton_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox1.Visible = true;
            ShowInfo.Visible = true;
        }


        #endregion

        #region Functions

        private void ClearTextBoxes()
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductStock.Text = "";
            txtProductType.Text = "";
        }

        private void UpdateGrid()
        {
            productDataView.DataSource = productBusiness.GetAll();
            productDataView.ReadOnly = true;
            productDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DisableSelect()
        {
            productDataView.Enabled = false;
        }

        private void UpdateTextboxes(int id)
        {
            Products update = productBusiness.Get(id);
            txtProductName.Text = update.Name;
            txtProductPrice.Text = update.Price.ToString();
            txtProductStock.Text = update.Stock.ToString();
            txtProductType.Text = update.Type.ToString();
        }

        private Products GetEditedProduct()
        {
            Products product = new Products();
            product.Id = editId;

            var name = txtProductName.Text;
            decimal price = 0;
            decimal.TryParse(txtProductPrice.Text, out price);
            int stock = 0;
            int.TryParse(txtProductStock.Text, out stock);
            var type = txtProductType.Text;

            product.Name = name;
            product.Price = price;
            product.Stock = stock;
            product.Type = type;

            return product;
        }

        private void ResetSelect()
        {
            productDataView.ClearSelection();
            productDataView.Enabled = true;
        }

        //
        private void Sell(int id)
        {
            Products product = productBusiness.Get(id);
            if (int.Parse(txtProductStock.Text) <= product.Stock)
            {
                product.Stock = product.Stock - int.Parse(txtProductStock.Text);
                productBusiness.Update(product);
            }
            else
            {
                MessageBox.Show("Invalid quantity value!");
            }
        }

        #endregion

        #region Buttons

        //Add
        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            Products product = new Products();

            product.Name = txtProductName.Text;
            product.Price = decimal.Parse(txtProductPrice.Text);
            product.Stock = int.Parse(txtProductStock.Text);
            product.Type = txtProductType.Text;
            productBusiness.Add(product);

            ClearTextBoxes();
            UpdateGrid();
        }

        //Update
        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (productDataView.SelectedRows.Count > 0)
            {
                var item = productDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                DisableSelect();
            }
        }

        //Save
        private void saveProductButton_Click(object sender, EventArgs e)
        {
            Products editedProduct = GetEditedProduct();
            productBusiness.Update(editedProduct);
            UpdateGrid();
            ResetSelect();
            ClearTextBoxes();
        }

        //Delete
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productDataView.SelectedRows.Count > 0)
            {
                var item = productDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        //Sell 
        private void sellProductButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtProductName.Visible = false;
            txtProductPrice.Visible = false;
            txtProductType.Visible = false;
            label7.Visible = true;
            button1.Visible = true;


            
        }

        //Info
        private void ShowInfo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Products product = productBusiness.Get(id);

            txtProductName.Text = product.Name;
            txtProductPrice.Text = product.Price.ToString();
            txtProductStock.Text = product.Stock.ToString();
            txtProductType.Text = product.Type;
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Sell 
        private void button1_Click(object sender, EventArgs e)
        {
            
            var item = productDataView.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            Products product = productBusiness.Get(id);
            editId = id;
            Sell(id);
            //UpdateTextboxes(id);
            
            decimal money = product.Price * int.Parse(txtProductStock.Text); // price * stock
            label8.Visible = true;
            //decimal money = product.Price;
            label8.Text = $"You received {money}lv.";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtProductName.Visible = true;
            txtProductPrice.Visible = true;
            txtProductType.Visible = true;
            label7.Visible = false;
            button1.Visible = false;
            txtProductStock.Clear();

            UpdateGrid();
            //DisableSelect();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
