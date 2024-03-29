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
    public partial class ForgotPassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Niraj\Documents\empDB.mdf;Integrated Security=True;Connect Timeout=30");
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string mail = "";
            string pass = "";
            if (email.Text == "" || password.Text == "" || cpassword.Text == "")
            {
                MessageBox.Show("Please fill in all the required fields", "Reset Password FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (password.Text != cpassword.Text)
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Password is not matching";
                }
                else
                {
                    label6.ForeColor = Color.White;
                    label6.Text = "*";

                    if (IsValidEmail(email.Text) == true)
                    {
                        mail = email.Text;
                        if (verify("select count(*) from empdata where email='" + mail + "'") > 0)
                        {
                            insert("update empdata set password='"+password.Text+ "' where email='" + mail + "' ");
                            email.Text = "";
                            password.Text = "";
                            cpassword.Text = "";
                            MessageBox.Show("Reset Password success", "Reset Password success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Create an instance of the HomePageForm
                            LoginPage F1 = new LoginPage();

                            // Show the home page form
                            F1.Show();

                            // Close the current form if needed
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email id not there in record", "Reset Password FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email id invalid", "Reset Password FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //
                }
            }
             
        }
        public int verify(string query)
        {
            con.Open();
            int count = 0;
            SqlCommand com = new SqlCommand(query, con);
            count = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return count;
        }

        public bool IsValidEmail(string email)
        {

            Regex re = new Regex(@"^[a-zA-Z0-9._%+-]+@[xyz]+\.[a-zA-Z]{2,}$");
            if (re.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void insert(string query)
        {
            con.Open();

            int count = 0;
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}
