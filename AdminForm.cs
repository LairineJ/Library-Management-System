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
    public partial class AdminForm : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        public static double bkID;
        public static string bkTitle, bkAuthor, bkPublisher, bkGenre, bkStatus;
        public static string borrowID, bkBorrowID, bkBorrower, borrowStatus, bkRelease, bkReturn;
        //public static DateTime bkRelease, bkReturn;
        public static DateTime bkYear;
        public AdminForm()
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


        private void buttonDash_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = false;
            panelBorrowed.Visible = false;

            //Display Records for Book Inventory
            con.Open();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter("Select * FROM book_inventory", con);
            DataTable DTBL = new DataTable();
            sqlDA.Fill(DTBL);

            dataGridInventory.DataSource = DTBL;
            con.Close();
            //Show total number of books in the inventory
            labelNumBooks.Text = dataGridInventory.Rows.Count.ToString();

            //Display Records for Borrowing Details
            con.Open();
            MySqlDataAdapter sqlDB = new MySqlDataAdapter("SELECT * FROM borrowed_books_lib", con);
            DataTable DBTB = new DataTable();
            sqlDB.Fill(DBTB);

            dataGridDetails.DataSource = DBTB;
            con.Close();
            //Show total numbers of books that are borrowed
            lblBorrowedBooks.Text = dataGridDetails.Rows.Count.ToString();

            //Show total numbers of user with penalty
            penalty();
            
        }

        private void labelDash_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = false;
            panelBorrowed.Visible = false;

            //Display Records for Book Inventory
            con.Open();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter("Select * FROM book_inventory", con);
            DataTable DTBL = new DataTable();
            sqlDA.Fill(DTBL);

            dataGridInventory.DataSource = DTBL;
            con.Close();
            //Show total number of books in the inventory
            labelNumBooks.Text = dataGridInventory.Rows.Count.ToString();

            //Display Records for Borrowing Details
            con.Open();
            MySqlDataAdapter sqlDB = new MySqlDataAdapter("SELECT * FROM borrowed_books_lib", con);
            DataTable DBTB = new DataTable();
            sqlDB.Fill(DBTB);

            dataGridDetails.DataSource = DBTB;
            con.Close();
            //Show total numbers of books that are borrowed
            lblBorrowedBooks.Text = dataGridDetails.Rows.Count.ToString();

            //Show total numbers of user with penalty
            penalty();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Are you sure you want to Logout?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 logout = new Form1();
                logout.Show();
                this.Hide();
            }

        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = true;
            panelBorrowed.Visible = false;

        }

        private void labelInventory_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = true;
            panelBorrowed.Visible = false;
        }

        public void searchBook(string searchBar)
        {
            string search = "SELECT * FROM book_inventory WHERE CONCAT(Book_ID, Title, Author, Genre, Publisher, Year_Published, Status) LIKE '%" + searchBar + "%';";
            command = new MySqlCommand(search, con);
            adapt = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridInventory.DataSource = dt;
        }

        private void textInvSearch_TextChanged(object sender, EventArgs e)
        {
            string searchBar = textInvSearch.Text.ToString();
            searchBook(searchBar);
        }
        public void searchDetails(string searchBar1)
        {
            string search = "SELECT * FROM borrowed_books_lib WHERE CONCAT(Borrow_ID, Book_ID, Released, Expected_Return, Status, Borrower) LIKE '%" + searchBar1 + "%';";
            command = new MySqlCommand(search, con);
            adapt = new MySqlDataAdapter(command);
            DataTable dt1 = new DataTable();
            adapt.Fill(dt1);
            dataGridDetails.DataSource = dt1;
        }

        private void textDetailSearch_TextChanged(object sender, EventArgs e)
        {
            string searchBar1 = textDetailSearch.Text.ToString();
            searchDetails(searchBar1);
        }

        private void BtnInventoryCreate_Click(object sender, EventArgs e)
        {
            string message = "Create a new record?";
            string title = "Create";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CreateInventory create = new CreateInventory();
                create.Show();
            }
        }

       

        private void BtnInventoryRead_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter("Select * FROM book_inventory", con);
            DataTable DTBL = new DataTable();
            sqlDA.Fill(DTBL);

            dataGridInventory.DataSource = DTBL;
            con.Close();
            labelNumBooks.Text = dataGridInventory.Rows.Count.ToString();
        }

        private void BtnInventoryUd_Click(object sender, EventArgs e)
        {
            string message = "Update selected record?";
            string title = "Update";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateInventory update = new UpdateInventory();

                bkID = double.Parse(dataGridInventory.CurrentRow.Cells[0].Value.ToString());
                bkTitle = dataGridInventory.CurrentRow.Cells[1].Value.ToString();
                bkAuthor = dataGridInventory.CurrentRow.Cells[2].Value.ToString();
                bkGenre = dataGridInventory.CurrentRow.Cells[3].Value.ToString();
                bkPublisher = dataGridInventory.CurrentRow.Cells[4].Value.ToString();
                bkYear = DateTime.ParseExact(dataGridInventory.CurrentRow.Cells[5].Value.ToString(), "yyyy", null);
                bkStatus = dataGridInventory.CurrentRow.Cells[6].Value.ToString();
                update.Show();
            }
        }

        private void BtnInventoryDel_Click(object sender, EventArgs e)
        {
            string message = "Delete a record?";
            string title = "Delete";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteInventory delete = new DeleteInventory();
                delete.Show();
            }
        }

        private void BtnBorrowUD_Click(object sender, EventArgs e)
        {
            string message = "Update selected record?";
            string title = "Update";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateBorrow borrow = new UpdateBorrow();

                borrowID = dataGridDetails.CurrentRow.Cells[0].Value.ToString();
                bkBorrowID = dataGridDetails.CurrentRow.Cells[1].Value.ToString();
                bkRelease = dataGridDetails.CurrentRow.Cells[2].Value.ToString();
                bkReturn = dataGridDetails.CurrentRow.Cells[3].Value.ToString();
                borrowStatus = dataGridDetails.CurrentRow.Cells[4].Value.ToString();
                bkBorrower = dataGridDetails.CurrentRow.Cells[5].Value.ToString();
                borrow.Show();
            }
        }

        private void BtnBorrowCreate_Click(object sender, EventArgs e)
        {
            string message = "Create a borrow record?";
            string title = "Create";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CreateBorrow Create = new CreateBorrow();
                Create.Show();
            }
        }


        private void BtnBorrowDel_Click(object sender, EventArgs e)
        {
            string message = "Delete a record?";
            string title = "Delete";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteBorrow delete = new DeleteBorrow();
                delete.Show();
            }
        }

        private void BtnBorrowRead_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlDB = new MySqlDataAdapter("SELECT * FROM borrowed_books_lib", con);
            DataTable DBTB = new DataTable();
            sqlDB.Fill(DBTB);

            dataGridDetails.DataSource = DBTB;
            con.Close();
            lblBorrowedBooks.Text = dataGridDetails.Rows.Count.ToString();
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = false;
            panelBorrowed.Visible = true;

        }

        private void labelDetails_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = false;
            panelBorrowed.Visible = true;
        }

        public void penalty ()
        {
            var penaltycount = dataGridDetails.Rows.Cast<DataGridViewRow>()
                     .Count(r => r.Cells[4].Value.ToString().Trim() == "Penalty").ToString();
            var missingcount = dataGridDetails.Rows.Cast<DataGridViewRow>()
                     .Count(r => r.Cells[4].Value.ToString().Trim() == "Missing").ToString();

            labeluserPenalty.Text = (int.Parse(penaltycount) + int.Parse(missingcount)).ToString(); 
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblName.Text = AdminLogin.User;
            panelInventory.Visible = false;
            panelBorrowed.Visible = false;

            //Display Records for Book Inventory
            con.Open();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter("Select * FROM book_inventory", con);
            DataTable DTBL = new DataTable();
            sqlDA.Fill(DTBL);

            dataGridInventory.DataSource = DTBL;
            con.Close();
            //Show total number of books in the inventory
            labelNumBooks.Text = dataGridInventory.Rows.Count.ToString();

            //Display Records for Borrowing Details
            con.Open();
            MySqlDataAdapter sqlDB = new MySqlDataAdapter("SELECT * FROM borrowed_books_lib", con);
            DataTable DBTB = new DataTable();
            sqlDB.Fill(DBTB);

            dataGridDetails.DataSource = DBTB;
            con.Close();
            //Show total numbers of books that are borrowed
            lblBorrowedBooks.Text = dataGridDetails.Rows.Count.ToString();

            //Show total number of Users with Penalty
            penalty();
        }
    }
}
