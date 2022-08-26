namespace InventoryManagement
{
    partial class ManageProducts
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
            this.close = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.footPanel = new System.Windows.Forms.Panel();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.ProductDescription = new System.Windows.Forms.TextBox();
            this.ProductCategory = new System.Windows.Forms.ComboBox();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ProductShow = new System.Windows.Forms.DataGridView();
            this.gridTitle = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductShow)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.headPanel.Controls.Add(this.close);
            this.headPanel.Controls.Add(this.Heading);
            this.headPanel.Controls.Add(this.title);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1357, 159);
            this.headPanel.TabIndex = 2;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(1317, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 38);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label3_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Heading.Location = new System.Drawing.Point(373, 24);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(694, 57);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Inventory Management System";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(615, 102);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(272, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Manage Products";
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.footPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footPanel.Location = new System.Drawing.Point(0, 726);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(1357, 108);
            this.footPanel.TabIndex = 15;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductPrice.Location = new System.Drawing.Point(51, 405);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.PlaceholderText = "Product Price";
            this.ProductPrice.Size = new System.Drawing.Size(242, 43);
            this.ProductPrice.TabIndex = 19;
            // 
            // ProductQty
            // 
            this.ProductQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductQty.Location = new System.Drawing.Point(51, 337);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.PlaceholderText = "Product Qty";
            this.ProductQty.Size = new System.Drawing.Size(242, 43);
            this.ProductQty.TabIndex = 18;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(51, 271);
            this.ProductName.Name = "ProductName";
            this.ProductName.PlaceholderText = "Product Name";
            this.ProductName.Size = new System.Drawing.Size(242, 43);
            this.ProductName.TabIndex = 17;
            // 
            // ProductId
            // 
            this.ProductId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductId.Location = new System.Drawing.Point(51, 210);
            this.ProductId.Name = "ProductId";
            this.ProductId.PlaceholderText = "Product ID";
            this.ProductId.Size = new System.Drawing.Size(242, 43);
            this.ProductId.TabIndex = 16;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductDescription.Location = new System.Drawing.Point(51, 479);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.PlaceholderText = "Product Description";
            this.ProductDescription.Size = new System.Drawing.Size(242, 43);
            this.ProductDescription.TabIndex = 20;
            // 
            // ProductCategory
            // 
            this.ProductCategory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Location = new System.Drawing.Point(51, 554);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(242, 45);
            this.ProductCategory.TabIndex = 21;
            this.ProductCategory.Text = "Product Category";
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.Location = new System.Drawing.Point(360, 626);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(98, 47);
            this.home.TabIndex = 25;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(256, 626);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(98, 47);
            this.delete.TabIndex = 24;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit.Location = new System.Drawing.Point(152, 626);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 47);
            this.edit.TabIndex = 23;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(48, 626);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 47);
            this.add.TabIndex = 22;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductShow
            // 
            this.ProductShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductShow.Location = new System.Drawing.Point(615, 225);
            this.ProductShow.Name = "ProductShow";
            this.ProductShow.RowHeadersWidth = 51;
            this.ProductShow.RowTemplate.Height = 29;
            this.ProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductShow.Size = new System.Drawing.Size(663, 475);
            this.ProductShow.TabIndex = 27;
            this.ProductShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductShow_CellContentClick);
            // 
            // gridTitle
            // 
            this.gridTitle.AutoSize = true;
            this.gridTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridTitle.Location = new System.Drawing.Point(862, 177);
            this.gridTitle.Name = "gridTitle";
            this.gridTitle.Size = new System.Drawing.Size(167, 32);
            this.gridTitle.TabIndex = 26;
            this.gridTitle.Text = "Product List";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 834);
            this.Controls.Add(this.ProductShow);
            this.Controls.Add(this.gridTitle);
            this.Controls.Add(this.home);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.ProductDescription);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductQty);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headPanel;
        private Label close;
        private Label Heading;
        private Label title;
        private Panel footPanel;
        private TextBox ProductPrice;
        private TextBox ProductQty;
        private TextBox ProductName;
        private TextBox ProductId;
        private TextBox ProductDescription;
        private ComboBox ProductCategory;
        private Button home;
        private Button delete;
        private Button edit;
        private Button add;
        private DataGridView ProductShow;
        private Label gridTitle;
    }
}