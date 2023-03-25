using Business;
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testProject.TheFarm;

namespace TheFarm
{
    public partial class BankInterface : Form
    {
        private BankBusiness bankBusiness = new BankBusiness();
        private int editId = 0;

        public BankInterface()
        {
            InitializeComponent();
        }

        private void BankInterface_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        #region Form Buttons
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            var bank = new BankInterface();
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

        private void infoProductButton_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox2.Visible = true;
            ShowInfo.Visible = true;
        }
        #endregion 

        #region Currency Convertor
        private void button1_Click(object sender, EventArgs e)
        {
            double currency1 = double.Parse(textBox1.Text);
            
            if (comboBox1.Text == "Lev (lv.)" && comboBox2.Text == "Euro (€)")
            {
                currency1 *= 0.51;
                label4.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Euro (€)" && comboBox2.Text == "Lev (lv.)")
            {
                currency1 *= 1.91;
                label4.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Lev (lv.)" && comboBox2.Text == "Dollar ($)")
            {
                currency1 *= 0.55;
                label4.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Dollar ($)" && comboBox2.Text == "Lev (lv.)")
            {
                currency1 *= 1.83;
                label4.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Dollar ($)" && comboBox2.Text == "Euro (€)")
            {
                currency1 *= 0.94;
                label4.Text = $"{currency1}";
            }
            if (comboBox1.Text == "Euro (€)" && comboBox2.Text == "Dollar ($)")
            {
                currency1 *= 1.07;
                label4.Text = $"{currency1}";
            }
        }
        #endregion

        #region Functions

        private void ClearTextBoxes()
        {
            txtBankName.Text = "";
            txtBankPrice.Text = "";
            txtBankType.Text = "";
        }

        private void UpdateGrid()
        {
            bankDataView.DataSource = bankBusiness.GetAll();
            bankDataView.ReadOnly = true;
            bankDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DisableSelect()
        {
            bankDataView.Enabled = false;
        }

        private void UpdateTextboxes(int id)
        {
            Bank update = bankBusiness.Get(id);
            txtBankName.Text = update.Name;
            txtBankPrice.Text = update.Balance.ToString();
            txtBankType.Text = update.Type;
        }

        private Bank GetEditedBank()
        {
            Bank bank = new Bank();
            bank.Id = editId;

            var name = txtBankName.Text;
            decimal price = 0;
            decimal.TryParse(txtBankPrice.Text, out price);
            var type = txtBankType.Text;

            bank.Name = name;
            bank.Balance = price;
            bank.Type = type;

            return bank;
        }

        private void ResetSelect()
        {
            bankDataView.ClearSelection();
            bankDataView.Enabled = true;
        }
        #endregion

        #region Buttons

        //Add
        private void addBankButton_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank();
            bank.Name = txtBankName.Text;
            bank.Balance = decimal.Parse(txtBankPrice.Text);
            bank.Type = txtBankType.Text;
            bankBusiness.Add(bank);

            ClearTextBoxes();
            UpdateGrid();
        }

        //Update
        private void updateBankButton_Click(object sender, EventArgs e)
        {
            if (bankDataView.SelectedRows.Count > 0)
            {
                var item = bankDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                DisableSelect();
            }
        }

        //Save
        private void saveBankButton_Click(object sender, EventArgs e)
        {
            Bank editedBank = GetEditedBank();
            bankBusiness.Update(editedBank);
            UpdateGrid();
            ResetSelect();
            ClearTextBoxes();
        }

        //Delete
        private void deleteBankButton_Click(object sender, EventArgs e)
        {
            if (bankDataView.SelectedRows.Count > 0)
            {
                var item = bankDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                bankBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        //Info
        private void ShowInfo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            Bank product = bankBusiness.Get(id);

            txtBankName.Text = product.Name;
            txtBankPrice.Text = product.Balance.ToString();
            txtBankType.Text = product.Type;
        }
        #endregion


    }
}
