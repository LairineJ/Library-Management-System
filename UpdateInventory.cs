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
    public partial class UpdateInventory : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        public static string bkTitle, bkAuthor, bkGenre, bkPublisher, bkYear, bkStatus;
        string  ID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult updateConfirm = MessageBox.Show("Are you sure you want to update this record?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (updateConfirm == DialogResult.OK)
            {
                int year = dateTimeYear.Value.Year;
                //Check if there's any blank fields.
                while (txtBookTitle.Text == "" || txtAuthor.Text == "" || txtPublisher.Text == "" || dateTimeYear.Value == null)
                {
                    MessageBox.Show("Incomplete Details!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    return;
                }
                while (txtBookTitle.Text != "" || txtAuthor.Text != "" || txtPublisher.Text != "" || dateTimeYear.Value != null)
                {

                    //Update the book.
                    con.Open();
                    string updateBook = "UPDATE book_inventory SET Title='" + txtBookTitle.Text + "', Author='" + txtAuthor.Text + "', Genre='" + cmbGenre.SelectedItem + "', Publisher='" + txtPublisher.Text + "', Year_Published='" + year + "', Status='" + cmbStatus.SelectedItem + "' WHERE Book_ID='" + ID + "';";
                    command = new MySqlCommand(updateBook, con);
                    mdr = command.ExecuteReader();
                    MessageBox.Show("Updated Successfully!");
                    con.Close();
                    this.Close();
                    return;
                }
            }
        }
        public UpdateInventory()
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

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            dateTimeYear.Format = DateTimePickerFormat.Custom;
            dateTimeYear.CustomFormat = "yyyy";
            
            txtBookID.Text = AdminForm.bkID.ToString();
            txtBookTitle.Text = AdminForm.bkTitle;
            dateTimeYear.Value = DateTime.Parse(AdminForm.bkYear.ToString());
            txtAuthor.Text = AdminForm.bkAuthor;
            txtPublisher.Text = AdminForm.bkPublisher;
            cmbGenre.SelectedItem = AdminForm.bkGenre;
            cmbStatus.SelectedItem = AdminForm.bkStatus;

            ID = txtBookID.Text;
        }
    }
}
