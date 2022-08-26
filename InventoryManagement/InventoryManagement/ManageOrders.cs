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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        sqlFunctions sqlFunctions = new sqlFunctions();

        private void ManageOrders_Load(object sender, EventArgs e) // load screen
        {
            sqlFunctions.populate(ProductShow, "ProductTable");
            sqlFunctions.populate(CustomerShow, "CustomerTable");
            sqlFunctions.populate(OrderShow, "ordersTable");
            int quantity, totalPrice;
            if (OrderQty.Text != "" && ProductPrice.Text != "")
            {
                quantity = Convert.ToInt32(OrderQty.Text);
                totalPrice = quantity * Convert.ToInt32(ProductPrice.Text);
            }
            else
            {
                totalPrice = 0;
            }
            priceDisplay.Text = "Total: $" + totalPrice.ToString();
        }

        private void label3_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }

        private void ProductShow_CellContentClick(object sender, DataGridViewCellEventArgs e) //click on a cell in the product table
        {
            ProductId.Text = ProductShow.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProductShow.SelectedRows[0].Cells[1].Value.ToString();
            ProductPrice.Text = ProductShow.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void CustomerShow_CellContentClick(object sender, DataGridViewCellEventArgs e) //click on a cell in the customer table
        {
            CustomerId.Text = CustomerShow.SelectedRows[0].Cells[0].Value.ToString();
            CustomerName.Text = CustomerShow.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void OrderShow_CellContentClick(object sender, DataGridViewCellEventArgs e) //click on a cell in the orders table
        {
            OrderId.Text = OrderShow.SelectedRows[0].Cells[0].Value.ToString();
            ProductId.Text = OrderShow.SelectedRows[0].Cells[1].Value.ToString();
            ProductName.Text = OrderShow.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = OrderShow.SelectedRows[0].Cells[3].Value.ToString();
            OrderQty.Text = OrderShow.SelectedRows[0].Cells[4].Value.ToString();
            CustomerId.Text = OrderShow.SelectedRows[0].Cells[5].Value.ToString();
            CustomerName.Text = OrderShow.SelectedRows[0].Cells[6].Value.ToString();
            priceDisplay.Text = "Total: $" + OrderShow.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //add button
        { // subtract product quantity from inventory
            int quantity = Convert.ToInt32(OrderQty.Text), totalQuantity, remainingQuantity, totalPrice = quantity * Convert.ToInt32(ProductPrice.Text);
            priceDisplay.Text = "Total: $" + totalPrice.ToString();
            string[] values, productValues, productColumns;
            string desc = sqlFunctions.conditionSelection("ProductTable", "ProductDesc", "ProductId", ProductId.Text), 
                cat = sqlFunctions.conditionSelection("ProductTable", "ProductCategory", "ProductId", ProductId.Text);
            values = new string[] { OrderId.Text, ProductId.Text, ProductName.Text, ProductPrice.Text, OrderQty.Text, CustomerId.Text, CustomerName.Text, totalPrice.ToString() };
            productColumns = new string[] { "ProductId", "ProductName", "ProductQuantity", "ProductPrice", "ProductDesc", "ProductCategory" };
            totalQuantity = Convert.ToInt32(sqlFunctions.conditionSelection("ProductTable", "ProductQuantity", "ProductId", ProductId.Text));

            if (totalQuantity >= quantity)
            {
                sqlFunctions.add(OrderShow, values, "ordersTable");
                remainingQuantity = totalQuantity - quantity;
                productValues = new string[] { ProductId.Text, ProductName.Text, remainingQuantity.ToString(), ProductPrice.Text.ToString(), desc, cat };
                sqlFunctions.edit(ProductShow, productValues, productColumns, "ProductTable");
            }
            else
            {
                MessageBox.Show("Not enough products");
            }
        }

        private void button3_Click(object sender, EventArgs e) //delete button
        { // add product quantity back to inventory
            int quantity = Convert.ToInt32(sqlFunctions.conditionSelection("ordersTable", "OrderQty", "OrderId", OrderId.Text)), 
                productQuantity = Convert.ToInt32(sqlFunctions.conditionSelection("ProductTable", "ProductQuantity", "ProductId", ProductId.Text)),
                totalQuantity = quantity + productQuantity;
            sqlFunctions.delete(OrderShow, OrderId.Text, "OrderId", "ordersTable");
            string[] productValues, productColumns;
            string desc = sqlFunctions.conditionSelection("ProductTable", "ProductDesc", "ProductId", ProductId.Text),
                cat = sqlFunctions.conditionSelection("ProductTable", "ProductCategory", "ProductId", ProductId.Text);
            productColumns = new string[] { "ProductId", "ProductName", "ProductQuantity", "ProductPrice", "ProductDesc", "ProductCategory" };
            productValues = new string[] { ProductId.Text, ProductName.Text, totalQuantity.ToString(), ProductPrice.Text.ToString(), desc, cat };
            sqlFunctions.edit(ProductShow, productValues, productColumns, "ProductTable");
        }

		private void clear_Click(object sender, EventArgs e) //clear button
		{
            OrderId.Text = ProductId.Text = ProductName.Text = ProductPrice.Text =
                OrderQty.Text =
                CustomerId.Text =
                CustomerName.Text = "";
            priceDisplay.Text = "Total: $0";
        }

		private void OrderQty_TextChanged(object sender, EventArgs e) //when OrderQty text value is changed
		{
            int quantity, totalPrice;
            if (OrderQty.Text != "" && ProductPrice.Text != "")
            {
                quantity = Convert.ToInt32(OrderQty.Text);
              totalPrice = quantity * Convert.ToInt32(ProductPrice.Text);
                priceDisplay.Text = "Total: $" + totalPrice;
            }
            else
            {
                priceDisplay.Text = "Total: $0";
            }
        }

		private void button4_Click(object sender, EventArgs e) //home button
		{
            Home home = new Home();
            home.Show();
            this.Hide();
        }
	}
}