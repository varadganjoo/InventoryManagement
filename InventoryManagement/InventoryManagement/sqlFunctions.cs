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
using System.Text.RegularExpressions;

namespace InventoryManagement
{
    public class sqlFunctions
    {
        //establish a connection with the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\varad\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        
        public void add(DataGridView gridView, String[] values, string table)
        { // create sql statements to add values and execute them
            string myQuery = "insert into " + table + " values(";
            for (int i = 0; i < values.Length; i++)
            {
                if (Regex.IsMatch(values[i], @"^\d+$")) {
                    myQuery += values[i];
                } 
                else
                {
                    myQuery += "'" + values[i] + "'";
                }

                if(i == values.Length - 1)
                {
                    myQuery += ")";
                } 
                else
                {
                    myQuery += ", ";
                }
            }
            this.ExecuteSql(myQuery);
            populate(gridView, table);
        }

        public void edit(DataGridView gridView, String[] values, String[] columns, string table)
        { // create sql statements to edit values and execute them

            string myQuery = "update " + table + " set ";
            string firstVal = "";
            string firstCol = "";

            for(int i = 0; i < values.Length;i++)
            {
                if(i == 0)
                {
                    firstCol = columns[0];
                    firstVal = values[0];
                } 
                else
                {
                    if (Regex.IsMatch(values[i], @"^\d+$"))
                    {
                        myQuery += columns[i] + "=" + values[i];
                    }
                    else
                    {
                        myQuery += columns[i] + "='" + values[i] + "'";
                    }

                    if (i != values.Length - 1)
                    {
                        myQuery += ", ";
                    }
                }
            }

            myQuery += " where " + firstCol + "=" + firstVal;
            this.ExecuteSql(myQuery);
            populate(gridView, table);
        }

        public void fillcategory(ComboBox ProductCategory)
        { // fill a category dropdown box in ManageProducts.cs
            {
                string query = "select * from CategoryTable";
                SqlCommand cmd = new SqlCommand(query, this.con);
                SqlDataReader reader;
                try
                {
                    this.con.Open();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("CatName", typeof(string));
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    ProductCategory.ValueMember = "CatName";
                    ProductCategory.DataSource = dt;
                    this.con.Close();
                }
                catch { }
            }
        }

        public void delete(DataGridView gridView,string userId, string column, string table)
        { //delete values from a table
            if (userId == "")
            {
                MessageBox.Show("Enter The ID");
            }
            else
            {
                string myQuery = "delete from " + table + " where " + column + " = " + userId + "";
                this.ExecuteSql(myQuery);
            }
            populate(gridView, table);
        }

        void ExecuteSql(string query)
        { //execute sql queries
            try
            {
                this.con.Open();
                SqlCommand cmd = new SqlCommand(query, this.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Executed Successfully");
                this.con.Close();
            }
            catch
            {
                MessageBox.Show("Could not add");
            }
        }

        public void populate(DataGridView gridView, string table)
        { //show the values of the table on a grid view
            this.con.Open();
            string myQuery = "select * from " + table;
            SqlDataAdapter adapter = new SqlDataAdapter(myQuery, this.con);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gridView.DataSource = dataSet.Tables[0];
            this.con.Close();
        }

        public string conditionSelection(string table, string selectColumn, string idColumn, string value)
        { //select elements in a table based on a condition
            try
            {
                string query = "select " + selectColumn + " from " + table + " where " + idColumn + " = '" + value + "'";
                this.con.Open();
                SqlCommand cmd = new SqlCommand(query, this.con);
                return cmd.ExecuteScalar().ToString();
            }
            catch
            {
                MessageBox.Show("Cannot Execute");
                return "0";
            }
        }

        public bool login(string username, string password)
        { // login to the application
            string query = "select COUNT(UserId) from UserTable where Username='" + username + "' and password='" + password +"'";
            this.con.Open();
            SqlCommand cmd = new SqlCommand(query, this.con);
            if (cmd.ExecuteScalar().ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
