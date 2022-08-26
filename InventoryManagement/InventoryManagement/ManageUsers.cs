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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
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
            values = new string[] { userId.Text.ToString(), userName.Text, fullName.Text, password.Text, contact.Text };
            sqlFunctions.add(UsersShow, values, "UserTable");
        }

        private void ManageUsers_Load(object sender, EventArgs e) //load screen
        {
            sqlFunctions.populate(UsersShow, "UserTable");
        }

        private void button3_Click(object sender, EventArgs e) // delete button
        {
            sqlFunctions.delete(UsersShow, userId.Text, "UserId", "userTable");
        }

        private void UsersShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // click on elements in the table
            userId.Text = UsersShow.SelectedRows[0].Cells[0].Value.ToString();
            userName.Text = UsersShow.SelectedRows[0].Cells[1].Value.ToString();
            fullName.Text = UsersShow.SelectedRows[0].Cells[2].Value.ToString();
            password.Text = UsersShow.SelectedRows[0].Cells[3].Value.ToString();
            contact.Text = UsersShow.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { //edit table
            string[] values, columns;
            values = new string[] { userId.Text, userName.Text, fullName.Text, password.Text, contact.Text };
            columns = new string[] { "UserId", "Username", "fullName", "password", "contact" };
            sqlFunctions.edit(UsersShow,values, columns, "UserTable");
        }

        private void button4_Click(object sender, EventArgs e) //home button
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
}
