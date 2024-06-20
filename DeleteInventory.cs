using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProject_Group11
{
    public partial class DeleteInventory : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataReader mdr;

        private void textDeleteSearch_TextChanged(object sender, EventArgs e)
        {
            string searchVal = textDeleteSearch.Text.ToString();
            searchData(searchVal);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (gridInventoryDel.SelectedRows.Count >= 1)
            {
                DialogResult delConfirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (delConfirm == DialogResult.OK)
                {
                    con.Open();
                    string selected_id = gridInventoryDel.CurrentRow.Cells["Book_ID"].Value.ToString();
                    string del = "DELETE FROM book_inventory WHERE Book_ID = '" + selected_id + "';";
                    command = new MySqlCommand(del, con);
                    mdr = command.ExecuteReader();
                    MessageBox.Show("Deleted Successfully!");
                    con.Close();

                    con.Open();
                    string select = "SELECT Book_ID, Title, Author, Genre, Publisher, Year_Published, Status FROM book_inventory";
                    command = new MySqlCommand(select, con);
                    MySqlDataAdapter adapt = new MySqlDataAdapter();
                    adapt.SelectCommand = command;
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    gridInventoryDel.DataSource = dt;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Select a field to delete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }           
        }

        private void DeleteInventory_Load(object sender, EventArgs e)
        {
            con.Open();
            searchData("");
            string select = "Select * From book_inventory";
            command = new MySqlCommand(select, con);
            MySqlDataAdapter adapt1 = new MySqlDataAdapter();
            adapt1.SelectCommand = command;
            DataTable dt = new DataTable();
            adapt1.Fill(dt);
            gridInventoryDel.DataSource = dt;
            con.Close();
        }

        MySqlDataAdapter adapt;

        public DeleteInventory()
        {
            server = "SG-CDE-5383-mysql-master.servers.mongodirector.com";
            database = "library_management";
            user = "Julia";
            password = "Julialairine22*";

            string conString;
            conString = $"SERVER={server}; PORT=3306; DATABASE={database};user={user};PASSWORD={password};";

            con = new MySqlConnection(conString);
            InitializeComponent();
        }

        public void searchData(string searchVal)
        {
            string search = "SELECT * FROM book_inventory WHERE CONCAT(Book_ID, Title, Author, Genre, Publisher, Year_Published, Status) LIKE '%" + searchVal + "%';";
            command = new MySqlCommand(search, con);
            adapt = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            gridInventoryDel.DataSource = dt;
        }
    }


}
