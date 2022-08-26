namespace InventoryManagement
{
    partial class ManageOrders
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
            this.heading = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.footPanel = new System.Windows.Forms.Panel();
            this.CustomerShow = new System.Windows.Forms.DataGridView();
            this.ProductShow = new System.Windows.Forms.DataGridView();
            this.OrderShow = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.cxTitle = new System.Windows.Forms.Label();
            this.productTitle = new System.Windows.Forms.Label();
            this.orderTitle = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.OrderQty = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.priceDisplay = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderShow)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.headPanel.Controls.Add(this.label3);
            this.headPanel.Controls.Add(this.heading);
            this.headPanel.Controls.Add(this.title);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1718, 159);
            this.headPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1679, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(542, 34);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(694, 57);
            this.heading.TabIndex = 1;
            this.heading.Text = "Inventory Management System";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(792, 107);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Manage Orders";
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.footPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footPanel.Location = new System.Drawing.Point(0, 911);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(1718, 108);
            this.footPanel.TabIndex = 11;
            // 
            // CustomerShow
            // 
            this.CustomerShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerShow.Location = new System.Drawing.Point(48, 216);
            this.CustomerShow.Name = "CustomerShow";
            this.CustomerShow.RowHeadersWidth = 51;
            this.CustomerShow.RowTemplate.Height = 29;
            this.CustomerShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerShow.Size = new System.Drawing.Size(711, 295);
            this.CustomerShow.TabIndex = 17;
            this.CustomerShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerShow_CellContentClick);
            // 
            // ProductShow
            // 
            this.ProductShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductShow.Location = new System.Drawing.Point(48, 593);
            this.ProductShow.Name = "ProductShow";
            this.ProductShow.RowHeadersWidth = 51;
            this.ProductShow.RowTemplate.Height = 29;
            this.ProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductShow.Size = new System.Drawing.Size(808, 296);
            this.ProductShow.TabIndex = 18;
            this.ProductShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductShow_CellContentClick);
            // 
            // OrderShow
            // 
            this.OrderShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderShow.Location = new System.Drawing.Point(862, 593);
            this.OrderShow.Name = "OrderShow";
            this.OrderShow.RowHeadersWidth = 51;
            this.OrderShow.RowTemplate.Height = 29;
            this.OrderShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderShow.Size = new System.Drawing.Size(807, 296);
            this.OrderShow.TabIndex = 19;
            this.OrderShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderShow_CellContentClick);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.Location = new System.Drawing.Point(1415, 412);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(98, 47);
            this.home.TabIndex = 24;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(1311, 412);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(98, 47);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(1207, 473);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(98, 47);
            this.clear.TabIndex = 22;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(1207, 412);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 47);
            this.add.TabIndex = 21;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // cxTitle
            // 
            this.cxTitle.AutoSize = true;
            this.cxTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cxTitle.Location = new System.Drawing.Point(312, 171);
            this.cxTitle.Name = "cxTitle";
            this.cxTitle.Size = new System.Drawing.Size(189, 32);
            this.cxTitle.TabIndex = 25;
            this.cxTitle.Text = "Customer List";
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productTitle.Location = new System.Drawing.Point(312, 548);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(167, 32);
            this.productTitle.TabIndex = 26;
            this.productTitle.Text = "Product List";
            // 
            // orderTitle
            // 
            this.orderTitle.AutoSize = true;
            this.orderTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderTitle.Location = new System.Drawing.Point(1196, 548);
            this.orderTitle.Name = "orderTitle";
            this.orderTitle.Size = new System.Drawing.Size(144, 32);
            this.orderTitle.TabIndex = 27;
            this.orderTitle.Text = "Order List";
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerName.Location = new System.Drawing.Point(1211, 343);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.PlaceholderText = "Customer Name";
            this.CustomerName.Size = new System.Drawing.Size(255, 43);
            this.CustomerName.TabIndex = 29;
            // 
            // CustomerId
            // 
            this.CustomerId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerId.Location = new System.Drawing.Point(1211, 277);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.PlaceholderText = "Customer Id";
            this.CustomerId.Size = new System.Drawing.Size(255, 43);
            this.CustomerId.TabIndex = 28;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductPrice.Location = new System.Drawing.Point(1211, 216);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.PlaceholderText = "Product Price";
            this.ProductPrice.Size = new System.Drawing.Size(255, 43);
            this.ProductPrice.TabIndex = 33;
            // 
            // OrderQty
            // 
            this.OrderQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderQty.Location = new System.Drawing.Point(931, 411);
            this.OrderQty.Name = "OrderQty";
            this.OrderQty.PlaceholderText = "Order Qty";
            this.OrderQty.Size = new System.Drawing.Size(242, 43);
            this.OrderQty.TabIndex = 32;
            this.OrderQty.TextChanged += new System.EventHandler(this.OrderQty_TextChanged);
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(931, 343);
            this.ProductName.Name = "ProductName";
            this.ProductName.PlaceholderText = "Product Name";
            this.ProductName.Size = new System.Drawing.Size(242, 43);
            this.ProductName.TabIndex = 31;
            // 
            // ProductId
            // 
            this.ProductId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductId.Location = new System.Drawing.Point(931, 277);
            this.ProductId.Name = "ProductId";
            this.ProductId.PlaceholderText = "Product ID";
            this.ProductId.Size = new System.Drawing.Size(242, 43);
            this.ProductId.TabIndex = 30;
            // 
            // OrderId
            // 
            this.OrderId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderId.Location = new System.Drawing.Point(931, 216);
            this.OrderId.Name = "OrderId";
            this.OrderId.PlaceholderText = "Order ID";
            this.OrderId.Size = new System.Drawing.Size(242, 43);
            this.OrderId.TabIndex = 34;
            // 
            // priceDisplay
            // 
            this.priceDisplay.AutoSize = true;
            this.priceDisplay.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceDisplay.Location = new System.Drawing.Point(931, 479);
            this.priceDisplay.Name = "priceDisplay";
            this.priceDisplay.Size = new System.Drawing.Size(107, 32);
            this.priceDisplay.TabIndex = 35;
            this.priceDisplay.Text = "Total: $";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 1019);
            this.Controls.Add(this.priceDisplay);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.OrderQty);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.home);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.orderTitle);
            this.Controls.Add(this.productTitle);
            this.Controls.Add(this.cxTitle);
            this.Controls.Add(this.OrderShow);
            this.Controls.Add(this.ProductShow);
            this.Controls.Add(this.CustomerShow);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headPanel;
        private Label label3;
        private Label heading;
        private Label title;
        private Panel footPanel;
        private DataGridView CustomerShow;
        private DataGridView ProductShow;
        private DataGridView OrderShow;
        private Button home;
        private Button delete;
        private Button clear;
        private Button add;
        private Label cxTitle;
        private Label productTitle;
        private Label orderTitle;
        private TextBox CustomerName;
        private TextBox CustomerId;
        private TextBox ProductPrice;
        private TextBox OrderQty;
        private TextBox ProductName;
        private TextBox ProductId;
        private TextBox OrderId;
        private Label priceDisplay;
    }
}