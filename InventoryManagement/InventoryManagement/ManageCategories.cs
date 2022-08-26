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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        sqlFunctions sqlFunctions = new sqlFunctions();

        private void button1_Click(object sender, EventArgs e) // add button
        {
            string[] values;
            values = new string[] { CatId.Text, CatName.Text };
            sqlFunctions.add(CategoriesShow, values, "CategoryTable");
        }

        private void button2_Click(object sender, EventArgs e) //edit button
        {
            string[] values, columns;
            values = new string[] { CatId.Text, CatName.Text };
            columns = new string[] { "CatId", "CatName" };
            sqlFunctions.edit(CategoriesShow, values, columns, "CategoryTable");
            sqlFunctions.populate(CategoriesShow, "CategoryTable");
        }

        private void button3_Click(object sender, EventArgs e) // delete button
        {
            sqlFunctions.delete(CategoriesShow, CatId.Text, "CatId", "CategoryTable");
        }

        private void ManageCategories_Load(object sender, EventArgs e) //load screen
        {
            sqlFunctions.populate(CategoriesShow, "CategoryTable");
        }

        private void CategoriesShow_CellContentClick(object sender, DataGridViewCellEventArgs e) // click on cell
        {
            CatId.Text = CategoriesShow.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = CategoriesShow.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }

		private void button4_Click(object sender, EventArgs e) // home button
		{
            Home home = new Home();
            home.Show();
            this.Hide();
        }
	}
}
