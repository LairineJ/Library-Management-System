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
    public partial class CreateInventory : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow number input in txtBookID

            Text_Box txtOnlyNum = new Text_Box();
            if (!txtOnlyNum.TextBoxNum(e))
            {
                MessageBox.Show("Number Inputs Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public CreateInventory()
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

        public void Clear()
        {
            txtBookID.Text = "";
            txtAuthor.Text = "";
            txtBookTitle.Text = "";
            cmbGenre.SelectedIndex = -1;
            txtPublisher.Text = "";
            cmbStatus.SelectedIndex = -1;
            dateTimeYear.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create Button
            
                //Check if there's any blank fields.
                while (txtBookID.Text == "" || txtBookTitle.Text == "" || dateTimeYear.Value == null || txtAuthor.Text == "" || txtPublisher.Text == "" || cmbGenre.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Incomplete Details!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    return;
                }
                while (txtBookID.Text != "" || txtBookTitle.Text != "" || dateTimeYear.Value == null || txtAuthor.Text != "" || txtPublisher.Text != "" || cmbGenre.SelectedIndex != -1 || cmbStatus.SelectedIndex != -1)
                {

                    double bookID = double.Parse(txtBookID.Text);
                    string bookTitle = txtBookTitle.Text;
                    string yearPublish = dateTimeYear.Value.ToString("yyyy");
                    string author = txtAuthor.Text;
                    string publisher = txtPublisher.Text;
                    string genre = cmbGenre.SelectedItem.ToString();
                    string status = cmbStatus.SelectedItem.ToString();

                    //Check if the Book_ID is already existing in the book_inventory table.
                    con.Open();
                    string checkID = "SELECT COUNT(*) FROM book_inventory WHERE Book_ID = '" + bookID + "';";
                    command = new MySqlCommand(checkID, con);
                    object idExists = command.ExecuteScalar();

                    if (Convert.ToInt32(idExists) == 0)
                    {
                        con.Close();

                        //Inserting records within the book_inventory table.
                        con.Open();
                        string insert = "INSERT INTO book_inventory VALUES ('" + bookID + "','" + bookTitle + "','" + author + "','" + genre + "','" + publisher + "','" + yearPublish + "','" + status + "'); ";
                        command = new MySqlCommand(insert, con);

                        DialogResult create = MessageBox.Show("Are you sure you want to create this record?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (create == DialogResult.OK)
                        {
                            mdr = command.ExecuteReader();
                            MessageBox.Show("Record Sucessfully Created!");
                            Clear();
                            con.Close();
                            return;
                        }
                        else
                        {
                            con.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book ID is unavailable!", "ID Taken", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        con.Close();
                        return;
                    }
                }
            
        }
    }

    class Text_Box
    {
        public bool TextBoxNum (KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && !char.IsControl(ch))
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
}
    
