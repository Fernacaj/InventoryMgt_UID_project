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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagmentSystem
{
    public partial class NewRequest : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Niraj\Documents\EmpDB.mdf;
            Integrated Security=True;Connect Timeout=30");
        public NewRequest()
        {
            InitializeComponent();
        }
        private void NewRequestLoad1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT (emp_name) FROM empdata", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("emp_name", typeof(string));
                dt.Load(reader);
                BU_Owner.ValueMember = "emp_name";
                BU_Owner.DataSource = dt;
                con.Close();


                
            }
            catch (Exception)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titile_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDBDataSet2.empdata' table. You can move, or remove it, as needed.
            this.empdataTableAdapter.Fill(this.empDBDataSet2.empdata);

        }

        private void exitt_Click(object sender, EventArgs e)
        {
            // Create an instance of the HomePageForm
            HomePage homePage = new HomePage();

            // Show the home page form
            homePage.Show();

            // Close the current form if needed
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create an instance of the HomePageForm
            HomePage homePage = new HomePage();

            // Show the home page form
            homePage.Show();

            // Close the current form if needed
            this.Close();
        }

        private void titile_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Title.Clear();
            ReportType.Items.Clear();
            Report_Status.Items.Clear();
            Frequency.Items.Clear();
            BU_Owner.Items.Clear();
            BU_Approver.Items.Clear();
            CART_Owner.Items.Clear();
            CART_Approver.Items.Clear();
            TO.Clear();
            CC.Clear();
            Comment.Clear();
            Attachments.Clear();
            Location.Items.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BU_Owner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}