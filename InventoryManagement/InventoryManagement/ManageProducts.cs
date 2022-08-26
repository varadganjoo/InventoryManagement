using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InventoryManagement
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        sqlFunctions sqlFunctions = new sqlFunctions();

        private void label3_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e) //load screen
        {
            sqlFunctions.fillcategory(ProductCategory);
            sqlFunctions.populate(ProductShow, "ProductTable");
        }

        private void button1_Click(object sender, EventArgs e) // add button
        {
            string[] values;
            values = new string[] { ProductId.Text, ProductName.Text, ProductQty.Text.ToString(), ProductPrice.Text.ToString(), ProductDescription.Text, ProductCategory.SelectedValue.ToString() };
            
            sqlFunctions.add(ProductShow, values, "ProductTable");
        }

        private void ProductShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { //click on a cell in the product table
            ProductId.Text = ProductShow.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProductShow.SelectedRows[0].Cells[1].Value.ToString();
            ProductQty.Text = ProductShow.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = ProductShow.SelectedRows[0].Cells[3].Value.ToString();
            ProductDescription.Text = ProductShow.SelectedRows[0].Cells[4].Value.ToString();
            ProductCategory.SelectedValue = ProductShow.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { //edit button
            string[] values, columns;
            values = new string[] { ProductId.Text, ProductName.Text, ProductQty.Text.ToString(), ProductPrice.Text.ToString(), ProductDescription.Text, ProductCategory.SelectedValue.ToString() };
            columns = new string[] { "ProductId", "ProductName", "ProductQuantity", "ProductPrice", "ProductDesc", "ProductCategory"};
            sqlFunctions.edit(ProductShow, values, columns, "ProductTable");
        }

        private void button3_Click(object sender, EventArgs e)
        { //delete button
            sqlFunctions.delete(ProductShow, ProductId.Text, "ProductId", "ProductTable");
        }

		private void button4_Click(object sender, EventArgs e)
		{ //home button
            Home home = new Home();
            home.Show();
            this.Hide();
        }
	}
}