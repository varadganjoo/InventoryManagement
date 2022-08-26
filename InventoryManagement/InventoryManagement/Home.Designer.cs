namespace InventoryManagement
{
	partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.users = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.Heading);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 159);
            this.panel1.TabIndex = 3;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(1318, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 38);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Heading.Location = new System.Drawing.Point(341, 28);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(694, 57);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Inventory Management System";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(648, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(104, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 726);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1357, 108);
            this.panel2.TabIndex = 20;
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.users.Location = new System.Drawing.Point(87, 318);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(164, 67);
            this.users.TabIndex = 21;
            this.users.Text = "Users";
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // customers
            // 
            this.customers.AutoSize = true;
            this.customers.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customers.Location = new System.Drawing.Point(510, 318);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(290, 67);
            this.customers.TabIndex = 22;
            this.customers.Text = "Customers";
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // products
            // 
            this.products.AutoSize = true;
            this.products.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.products.Location = new System.Drawing.Point(1022, 318);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(249, 67);
            this.products.TabIndex = 23;
            this.products.Text = "Products";
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orders.Location = new System.Drawing.Point(819, 558);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(195, 67);
            this.orders.TabIndex = 24;
            this.orders.Text = "Orders";
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // categories
            // 
            this.categories.AutoSize = true;
            this.categories.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categories.Location = new System.Drawing.Point(225, 558);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(290, 67);
            this.categories.TabIndex = 25;
            this.categories.Text = "Categories";
            this.categories.Click += new System.EventHandler(this.categories_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 834);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.products);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Label close;
		private Label Heading;
		private Label title;
		private Panel panel2;
		private Label users;
		private Label customers;
		private Label products;
		private Label orders;
		private Label categories;
	}
}