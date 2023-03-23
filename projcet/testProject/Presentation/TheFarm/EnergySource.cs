using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
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
        private EnergySourcesBusiness energySourcesBusiness = new EnergySourcesBusiness();
        private int editId = 0;

        public EnergySource()
        {
            InitializeComponent();
        }

        #region Form Buttons
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void EnergySource_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
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
            Environment.Exit(0);
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
            txtNameEnergy.Text = "";
            txtPriceEnergy.Text = "";
            txtTypeEnergy.Text = "";
            txtPowerEnergy.Text = "";
            txtAreaEnergy.Text = "";
        }

        private void UpdateGrid()
        {
            energyDataView.DataSource = energySourcesBusiness.GetAll();
            energyDataView.ReadOnly = true;
            energyDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DisableSelect()
        {
            energyDataView.Enabled = false;
        }

        private void UpdateTextboxes(int id)
        {
            EnergySources update = energySourcesBusiness.Get(id);
            txtNameEnergy.Text = update.Name;
            txtPriceEnergy.Text = update.Price.ToString();
            txtTypeEnergy.Text = update.Type.ToString();
            txtPowerEnergy.Text = update.KWh.ToString();
            txtAreaEnergy.Text = update.Area.ToString();
        }

        private EnergySources GetEditedEnergySource()
        {
            EnergySources energySource = new EnergySources();
            energySource.Id = editId;

            var name = txtNameEnergy.Text;
            decimal price = 0;
            decimal.TryParse(txtPriceEnergy.Text, out price);
            var type = txtTypeEnergy.Text;
            decimal power = 0;
            decimal.TryParse(txtPowerEnergy.Text, out power);
            decimal area = 0;
            decimal.TryParse(txtAreaEnergy.Text, out area);

            energySource.Name = name;
            energySource.Price = price;
            energySource.Type = type;
            energySource.KWh = power;
            energySource.Area = area;

            return energySource;
        }

        private void ResetSelect()
        {
            energyDataView.ClearSelection();
            energyDataView.Enabled = true;
        }

        #endregion

        #region Buttons
        //Add
        private void addEnergySourceButton_Click(object sender, EventArgs e)
        {
            EnergySources energySource = new EnergySources();

            energySource.Name = txtNameEnergy.Text;
            energySource.Price = decimal.Parse(txtPriceEnergy.Text);
            energySource.Type = txtTypeEnergy.Text;
            energySource.KWh = decimal.Parse(txtPowerEnergy.Text);
            energySource.Area = decimal.Parse(txtAreaEnergy.Text);
            energySourcesBusiness.Add(energySource);

            ClearTextBoxes();
            UpdateGrid();
        }

        //Update
        private void updateEnergySourceButton_Click(object sender, EventArgs e)
        {
            if (energyDataView.SelectedRows.Count > 0)
            {
                var item = energyDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                DisableSelect();
            }
        }


        //Save
        private void saveEnergyButton_Click(object sender, EventArgs e)
        {
            EnergySources editedEnergySources = GetEditedEnergySource();
            energySourcesBusiness.Update(editedEnergySources);
            UpdateGrid();
            ResetSelect();
            ClearTextBoxes();
        }

        //Delete
        private void deleteEnergySourceButton_Click(object sender, EventArgs e)
        {
            if (energyDataView.SelectedRows.Count > 0)
            {
                var item = energyDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                energySourcesBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        //Info
        private void ShowInfo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            EnergySources energySources = energySourcesBusiness.Get(id);

            txtNameEnergy.Text = energySources.Name;
            txtPriceEnergy.Text = energySources.Price.ToString();
            txtTypeEnergy.Text = energySources.Type;
            txtPowerEnergy.Text = energySources.KWh.ToString();
            txtAreaEnergy.Text = energySources.Area.ToString();
        }
        #endregion
    }
}
