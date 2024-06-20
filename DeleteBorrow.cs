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
    public partial class DeleteBorrow : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;
        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (gridBorrowDel.SelectedRows.Count >= 1)
            {
                DialogResult delConfirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (delConfirm == DialogResult.OK)
                {
                    string selected_id = gridBorrowDel.CurrentRow.Cells["Borrow_ID"].Value.ToString();
                    con.Open();
                    string del = "DELETE FROM borrowed_books_lib WHERE Borrow_ID = '" + selected_id + "';";
                    command = new MySqlCommand(del, con);
                    mdr = command.ExecuteReader();
                    con.Close();
                    con.Open();
                    string del2 = "DELETE FROM borrowed_books WHERE Borrow_ID = '" + selected_id + "';";
                    command = new MySqlCommand(del2, con);
                    mdr = command.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Deleted Successfully!");

                    returnonly();
                }
            }
            else
            {
                MessageBox.Show("Select a field to delete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void textDeleteSearch_TextChanged(object sender, EventArgs e)
        {
            string searchVal = textDeleteSearch.Text.ToString();
            searchData(searchVal);
        }

        private void DeleteBorrow_Load(object sender, EventArgs e)
        {
            con.Open();
            searchData("");
            string select = "Select * From borrowed_books_lib";
            command = new MySqlCommand(select, con);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = command;
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            gridBorrowDel.DataSource = dt;
            con.Close();

            returnonly();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public DeleteBorrow()
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

        public void returnonly()
        {
            con.Open();
            string select = "SELECT Borrow_ID, Book_ID, Released, Expected_Return, Status, Borrower FROM borrowed_books_lib WHERE Status='Returned';";
            command = new MySqlCommand(select, con);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = command;
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            gridBorrowDel.DataSource = dt;

            con.Close();
        }

        public void searchData(string searchVal)
        {
            string search = "SELECT * FROM borrowed_books_lib WHERE CONCAT(Borrow_ID, Book_ID, Released, Expected_Return, Status, Borrower) LIKE '%" + searchVal + "%';";
            command = new MySqlCommand(search, con);
            adapt = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            gridBorrowDel.DataSource = dt;
        }
    }
}
