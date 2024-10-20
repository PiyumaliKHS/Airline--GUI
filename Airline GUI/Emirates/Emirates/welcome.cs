using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emirates
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtpass.Text == "")

            {
                MessageBox.Show("Enter input Username and Password", "Error");
            }

            else if (txtid.Text == "Airline" && txtpass.Text == "Airline")
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Invalid Authentication");
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
           txtid.Clear();
           txtpass.Clear();
        }
    }
}
