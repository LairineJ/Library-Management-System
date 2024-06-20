using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace FinalProject_Group11
{
    public partial class UserForm : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        public UserForm()
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

        public void showBookInv() 
        {
            //Book Inventory
            con.Open();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter("Select * FROM book_inventory ", con);
            DataTable DTBL = new DataTable();
            sqlDA.Fill(DTBL);

            dataGridBookInv.DataSource = DTBL;
            con.Close();
            label10.Text = dataGridBookInv.Rows.Count.ToString();
        }

        public void showBorrowed()
        {
            string User = MainUserLogin.name;

            //Book Borrowed
            con.Open();
            //Selecting which user's borrowed_books will be displayed
            MySqlDataAdapter sqlDA1 = new MySqlDataAdapter ("SELECT * FROM borrowed_books WHERE Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='"+User+"');", con);
            
            DataTable DTBL2 = new DataTable();
            sqlDA1.Fill(DTBL2);

            dataGridViewBorrowed.DataSource = DTBL2;
            con.Close();
            label9.Text = dataGridViewBorrowed.Rows.Count.ToString();
        }
              
        private void UserForm_Load(object sender, EventArgs e)
        {
            lblName.Text = MainUserLogin.username;
            lblPosition.Text = MainUserLogin.AccType;
            txtName.Text = MainUserLogin.name;
            txtID.Text = MainUserLogin.ID;
            txtDept.Text = MainUserLogin.Dept;
            txtAccType.Text = MainUserLogin.AccType;
            lblUsername.Text = MainUserLogin.User;

            if (txtAccType.Text == "Student - User")
            {
                textEditUser.Text = MainUserLogin.username;
                textEditPass.Text = MainUserLogin.SPass;
                textConfirmPass.Text = "";
            }
            if(txtAccType.Text == "Faculty - User")
            {
                textEditUser.Text = MainUserLogin.username;
                textEditPass.Text = MainUserLogin.FPass;
                textConfirmPass.Text = "";
            }

            textEditPass.UseSystemPasswordChar = true;
            textConfirmPass.UseSystemPasswordChar = true;


            panelBorrowed.Visible = false;
            panelSearch.Visible = false;
            panelProfile.Visible = false;
            


            showBookInv();
            showBorrowed();

            string User = MainUserLogin.name;

            //Check if the user has penalty (missing), and if so, suspend the account for 14 days.
            con.Open();
            string ifMissing = "SELECT COUNT(*) FROM borrowed_books WHERE Penalty='Missing' AND Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
            command = new MySqlCommand(ifMissing, con);
            object missing = command.ExecuteScalar();

            if (Convert.ToInt32(missing) != 0)
            {
                DialogResult logout = MessageBox.Show("Temporary Suspension: Lost an issued book. Please proceed to the librarian's office for assistance.", "Suspension Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (logout == DialogResult.OK)
                {
                    MainUserLogin back = new MainUserLogin();
                    back.Show();
                    this.Close();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBorrowed.Visible = false;
            panelSearch.Visible = false;
            panelProfile.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string User = MainUserLogin.name;

            //Check for the number of borrowed books
            con.Open();
            string checkBooks = "SELECT COUNT(*) FROM borrowed_books WHERE Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
            command = new MySqlCommand(checkBooks, con);
            object totalBooks = command.ExecuteScalar();
            if (Convert.ToInt32(totalBooks) <= 5)
            {
                panelBorrowed.Visible = true;
                panelSearch.Visible = false;
                
                con.Close();
            }
            else
            {
                MessageBox.Show("Important Notice: You have reached the maximum number of issued books.", "Issue Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelBorrowed.Visible = true;
                panelSearch.Visible = false;
               
                con.Close();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string User = MainUserLogin.name;
            //Check for the number of books
            con.Open();
            string checkBooks = "SELECT COUNT(*) FROM borrowed_books WHERE Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
            command = new MySqlCommand(checkBooks, con);
            object totalBooks = command.ExecuteScalar();
            if (Convert.ToInt32(totalBooks) < 5)
            {
                con.Close();

                con.Open();
                string selectPenalty = "SELECT COUNT(*) FROM borrowed_books WHERE Penalty='Penalty #101' AND Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
                command = new MySqlCommand(selectPenalty, con);
                object penalty = command.ExecuteScalar();

                if (Convert.ToInt32(penalty) < 3)
                {
                    panelBorrowed.Visible = false;
                    panelSearch.Visible = true;
                    
                    con.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Temporary Suspension: Please proceed to the library and settle your overdue charges/obligations.", "Penalty Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Borrow Restriction: You have reached the maximum number of issued books.", "Issue Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelBorrowed.Visible = false;
            panelSearch.Visible = false;
           
            panelProfile.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult confirmLogout = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if(confirmLogout == DialogResult.OK)
            {
                Form1 logout = new Form1();
                logout.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            panelBorrowed.Visible = false;
            panelSearch.Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Book Inventory Search
            string searchBar = textBox1.Text.ToString();
            searchBook(searchBar);
        }

        public void searchBook(string searchBar)
        { 
            string search = "SELECT * FROM book_inventory WHERE CONCAT(Book_ID, Title, Author, Genre, Publisher, Year_Published, Status) LIKE '%" + searchBar + "%';";
            command = new MySqlCommand(search, con);
            adapt = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridBookInv.DataSource = dt;
        }

        public void searchBorrowed(string search)
        {
            string search2 = "SELECT * FROM borrowed_books WHERE CONCAT(Borrower_ID, bkTitle, bkAuthor, Date_Borrowed, Date_of_Return, Penalty) LIKE '%" + search + "%';";
            command = new MySqlCommand(search2, con);
            adapt = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewBorrowed.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Borrowed Books Search
            string search = textBox2.Text.ToString();
            searchBorrowed(search);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lblPosition.Text == "Student - User")
            {
                //Check if username is 5-12 characters long.
                if (textEditUser.Text.Length >= 5 && textEditUser.Text.Length <= 12)
                {

                    //Check if the username is already taken within the student_accounts table.
                    con.Open();
                    string selectUser = "SELECT COUNT(*) FROM student_accounts WHERE Username = '" + textEditUser.Text + "';";
                    command = new MySqlCommand(selectUser, con);
                    object userTaken = command.ExecuteScalar();

                    if (Convert.ToInt32(userTaken) == 0)
                    {
                        con.Close();

                        //Check if password is 6 - 16 characters long.
                        if (textEditPass.Text.Length >= 6 && textEditPass.Text.Length <= 16)
                        {
                            //Check for password and confirm password.
                            if (textEditPass.Text == textConfirmPass.Text)
                            {
                                string message = "Are you sure you want to change username/password?";
                                string title = "Confirm Action";
                                MessageBoxButtons button = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //Updating records within the student_accounts table.
                                    con.Open();
                                    string insert = "Update student_accounts SET username = '" + textEditUser.Text + "', password = '" + textConfirmPass.Text + "' WHERE student_ID = '" + txtID.Text + "';";
                                    command = new MySqlCommand(insert, con);
                                    mdr = command.ExecuteReader();
                                    MessageBox.Show("Sucessfully Changed!");
                                    con.Close();
                                    return;
                                }                                                               
                            }
                            else
                            {
                                MessageBox.Show("Password Does Not Match!");
                                con.Close();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be atleast 6-16 characters!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            con.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username is Already Taken!");
                        con.Close();
                        return;
                    }
                }
            }
            if (lblPosition.Text == "Faculty - User")
            {
                //Check if username is 5-12 characters long.
                if (textEditUser.Text.Length >= 5 && textEditUser.Text.Length <= 12)
                {

                    //Check if the username is already taken within the student_accounts table.
                    con.Open();
                    string selectUser = "SELECT COUNT(*) FROM student_accounts WHERE Username = '" + textEditUser.Text + "';";
                    command = new MySqlCommand(selectUser, con);
                    object userTaken = command.ExecuteScalar();

                    if (Convert.ToInt32(userTaken) == 0)
                    {
                        con.Close();

                        //Check if password is 6 - 16 characters long.
                        if (textEditPass.Text.Length >= 6 && textEditPass.Text.Length <= 16)
                        {
                            //Check for password and confirm password.
                            if (textEditPass.Text == textConfirmPass.Text)
                            {
                                string message = "Are you sure you want to change username/password?";
                                string title = "Confirm Action";
                                MessageBoxButtons button = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //Updating records within the student_accounts table.
                                    con.Open();
                                    string insert = "Update faculty_accounts SET username = '" + textEditUser.Text + "', password = '" + textConfirmPass.Text + "' WHERE Faculty_ID = '" + txtID.Text + "';";
                                    command = new MySqlCommand(insert, con);
                                    mdr = command.ExecuteReader();
                                    MessageBox.Show("Sucessfully Changed!");
                                    con.Close();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password Does Not Match!");
                                con.Close();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be atleast 6-16 characters!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            con.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username is Already Taken!");
                        con.Close();
                        return;
                    }
                }
            }
        }
        
        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                textEditPass.UseSystemPasswordChar = false;
                textConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                textEditPass.UseSystemPasswordChar = true;
                textConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void textEditUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Username must only accept alphanumeric and 5-10 characters long.
            txtAlphaNumeric alphaNumericOnly = new txtAlphaNumeric();
            if (!alphaNumericOnly.alphaNumeric(e))
            {
                MessageBox.Show("Inputs can only be a number or letter!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        class txtAlphaNumeric
        {
            public bool alphaNumeric(KeyPressEventArgs e)
            {
                char ch = e.KeyChar;
                if (!char.IsNumber(ch) && !char.IsControl(ch) && !char.IsLetter(ch) && ch != '.')
                {
                    e.Handled = true;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string User = MainUserLogin.name;

            //Check for the number of borrowed books
            con.Open();
            string checkBooks = "SELECT COUNT(*) FROM borrowed_books WHERE Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
            command = new MySqlCommand(checkBooks, con);
            object totalBooks = command.ExecuteScalar();
            if (Convert.ToInt32(totalBooks) < 5)
            {
                panelBorrowed.Visible = true;
                panelSearch.Visible = false;
              
                con.Close();
            }
            else
            {
                MessageBox.Show("Important Notice: You have reached the maximum number of issued books.", "Issue Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelBorrowed.Visible = true;
                panelSearch.Visible = false;
                
                con.Close();
                return;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            string User = MainUserLogin.name;
            //Check for the number of books
            con.Open();
            string checkBooks = "SELECT COUNT(*) FROM borrowed_books WHERE Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
            command = new MySqlCommand(checkBooks, con);
            object totalBooks = command.ExecuteScalar();
            if (Convert.ToInt32(totalBooks) < 5)
            {
                con.Close();

                con.Open();
                string selectPenalty = "SELECT COUNT(*) FROM borrowed_books WHERE Penalty='Penalty #101' AND Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + User + "');";
                command = new MySqlCommand(selectPenalty, con);
                object penalty = command.ExecuteScalar();

                if (Convert.ToInt32(penalty) < 3)
                {
                    panelBorrowed.Visible = false;
                    panelSearch.Visible = true;
                    
                    con.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Temporary Suspension: Please proceed to the library and settle your overdue charges/obligations.", "Penalty Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Borrow Restriction: You have reached the maximum number of issued books.", "Issue Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            panelBorrowed.Visible = false;
            panelSearch.Visible = false;
            
        }
    }
}
