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
    public partial class AdminLogin : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        public static string User;

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        public AdminLogin()
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

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            while (username == "" || password == "")
            {
                MessageBox.Show("Incomplete Details!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                return;
            }
            while (username != "" && password != "")
            {
                con.Open();
                //Checking for admin's username.
                string checkAdmin = "SELECT COUNT(*) FROM librarian_accounts WHERE Username = '" + username + "' && Password = '" + password + "';";
                command = new MySqlCommand(checkAdmin, con);
                object adminExist = command.ExecuteScalar();

                //Admin Login
                if (Convert.ToInt32(adminExist) > 0)
                {
                    con.Close();

                    con.Open();
                    //Finding admin's name based on their username
                    string checkAdminName = "SELECT Name FROM librarian_accounts WHERE Username = '" + username + "' && Password = '" + password + "';";
                    command = new MySqlCommand(checkAdminName, con);
                    mdr = command.ExecuteReader();
                    if (mdr.Read())
                    {
                        User = mdr.GetString("Name");
                    }
                    con.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    return;
                }

                else
                {
                    MessageBox.Show("User Not Found!", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
