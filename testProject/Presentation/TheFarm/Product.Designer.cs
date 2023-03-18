namespace testProject.TheFarm
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.machineButton = new System.Windows.Forms.Button();
            this.bankButton = new System.Windows.Forms.Button();
            this.energySourcesButton = new System.Windows.Forms.Button();
            this.listAllProductButton = new System.Windows.Forms.Button();
            this.sellProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.infoProductButton = new System.Windows.Forms.Button();
            this.productDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.backProductButton = new System.Windows.Forms.Button();
            this.helpProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.productButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.machineButton);
            this.panel1.Controls.Add(this.bankButton);
            this.panel1.Controls.Add(this.energySourcesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 570);
            this.panel1.TabIndex = 1;
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
            this.productButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productButton.ForeColor = System.Drawing.Color.Black;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(12, 42);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(212, 94);
            this.productButton.TabIndex = 37;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click_1);
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
            this.exitButton.Location = new System.Drawing.Point(51, 492);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 35);
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
            this.machineButton.Location = new System.Drawing.Point(12, 153);
            this.machineButton.Name = "machineButton";
            this.machineButton.Size = new System.Drawing.Size(212, 94);
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
            this.bankButton.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankButton.Image = ((System.Drawing.Image)(resources.GetObject("bankButton.Image")));
            this.bankButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankButton.Location = new System.Drawing.Point(12, 371);
            this.bankButton.Name = "bankButton";
            this.bankButton.Size = new System.Drawing.Size(212, 94);
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
            this.energySourcesButton.Location = new System.Drawing.Point(12, 262);
            this.energySourcesButton.Name = "energySourcesButton";
            this.energySourcesButton.Size = new System.Drawing.Size(212, 94);
            this.energySourcesButton.TabIndex = 3;
            this.energySourcesButton.Text = "Energy\r\nSources\r\n";
            this.energySourcesButton.UseVisualStyleBackColor = false;
            this.energySourcesButton.Click += new System.EventHandler(this.energySourcesButton_Click);
            // 
            // listAllProductButton
            // 
            this.listAllProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.listAllProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listAllProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listAllProductButton.Image = ((System.Drawing.Image)(resources.GetObject("listAllProductButton.Image")));
            this.listAllProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listAllProductButton.Location = new System.Drawing.Point(961, 12);
            this.listAllProductButton.Name = "listAllProductButton";
            this.listAllProductButton.Size = new System.Drawing.Size(134, 32);
            this.listAllProductButton.TabIndex = 23;
            this.listAllProductButton.Text = "List All";
            this.listAllProductButton.UseVisualStyleBackColor = false;
            // 
            // sellProductButton
            // 
            this.sellProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.sellProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellProductButton.Image = ((System.Drawing.Image)(resources.GetObject("sellProductButton.Image")));
            this.sellProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellProductButton.Location = new System.Drawing.Point(821, 12);
            this.sellProductButton.Name = "sellProductButton";
            this.sellProductButton.Size = new System.Drawing.Size(134, 32);
            this.sellProductButton.TabIndex = 22;
            this.sellProductButton.Text = "Sell";
            this.sellProductButton.UseVisualStyleBackColor = false;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProductButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductButton.Image")));
            this.deleteProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteProductButton.Location = new System.Drawing.Point(681, 12);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(134, 32);
            this.deleteProductButton.TabIndex = 21;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            // 
            // infoProductButton
            // 
            this.infoProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.infoProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoProductButton.Image = ((System.Drawing.Image)(resources.GetObject("infoProductButton.Image")));
            this.infoProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoProductButton.Location = new System.Drawing.Point(541, 12);
            this.infoProductButton.Name = "infoProductButton";
            this.infoProductButton.Size = new System.Drawing.Size(134, 32);
            this.infoProductButton.TabIndex = 20;
            this.infoProductButton.Text = "Info";
            this.infoProductButton.UseVisualStyleBackColor = false;
            // 
            // productDataView
            // 
            this.productDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(242)))), ((int)(((byte)(213)))));
            this.productDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataView.Location = new System.Drawing.Point(681, 80);
            this.productDataView.Name = "productDataView";
            this.productDataView.RowHeadersWidth = 51;
            this.productDataView.Size = new System.Drawing.Size(414, 416);
            this.productDataView.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(311, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(311, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(311, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(311, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "Type:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductName.Location = new System.Drawing.Point(425, 162);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(190, 36);
            this.txtProductName.TabIndex = 29;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductPrice.Location = new System.Drawing.Point(425, 213);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(190, 36);
            this.txtProductPrice.TabIndex = 30;
            // 
            // txtProductStock
            // 
            this.txtProductStock.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductStock.Location = new System.Drawing.Point(425, 268);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(190, 36);
            this.txtProductStock.TabIndex = 31;
            // 
            // txtProductType
            // 
            this.txtProductType.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductType.Location = new System.Drawing.Point(425, 321);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(190, 36);
            this.txtProductType.TabIndex = 32;
            // 
            // backProductButton
            // 
            this.backProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.backProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backProductButton.Image = ((System.Drawing.Image)(resources.GetObject("backProductButton.Image")));
            this.backProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backProductButton.Location = new System.Drawing.Point(961, 516);
            this.backProductButton.Name = "backProductButton";
            this.backProductButton.Size = new System.Drawing.Size(134, 32);
            this.backProductButton.TabIndex = 34;
            this.backProductButton.Text = "Back";
            this.backProductButton.UseVisualStyleBackColor = false;
            this.backProductButton.Click += new System.EventHandler(this.backProductButton_Click);
            // 
            // helpProductButton
            // 
            this.helpProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.helpProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpProductButton.Image = ((System.Drawing.Image)(resources.GetObject("helpProductButton.Image")));
            this.helpProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpProductButton.Location = new System.Drawing.Point(821, 516);
            this.helpProductButton.Name = "helpProductButton";
            this.helpProductButton.Size = new System.Drawing.Size(134, 32);
            this.helpProductButton.TabIndex = 33;
            this.helpProductButton.Text = "Help";
            this.helpProductButton.UseVisualStyleBackColor = false;
            this.helpProductButton.Click += new System.EventHandler(this.helpProductButton_Click);
            // 
            // updateProductButton
            // 
            this.updateProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.updateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateProductButton.Image = ((System.Drawing.Image)(resources.GetObject("updateProductButton.Image")));
            this.updateProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateProductButton.Location = new System.Drawing.Point(401, 12);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(134, 32);
            this.updateProductButton.TabIndex = 36;
            this.updateProductButton.Text = "Update";
            this.updateProductButton.UseVisualStyleBackColor = false;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductButton.Image = ((System.Drawing.Image)(resources.GetObject("addProductButton.Image")));
            this.addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductButton.Location = new System.Drawing.Point(261, 12);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(134, 32);
            this.addProductButton.TabIndex = 35;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click_1);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(237)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1151, 570);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.backProductButton);
            this.Controls.Add(this.helpProductButton);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDataView);
            this.Controls.Add(this.listAllProductButton);
            this.Controls.Add(this.sellProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.infoProductButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button machineButton;
        private System.Windows.Forms.Button bankButton;
        private System.Windows.Forms.Button energySourcesButton;
        private System.Windows.Forms.Button listAllProductButton;
        private System.Windows.Forms.Button sellProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button infoProductButton;
        private System.Windows.Forms.DataGridView productDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Button backProductButton;
        private System.Windows.Forms.Button helpProductButton;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button productButton;
    }
}