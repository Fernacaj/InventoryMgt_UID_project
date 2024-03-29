using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryManagmentSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitt_Click(object sender, EventArgs e)
        {

            new LoginPage().Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new NewRequest().Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new NewRequest().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Modifyreport().Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Viewreports().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new AdhockReport().Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Approvals().Show();
            this.Hide();
        }

        
        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "Hello";
        }
    }
}
