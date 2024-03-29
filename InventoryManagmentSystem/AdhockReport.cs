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
    public partial class AdhockReport : Form
    {
        public AdhockReport()
        {
            InitializeComponent();
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
    }
}
