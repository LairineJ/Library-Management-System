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
    public partial class CreateBorrow : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBorrowID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow number input in txtBorrowID
            Text_Box txtOnlyNum = new Text_Box();
            if (!txtOnlyNum.TextBoxNum(e))
            {
                MessageBox.Show("Number Inputs Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtBookID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Allow number input in txtBookID
            Text_Box txtOnlyNum = new Text_Box();
            if (!txtOnlyNum.TextBoxNum(e))
            {
                MessageBox.Show("Number Inputs Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CreateBorrow_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
        }

        public CreateBorrow()
        {
            server = "SG-CDE-5383-mysql-master.servers.mongodirector.com";
            database = "library_management";
            user = "Julia";
            password = "Julialairine22*";

            string conString;
            conString = $"SERVER={server}; PORT=3306; DATABASE={database};user={user};PASSWORD={password};";

            con = new MySqlConnection(conString);

            string Name = MainUserLogin.name;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create Button
            DialogResult createConfirm = MessageBox.Show("Are you sure you want to create this record?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (createConfirm == DialogResult.OK)
            {
                //Check if there's any blank fields.
                while (txtBorrowID.Text == "" || txtBookID.Text == "" || txtBookID.Text == "" || dateTimeRelease.Value == null || txtBorrower.Text == "" || dateTimeReturn.Value == null)
                {
                    con.Open();
                    MessageBox.Show("Incomplete Details!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    return;
                }

                while (txtBorrowID.Text != "" || txtBookID.Text != "" || txtBookID.Text != "" || dateTimeRelease.Value != null || txtBorrower.Text != "" || dateTimeReturn.Value != null)
                {
                    //Penalty is set to NONE in default
                    string Penalty = "None";
                    string Availability = "Unavailable";
                    string Availability2 = "Available";
                    int BorrowID = int.Parse(txtBorrowID.Text);
                    double BookID = double.Parse(txtBookID.Text);
                    string Borrower = txtBorrower.Text;
                    string bookRelease = dateTimeRelease.Value.ToString("yyyy-MM-dd H:mm:ss");
                    string bookReturn = dateTimeReturn.Value.ToString("yyyy-MM-dd H:mm:ss");
                    string status = cmbStatus.SelectedItem.ToString();

                    //Check if the Borrow_ID exists in the borrowed_books_lib
                    con.Open();
                    string checkBorrowID = "SELECT COUNT(*) FROM borrowed_books_lib WHERE Borrow_ID = '" + BorrowID + "';";
                    command = new MySqlCommand(checkBorrowID, con);
                    object borrowIDExist = command.ExecuteScalar();
                    con.Close();

                    if (Convert.ToInt32(borrowIDExist) == 0)
                    {
                        //con.Close();

                        //Check if the Book_ID exists in the book_inventory table.
                        con.Open();
                        string checkBookID = "SELECT COUNT(*) FROM book_inventory WHERE Book_ID = '" + BookID + "';";
                        command = new MySqlCommand(checkBookID, con);
                        object idExists = command.ExecuteScalar();
                        con.Close();
                        if (Convert.ToInt32(idExists) > 0)
                        {
                            //con.Close();

                            //Check if the book is available in the book_inventory
                            con.Open();
                            string checkAvail = "SELECT Status FROM book_inventory WHERE Book_ID = '" + BookID + "';";
                            command = new MySqlCommand(checkAvail, con);
                            object isAvail = command.ExecuteScalar();
                            con.Close();
                            if (isAvail.ToString() == "Available")
                            {
                                //con.Close();

                                //Select for the Book Title
                                con.Open();
                                string checkTitle = "SELECT Title FROM book_inventory WHERE Book_ID = '" + BookID + "';";
                                MySqlCommand command1 = new MySqlCommand(checkTitle, con);
                                object bookTitle = command1.ExecuteScalar();

                                //Select for the Book Author
                                string checkAuthor = "SELECT Author FROM book_inventory WHERE Book_ID = '" + BookID + "';";
                                MySqlCommand command3 = new MySqlCommand(checkAuthor, con);
                                object bookAuthor = command3.ExecuteScalar();

                                //Select if the user is valid
                                string checkStud = "SELECT COUNT(*) FROM student_accounts WHERE Name = '" + Borrower + "';";
                                string checkFac = "SELECT COUNT(*) FROM faculty_accounts WHERE Name = '" + Borrower + "';";
                                command = new MySqlCommand(checkStud, con);
                                MySqlCommand command2 = new MySqlCommand(checkFac, con);
                                object studExist = command.ExecuteScalar();
                                object facExist = command2.ExecuteScalar();
                                con.Close();

                                if (Convert.ToInt32(studExist) > 0)
                                {
                                    //con.Close();
                                    //Select which student is borrowing
                                    con.Open();
                                    string checkUser = "SELECT Student_ID FROM student_accounts WHERE Name = '" + Borrower + "';";
                                    MySqlCommand command4 = new MySqlCommand(checkUser, con);
                                    object studBorrower = command4.ExecuteScalar();
                                    con.Close();

                                    //Check if a student has reached the maximum number of issued books
                                    con.Open();
                                    string selectIssued = "SELECT COUNT(*) FROM borrowed_books WHERE Borrow_ID IN (SELECT Borrow_ID FROM borrowed_books_lib WHERE Borrower='" + Borrower + "');";
                                    command = new MySqlCommand(selectIssued, con);
                                    object issuedBooks = command.ExecuteScalar();
                                    con.Close();

                                    if (Convert.ToInt32(issuedBooks) <= 4)
                                    {
                                        con.Open();
                                        //Inserting records within the borrowed_books_lib table (STUDENT)
                                        string insert1 = "INSERT INTO borrowed_books_lib VALUES ('" + BorrowID + "','" + BookID + "','" + bookRelease + "','" + bookReturn + "','" + status + "','" + Borrower + "'); ";
                                        MySqlCommand command5 = new MySqlCommand(insert1, con);
                                        mdr = command5.ExecuteReader();
                                        con.Close();

                                        con.Open();
                                        //Inserting records within the borrowed_books table (STUDENT)
                                        string insert2 = "INSERT INTO borrowed_books (Borrow_ID, bkTitle, bkAuthor, Date_Borrowed, Date_of_Return, Penalty) VALUES ('" + BorrowID + "','" + bookTitle + "','" + bookAuthor + "','" + bookRelease + "','" + bookReturn + "','" + Penalty + "');";
                                        MySqlCommand command6 = new MySqlCommand(insert2, con);
                                        mdr = command6.ExecuteReader();
                                        con.Close();

                                        if (cmbStatus.SelectedItem.ToString() != "Returned")
                                        {
                                            con.Open();
                                            //Updating availability of a book in the book_inventory table
                                            string changeAvail = "UPDATE book_inventory SET Status = '" + Availability + "' WHERE Book_ID = '" + BookID + "';";
                                            MySqlCommand command7 = new MySqlCommand(changeAvail, con);
                                            mdr = command7.ExecuteReader();

                                            MessageBox.Show("Borrowed Successfully!");
                                            Clear();
                                            con.Close();
                                            return;
                                        }
                                        else
                                        {
                                            con.Open();
                                            string changeAvail2 = "UPDATE book_inventory SET Status = '" + Availability2 + "' WHERE Book_ID = '" + BookID + "';";
                                            MySqlCommand command8 = new MySqlCommand(changeAvail2, con);
                                            mdr = command8.ExecuteReader();
                                            MessageBox.Show("Created Successfully!");
                                            Clear();
                                            con.Close();
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        con.Open();
                                        MessageBox.Show("This user have reached the maximum number of issued books.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        con.Close();
                                        return;
                                    }
                                }
                                else if (Convert.ToInt32(facExist) > 0)
                                {
                                    //con.Close();
                                    //Select which faculty is borrowing
                                    con.Open();
                                    string checkUser = "SELECT Faculty_ID FROM faculty_accounts WHERE Name = '" + Borrower + "';";
                                    command = new MySqlCommand(checkUser, con);
                                    object facBorrower = command.ExecuteScalar();
                                    con.Close();

                                    con.Open();
                                    //Inserting records within the borrowed_books_lib table (FACULTY)
                                    string insert1 = "INSERT INTO borrowed_books_lib VALUES ('" + BorrowID + "','" + BookID + "','" + bookRelease + "','" + bookReturn + "','" + status + "','" + Borrower + "'); ";
                                    MySqlCommand command5 = new MySqlCommand(insert1, con);
                                    mdr = command5.ExecuteReader();
                                    con.Close();

                                    con.Open();
                                    //Inserting records within the borrowed_books table (FACULTY)
                                    string insert2 = "INSERT INTO borrowed_books (Borrow_ID, bkTitle, bkAuthor, Date_Borrowed, Date_of_Return, Penalty) VALUES ('" + BorrowID + "','" + bookTitle + "','" + bookAuthor + "','" + bookRelease + "','" + bookReturn + "','" + Penalty + "');";
                                    MySqlCommand command6 = new MySqlCommand(insert2, con);
                                    mdr = command6.ExecuteReader();
                                    con.Close();

                                    if (cmbStatus.SelectedItem.ToString() != "Returned")
                                    {
                                        con.Open();
                                        //Updating availability of a book in the book_inventory table
                                        string changeAvail = "UPDATE book_inventory SET Status = '" + Availability + "' WHERE Book_ID = '" + BookID + "';";
                                        MySqlCommand command7 = new MySqlCommand(changeAvail, con);
                                        mdr = command7.ExecuteReader();

                                        MessageBox.Show("Borrowed Successfully!");
                                        Clear();
                                        con.Close();
                                        return;
                                    }
                                    else
                                    {
                                        con.Open();
                                        string changeAvail2 = "UPDATE book_inventory SET Status = '" + Availability2 + "' WHERE Book_ID = '" + BookID + "';";
                                        MySqlCommand command8 = new MySqlCommand(changeAvail2, con);
                                        mdr = command8.ExecuteReader();
                                        MessageBox.Show("Created Successfully!");
                                        Clear();
                                        con.Close();
                                        return;
                                    }
                                }
                                else
                                {
                                    con.Open();
                                    MessageBox.Show("User is not registered!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    con.Close();
                                    return;
                                }
                            }
                            else
                            {
                                con.Open();
                                MessageBox.Show("The Book is Unavailable!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                con.Close();
                                return;
                            }
                        }
                        else
                        {
                            con.Open();
                            MessageBox.Show("Book ID is unavailable!", "ID Taken", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            con.Close();
                            return;
                        }
                    }
                    else
                    {
                        con.Open();
                        MessageBox.Show("Borrow ID is unavailable!", "ID Taken", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        con.Close();
                        return;
                    }
                }
            }
        }
        public void Clear()
        {
            txtBorrower.Text = "";
            txtBorrowID.Text = "";
            txtBookID.Text = "";
            dateTimeRelease.Value = DateTime.Now;
            dateTimeRelease.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0;
        }
    }
}
