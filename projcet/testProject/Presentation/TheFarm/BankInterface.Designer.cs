namespace TheFarm
{
    partial class BankInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankInterface));
            this.deleteBankButton = new System.Windows.Forms.Button();
            this.infoBankButton = new System.Windows.Forms.Button();
            this.updateBankButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.machineButton = new System.Windows.Forms.Button();
            this.bankButton = new System.Windows.Forms.Button();
            this.energySourcesButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.ConvertorBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backBankButton = new System.Windows.Forms.Button();
            this.helpBankButton = new System.Windows.Forms.Button();
            this.bankDataView = new System.Windows.Forms.DataGridView();
            this.txtBankType = new System.Windows.Forms.TextBox();
            this.txtBankPrice = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBankButton = new System.Windows.Forms.Button();
            this.saveBankButton = new System.Windows.Forms.Button();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ConvertorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBankButton
            // 
            this.deleteBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.deleteBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBankButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBankButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteBankButton.Image")));
            this.deleteBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBankButton.Location = new System.Drawing.Point(1115, 13);
            this.deleteBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBankButton.Name = "deleteBankButton";
            this.deleteBankButton.Size = new System.Drawing.Size(179, 39);
            this.deleteBankButton.TabIndex = 33;
            this.deleteBankButton.Text = "Delete";
            this.deleteBankButton.UseVisualStyleBackColor = false;
            this.deleteBankButton.Click += new System.EventHandler(this.deleteBankButton_Click);
            // 
            // infoBankButton
            // 
            this.infoBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.infoBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBankButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBankButton.Image = ((System.Drawing.Image)(resources.GetObject("infoBankButton.Image")));
            this.infoBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoBankButton.Location = new System.Drawing.Point(928, 13);
            this.infoBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.infoBankButton.Name = "infoBankButton";
            this.infoBankButton.Size = new System.Drawing.Size(179, 39);
            this.infoBankButton.TabIndex = 32;
            this.infoBankButton.Text = "Info";
            this.infoBankButton.UseVisualStyleBackColor = false;
            this.infoBankButton.Click += new System.EventHandler(this.infoProductButton_Click);
            // 
            // updateBankButton
            // 
            this.updateBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.updateBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBankButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBankButton.Image = ((System.Drawing.Image)(resources.GetObject("updateBankButton.Image")));
            this.updateBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBankButton.Location = new System.Drawing.Point(742, 13);
            this.updateBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateBankButton.Name = "updateBankButton";
            this.updateBankButton.Size = new System.Drawing.Size(179, 39);
            this.updateBankButton.TabIndex = 31;
            this.updateBankButton.Text = "Update";
            this.updateBankButton.UseVisualStyleBackColor = false;
            this.updateBankButton.Click += new System.EventHandler(this.updateBankButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.machineButton);
            this.panel1.Controls.Add(this.bankButton);
            this.panel1.Controls.Add(this.energySourcesButton);
            this.panel1.Controls.Add(this.productButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 702);
            this.panel1.TabIndex = 35;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(68, 606);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 43);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // machineButton
            // 
            this.machineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.machineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.machineButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.machineButton.FlatAppearance.BorderSize = 0;
            this.machineButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.machineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.machineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.machineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.machineButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.machineButton.Image = ((System.Drawing.Image)(resources.GetObject("machineButton.Image")));
            this.machineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.machineButton.Location = new System.Drawing.Point(16, 188);
            this.machineButton.Margin = new System.Windows.Forms.Padding(4);
            this.machineButton.Name = "machineButton";
            this.machineButton.Size = new System.Drawing.Size(283, 116);
            this.machineButton.TabIndex = 2;
            this.machineButton.Text = "    Machines";
            this.machineButton.UseVisualStyleBackColor = false;
            this.machineButton.Click += new System.EventHandler(this.machineButton_Click);
            // 
            // bankButton
            // 
            this.bankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.bankButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.bankButton.FlatAppearance.BorderSize = 0;
            this.bankButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.bankButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.bankButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.bankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankButton.Image = ((System.Drawing.Image)(resources.GetObject("bankButton.Image")));
            this.bankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankButton.Location = new System.Drawing.Point(16, 457);
            this.bankButton.Margin = new System.Windows.Forms.Padding(4);
            this.bankButton.Name = "bankButton";
            this.bankButton.Size = new System.Drawing.Size(283, 116);
            this.bankButton.TabIndex = 4;
            this.bankButton.Text = "Bank";
            this.bankButton.UseVisualStyleBackColor = false;
            this.bankButton.Click += new System.EventHandler(this.bankButton_Click);
            // 
            // energySourcesButton
            // 
            this.energySourcesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.energySourcesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.energySourcesButton.FlatAppearance.BorderSize = 0;
            this.energySourcesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.energySourcesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.energySourcesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.energySourcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.energySourcesButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.energySourcesButton.Image = ((System.Drawing.Image)(resources.GetObject("energySourcesButton.Image")));
            this.energySourcesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.energySourcesButton.Location = new System.Drawing.Point(16, 322);
            this.energySourcesButton.Margin = new System.Windows.Forms.Padding(4);
            this.energySourcesButton.Name = "energySourcesButton";
            this.energySourcesButton.Size = new System.Drawing.Size(283, 116);
            this.energySourcesButton.TabIndex = 3;
            this.energySourcesButton.Text = "Energy\r\nSources\r\n";
            this.energySourcesButton.UseVisualStyleBackColor = false;
            this.energySourcesButton.Click += new System.EventHandler(this.energySourcesButton_Click);
            // 
            // productButton
            // 
            this.productButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.productButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.productButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.productButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(166)))));
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productButton.ForeColor = System.Drawing.Color.Black;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(16, 52);
            this.productButton.Margin = new System.Windows.Forms.Padding(4);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(283, 116);
            this.productButton.TabIndex = 1;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // ConvertorBox
            // 
            this.ConvertorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.ConvertorBox.Controls.Add(this.label4);
            this.ConvertorBox.Controls.Add(this.button1);
            this.ConvertorBox.Controls.Add(this.pictureBox1);
            this.ConvertorBox.Controls.Add(this.textBox1);
            this.ConvertorBox.Controls.Add(this.comboBox2);
            this.ConvertorBox.Controls.Add(this.comboBox1);
            this.ConvertorBox.Location = new System.Drawing.Point(411, 472);
            this.ConvertorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertorBox.Name = "ConvertorBox";
            this.ConvertorBox.Padding = new System.Windows.Forms.Padding(4);
            this.ConvertorBox.Size = new System.Drawing.Size(412, 218);
            this.ConvertorBox.TabIndex = 55;
            this.ConvertorBox.TabStop = false;
            this.ConvertorBox.Text = "Convertor";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(233, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Lev (lv.)",
            "Euro (€)",
            "Dollar ($)"});
            this.comboBox2.Location = new System.Drawing.Point(233, 116);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lev (lv.)",
            "Euro (€)",
            "Dollar ($)"});
            this.comboBox1.Location = new System.Drawing.Point(8, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // backBankButton
            // 
            this.backBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.backBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBankButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBankButton.Image = ((System.Drawing.Image)(resources.GetObject("backBankButton.Image")));
            this.backBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBankButton.Location = new System.Drawing.Point(1271, 624);
            this.backBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.backBankButton.Name = "backBankButton";
            this.backBankButton.Size = new System.Drawing.Size(179, 39);
            this.backBankButton.TabIndex = 54;
            this.backBankButton.Text = "Home";
            this.backBankButton.UseVisualStyleBackColor = false;
            this.backBankButton.Click += new System.EventHandler(this.backBankButton_Click);
            // 
            // helpBankButton
            // 
            this.helpBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.helpBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBankButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpBankButton.Image = ((System.Drawing.Image)(resources.GetObject("helpBankButton.Image")));
            this.helpBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBankButton.Location = new System.Drawing.Point(1084, 624);
            this.helpBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpBankButton.Name = "helpBankButton";
            this.helpBankButton.Size = new System.Drawing.Size(179, 39);
            this.helpBankButton.TabIndex = 53;
            this.helpBankButton.Text = "Help";
            this.helpBankButton.UseVisualStyleBackColor = false;
            this.helpBankButton.Click += new System.EventHandler(this.helpBankButton_Click);
            // 
            // bankDataView
            // 
            this.bankDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(242)))), ((int)(((byte)(213)))));
            this.bankDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankDataView.Location = new System.Drawing.Point(897, 87);
            this.bankDataView.Margin = new System.Windows.Forms.Padding(4);
            this.bankDataView.Name = "bankDataView";
            this.bankDataView.RowHeadersWidth = 51;
            this.bankDataView.Size = new System.Drawing.Size(552, 512);
            this.bankDataView.TabIndex = 52;
            // 
            // txtBankType
            // 
            this.txtBankType.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankType.Location = new System.Drawing.Point(556, 319);
            this.txtBankType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankType.Name = "txtBankType";
            this.txtBankType.Size = new System.Drawing.Size(252, 36);
            this.txtBankType.TabIndex = 51;
            // 
            // txtBankPrice
            // 
            this.txtBankPrice.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankPrice.Location = new System.Drawing.Point(556, 251);
            this.txtBankPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankPrice.Name = "txtBankPrice";
            this.txtBankPrice.Size = new System.Drawing.Size(252, 36);
            this.txtBankPrice.TabIndex = 50;
            // 
            // txtBankName
            // 
            this.txtBankName.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBankName.Location = new System.Drawing.Point(556, 188);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(252, 36);
            this.txtBankName.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(404, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 43);
            this.label3.TabIndex = 48;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(404, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 43);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(404, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 43);
            this.label1.TabIndex = 46;
            this.label1.Text = "Type:";
            // 
            // addBankButton
            // 
            this.addBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.addBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBankButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBankButton.Image = ((System.Drawing.Image)(resources.GetObject("addBankButton.Image")));
            this.addBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBankButton.Location = new System.Drawing.Point(555, 13);
            this.addBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.addBankButton.Name = "addBankButton";
            this.addBankButton.Size = new System.Drawing.Size(179, 39);
            this.addBankButton.TabIndex = 56;
            this.addBankButton.Text = "Add";
            this.addBankButton.UseVisualStyleBackColor = false;
            this.addBankButton.Click += new System.EventHandler(this.addBankButton_Click);
            // 
            // saveBankButton
            // 
            this.saveBankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.saveBankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBankButton.Image = ((System.Drawing.Image)(resources.GetObject("saveBankButton.Image")));
            this.saveBankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBankButton.Location = new System.Drawing.Point(897, 624);
            this.saveBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveBankButton.Name = "saveBankButton";
            this.saveBankButton.Size = new System.Drawing.Size(179, 39);
            this.saveBankButton.TabIndex = 57;
            this.saveBankButton.Text = "Save";
            this.saveBankButton.UseVisualStyleBackColor = false;
            this.saveBankButton.Click += new System.EventHandler(this.saveBankButton_Click);
            // 
            // ShowInfo
            // 
            this.ShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfo.Location = new System.Drawing.Point(482, 404);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(252, 34);
            this.ShowInfo.TabIndex = 60;
            this.ShowInfo.Text = "Show Information";
            this.ShowInfo.UseVisualStyleBackColor = true;
            this.ShowInfo.Visible = false;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(558, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 59;
            this.textBox2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(406, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Enter Id:";
            this.label5.Visible = false;
            // 
            // BankInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1535, 702);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBankButton);
            this.Controls.Add(this.addBankButton);
            this.Controls.Add(this.ConvertorBox);
            this.Controls.Add(this.backBankButton);
            this.Controls.Add(this.helpBankButton);
            this.Controls.Add(this.bankDataView);
            this.Controls.Add(this.txtBankType);
            this.Controls.Add(this.txtBankPrice);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBankButton);
            this.Controls.Add(this.infoBankButton);
            this.Controls.Add(this.updateBankButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.BankInterface_Load);
            this.panel1.ResumeLayout(false);
            this.ConvertorBox.ResumeLayout(false);
            this.ConvertorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBankButton;
        private System.Windows.Forms.Button infoBankButton;
        private System.Windows.Forms.Button updateBankButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button machineButton;
        private System.Windows.Forms.Button bankButton;
        private System.Windows.Forms.Button energySourcesButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.GroupBox ConvertorBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button backBankButton;
        private System.Windows.Forms.Button helpBankButton;
        private System.Windows.Forms.DataGridView bankDataView;
        private System.Windows.Forms.TextBox txtBankType;
        private System.Windows.Forms.TextBox txtBankPrice;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBankButton;
        private System.Windows.Forms.Button saveBankButton;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}