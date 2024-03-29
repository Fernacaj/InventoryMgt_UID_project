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
    public partial class Viewreports : Form
    {
        public Viewreports()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Viewreports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDBDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.empDBDataSet1.Inventory);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillBy(this.empDBDataSet1.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
