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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        sqlFunctions sqlFunctions = new sqlFunctions();

        private void label3_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //add button
        {
            string[] values;
            values = new string[] { CustomerId.Text, CustomerName.Text, CustomerName.Text, CustomerContact.Text };
            sqlFunctions.add(CustomerShow, values, "CustomerTable");
        }

        private void button3_Click(object sender, EventArgs e) //delete button
        {
            sqlFunctions.delete(CustomerShow, CustomerId.Text, "CustId", "CustomerTable");
        }


        private void ManageCustomers_Load(object sender, EventArgs e) //load screen
        {
            sqlFunctions.populate(CustomerShow, "CustomerTable");
        }

        private void CustomerShow_CellContentClick(object sender, DataGridViewCellEventArgs e) //click on cell
        {
            if(CustomerShow.SelectedRows.Count != 0) 
            { 
                CustomerId.Text = CustomerShow.SelectedRows[0].Cells[0].Value.ToString();
                CustomerName.Text = CustomerShow.SelectedRows[0].Cells[1].Value.ToString();
                CustomerContact.Text = CustomerShow.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) //edit button
        {
            string[] values, columns;
            values = new string[] { CustomerId.Text, CustomerName.Text, CustomerContact.Text };
            columns = new string[] { "CustId", "CustName", "custPhone"};
            sqlFunctions.edit(CustomerShow, values, columns, "CustomerTable");
            sqlFunctions.populate(CustomerShow, "CustomerTable");
        }

		private void button4_Click(object sender, EventArgs e) //home button
		{
            Home home = new Home();
            home.Show();
            this.Hide();
        }
	}
}