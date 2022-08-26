namespace InventoryManagement
{
    partial class ManageCustomers
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.footPanel = new System.Windows.Forms.Panel();
            this.CustomerContact = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.gridTitle = new System.Windows.Forms.Label();
            this.CustomerShow = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerShow)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.headPanel.Controls.Add(this.label3);
            this.headPanel.Controls.Add(this.Heading);
            this.headPanel.Controls.Add(this.title);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1357, 159);
            this.headPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1317, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Heading.Location = new System.Drawing.Point(323, 25);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(694, 57);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Inventory Management System";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(533, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Manage Customers";
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.footPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footPanel.Location = new System.Drawing.Point(0, 726);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(1357, 108);
            this.footPanel.TabIndex = 14;
            // 
            // CustomerContact
            // 
            this.CustomerContact.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerContact.Location = new System.Drawing.Point(141, 453);
            this.CustomerContact.Name = "CustomerContact";
            this.CustomerContact.PlaceholderText = "Customer Contact";
            this.CustomerContact.Size = new System.Drawing.Size(255, 43);
            this.CustomerContact.TabIndex = 13;
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerName.Location = new System.Drawing.Point(141, 362);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.PlaceholderText = "Customer Name";
            this.CustomerName.Size = new System.Drawing.Size(255, 43);
            this.CustomerName.TabIndex = 12;
            // 
            // CustomerId
            // 
            this.CustomerId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerId.Location = new System.Drawing.Point(141, 277);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.PlaceholderText = "Customer Id";
            this.CustomerId.Size = new System.Drawing.Size(255, 43);
            this.CustomerId.TabIndex = 11;
            // 
            // gridTitle
            // 
            this.gridTitle.AutoSize = true;
            this.gridTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridTitle.Location = new System.Drawing.Point(869, 174);
            this.gridTitle.Name = "gridTitle";
            this.gridTitle.Size = new System.Drawing.Size(189, 32);
            this.gridTitle.TabIndex = 15;
            this.gridTitle.Text = "Customer List";
            // 
            // CustomerShow
            // 
            this.CustomerShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerShow.Location = new System.Drawing.Point(637, 220);
            this.CustomerShow.Name = "CustomerShow";
            this.CustomerShow.RowHeadersWidth = 51;
            this.CustomerShow.RowTemplate.Height = 29;
            this.CustomerShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerShow.Size = new System.Drawing.Size(663, 485);
            this.CustomerShow.TabIndex = 16;
            this.CustomerShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerShow_CellContentClick);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.Location = new System.Drawing.Point(220, 611);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(98, 47);
            this.home.TabIndex = 20;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(324, 544);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(98, 47);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit.Location = new System.Drawing.Point(220, 544);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 47);
            this.edit.TabIndex = 18;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(116, 544);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 47);
            this.add.TabIndex = 17;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 834);
            this.Controls.Add(this.home);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CustomerShow);
            this.Controls.Add(this.gridTitle);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.CustomerContact);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headPanel;
        private Label label3;
        private Label Heading;
        private Label title;
        private Panel footPanel;
        private TextBox CustomerContact;
        private TextBox CustomerName;
        private TextBox CustomerId;
        private Label gridTitle;
        private DataGridView CustomerShow;
        private Button home;
        private Button delete;
        private Button edit;
        private Button add;
    }
}