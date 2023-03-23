using System;
using Business;
using System.Windows.Forms;
using TheFarm;
using Data;
using testProject.TheFarm;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace TheFarm
{
    public partial class Machine : Form
    {
        private MachinesBusiness machinesBusiness = new MachinesBusiness();
        private int editId = 0;

        public Machine()
        {
            InitializeComponent();
        }

        private void Machine_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        #region Forms
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void helpMachinesButton_Click(object sender, EventArgs e)
        {
            var helpMachines = new MachineHelp();
            helpMachines.Show();
        }

        private void backMachinesButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            mainForm.Show();
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
            var bank = new BankInterface();
            bank.Show();
            this.Hide();
        }

        private void infoMachineButton_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox1.Visible = true;
            ShowInfo.Visible = true;
        }
        #endregion

        #region Functions

        private void UpdateGrid()
        {
            machineDataView.DataSource = machinesBusiness.GetAll();
            machineDataView.ReadOnly = true;
            machineDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateTextboxes(int id)
        {
            Machines update = machinesBusiness.Get(id);
            txtNameMachine.Text = update.Name;
            txtTypeMachine.Text = update.Type;
            txtCapacityMachine.Text = update.WorkingCapacity.ToString();
        }

        private void DisableSelect()
        {
            machineDataView.Enabled = false;
        }

        private void ClearTextBoxes()
        {
            txtNameMachine.Text = "";
            txtTypeMachine.Text = "";
            txtCapacityMachine.Text = "";
        }

        private Machines GetEditedMachines()
        {
            Machines machine = new Machines();
            machine.Id = editId;

            var name = txtNameMachine.Text;
            var type = txtTypeMachine.Text;
            decimal capacity = 0;
            decimal.TryParse(txtCapacityMachine.Text, out capacity);

            machine.Name = name;
            machine.Type = type;
            machine.WorkingCapacity = capacity;

            return machine;
        }

        private void ResetSelect()
        {
            machineDataView.ClearSelection();
            machineDataView.Enabled = true;
        }

        #endregion

        #region Buttons

        //Add
        private void addMachinetButton_Click(object sender, EventArgs e)
        {
            Machines machine = new Machines();

            machine.Name = txtNameMachine.Text;
            machine.Type = txtTypeMachine.Text;
            machine.WorkingCapacity = decimal.Parse(txtCapacityMachine.Text);
            machinesBusiness.Add(machine);

            ClearTextBoxes();
            UpdateGrid();
        }

        //Update
        private void updateMachineButton_Click(object sender, EventArgs e)
        {
            if (machineDataView.SelectedRows.Count > 0)
            {
                var item = machineDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                DisableSelect();
            }
        }

        //Save
        private void saveMachineButton_Click(object sender, EventArgs e)
        {
            Machines editedMachine = GetEditedMachines();
            machinesBusiness.Update(editedMachine);
            UpdateGrid();
            ResetSelect();
            ClearTextBoxes();
        }


        //Info

        //Delete
        private void deleteMachineButton_Click(object sender, EventArgs e)
        {
            if (machineDataView.SelectedRows.Count > 0)
            {
                var item = machineDataView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                machinesBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        #endregion

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Machines machine = machinesBusiness.Get(id);

            txtNameMachine.Text = machine.Name;
            txtTypeMachine.Text = machine.Type.ToString();
            txtCapacityMachine.Text = machine.WorkingCapacity.ToString();
        }
    }
}
