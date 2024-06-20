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
    public partial class Form6 : Form
    {
        private MySqlConnection con;
        private string server, database, user, password;

        MySqlCommand command;
        MySqlDataAdapter adapt;
        MySqlDataReader mdr;

        public Form6()
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

        private void checkTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTerms.Checked == true)
            {
                BtnSignup.Enabled = true;
            }
            if (checkTerms.Checked == false)
            {
                BtnSignup.Enabled = false;
            }
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            //Check if there's any blank fields.
            while (txtName.Text == "" || txtID.Text == "" || txtPass.Text == "" || txtConfirm.Text == "" || cmbDept.SelectedIndex == -1)
            {
                MessageBox.Show("Incomplete Details!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                return;
            }
            while (txtName.Text != "" || txtID.Text != "" || txtPass.Text != "" || txtConfirm.Text != "" || cmbDept.SelectedIndex != -1)
            {
                string facultyName = txtName.Text;
                double facultyID = double.Parse(txtID.Text);
                string facultyDept = cmbDept.SelectedItem.ToString();
                string facultyUser = txtUsername.Text;
                string facultyPass = txtPass.Text;
                string facultyConfirm = txtConfirm.Text;

                facReg facultyReg = new facReg();

                facultyReg.facultyRegistration(facultyName, facultyID, facultyDept, facultyUser, facultyPass);

                //Check if the faculty number exists from the faculty_profiles table.
                con.Open();
                string checkID = "SELECT COUNT(*) FROM faculty_profiles WHERE Faculty_No = '" + facultyID + "';";
                command = new MySqlCommand(checkID, con);
                object idExists = command.ExecuteScalar();

                if (Convert.ToInt32(idExists) > 0)
                {
                    con.Close();
                    //Check if the faculty number is already taken within the faculty_accounts table.
                    con.Open();
                    string selectID = "SELECT COUNT(*) FROM faculty_accounts WHERE Faculty_ID = '" + facultyID + "';";
                    command = new MySqlCommand(selectID, con);
                    object idTaken = command.ExecuteScalar();

                    //Check if username is 5-12 characters long.
                    if (txtUsername.Text.Length >= 5 && txtUsername.Text.Length <= 12)
                    {
                        if (Convert.ToInt32(idTaken) == 0)
                        {
                            con.Close();

                            //Check if the username is already taken within the faculty_accounts table.
                            con.Open();
                            string selectUser = "SELECT COUNT(*) FROM faculty_accounts WHERE Username = '" + facultyUser + "';";
                            command = new MySqlCommand(selectUser, con);
                            object userTaken = command.ExecuteScalar();

                            if (Convert.ToInt32(userTaken) == 0)
                            {
                                con.Close();

                                //Check if password is 6-16 characters long.
                                if (txtPass.Text.Length >= 6 && txtPass.Text.Length <= 16)
                                {
                                    //Check for password and confirm password.
                                    if (facultyPass == facultyConfirm)
                                    {
                                        con.Close();

                                        //Inserting records within the student_accounts table.
                                        con.Open();
                                        string insert = "INSERT INTO faculty_accounts VALUES ('" + facultyID + "','" + facultyName + "','" + facultyDept + "','" + facultyUser + "','" + facultyPass + "');";
                                        command = new MySqlCommand(insert, con);
                                        mdr = command.ExecuteReader();
                                        MessageBox.Show("Sucessfully Registered!");
                                        Clear();
                                        con.Close();
                                        return;
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
                        else
                        {
                            MessageBox.Show("Faculty ID is Already Taken!");
                            con.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username must be atleast 5-12 characters!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        con.Close();
                        return;
                    }
                        
                }
                else
                {
                    MessageBox.Show("Faculty Number not Found!");
                    con.Close();
                    return;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Register goback = new Register();
            goback.Show();
            this.Hide();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow number input in txtID
            Text_Box txtOnlyNum = new Text_Box();
            if (!txtOnlyNum.TextBoxNum(e))
            {
                MessageBox.Show("Number Inputs Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow letter input in txtName
            txtAlphaNumeric letterOnly = new txtAlphaNumeric();
            if (!letterOnly.alpha(e))
            {
                MessageBox.Show("Letter Inputs Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow alphanumeric input in txtUsername
            txtAlphaNumeric alphaNum = new txtAlphaNumeric();
            if (!alphaNum.alphaNumeric(e))
            {
                MessageBox.Show("Letter and Number Inputs Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void pBoxHelp_Click(object sender, EventArgs e)
        {
            frmTerms Terms = new frmTerms();
            Terms.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //label10.Visible = false;
            //label11.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Register goback = new Register();
            goback.Show();
            this.Hide();
        }

        public void Clear()
        {
            txtName.Text = "";
            txtID.Text = "";
            txtConfirm.Text = "";
            txtPass.Text = "";
            txtUsername.Text = "";
            cmbDept.SelectedIndex = -1;
            checkShowPass.Checked = false;
            checkTerms.Checked = false;
        }
    }
}
