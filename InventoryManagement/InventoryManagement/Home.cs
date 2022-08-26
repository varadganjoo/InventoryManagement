using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void users_Click(object sender, EventArgs e) //users
		{
			ManageUsers users = new ManageUsers();
			users.Show();
			this.Hide();
		}

		private void customers_Click(object sender, EventArgs e) //customers
		{
			ManageCustomers cx = new ManageCustomers();
			cx.Show();
			this.Hide();
		}

		private void products_Click(object sender, EventArgs e) //products
		{
			ManageProducts products = new ManageProducts();
			products.Show();
			this.Hide();
		}

		private void categories_Click(object sender, EventArgs e) //categories
		{
			ManageCategories cat = new ManageCategories();
			cat.Show();
			this.Hide();
		}

		private void orders_Click(object sender, EventArgs e) //orders
		{
			ManageOrders orders = new ManageOrders();
			orders.Show();
			this.Hide();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
    }
}
