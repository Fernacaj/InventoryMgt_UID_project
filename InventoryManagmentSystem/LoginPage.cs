using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace InventoryManagmentSystem
{
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Niraj\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string mail = "";
            string password = "";

            if (Email.Text==""||Password.Text=="")
            {
                MessageBox.Show("Please fill in all the required fields","LOGIN FAILD",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                if(IsValidEmail(Email.Text))
                {
                     mail = Email.Text;
                    if (verify("select count(*) from empdata where email='"+mail+"'")>0)
                    {
                        if (verify("select count(*) from empdata where email='" + mail + "' and password='"+Password.Text+"'") > 0)
                        {
                            new HomePage().Show();
                            this.Hide();
                        }
                        else
                        {
                            label4.ForeColor = Color.Red;
                            label4.Text = "Password is not matching";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email id not there in record", "LOGIN FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email id invalid", "LOGIN FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               //
            }
        }

        int verify(string query)
        {
            con.Open();
            
            int count = 0;
            SqlCommand com = new SqlCommand(query, con);
            count = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return count;
        }

        private bool IsValidEmail(string email)
        {

            Regex re = new Regex(@"^[a-zA-Z0-9._%+-]+@[xyz]+\.[a-zA-Z]{2,}$");
            return re.IsMatch(email);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {     
                // Hide the current form (login form)
                this.Hide();
                // Show the Forgot Password form
                ForgotPassword forgotPasswordForm = new ForgotPassword();
                forgotPasswordForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
