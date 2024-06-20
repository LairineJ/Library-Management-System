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
    public partial class Form4 : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        public Form4()
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

        private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
