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

namespace Emirates
{
    public partial class passenger : Form
    {
        public passenger()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Emirates.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtpp.Text == "" || txtcont.Text == "" || txtadd.Text == "" || cbg.Text == ""|| cbn.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into passenger values (" + txtid.Text + ",'" + txtname.Text + "','" + txtpp.Text + "','" + txtadd.Text + "','" + cbn.SelectedItem.ToString() + "','" + cbg.SelectedItem.ToString() + "','" + txtcont.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtadd.Clear();
            txtpp.Clear();
            txtadd.Clear();
            txtcont.Clear();
            cbg.SelectedItem = null;
            cbn.SelectedItem = null;
        }

        private void btnvp_Click(object sender, EventArgs e)
        {
            Display_passenger dpass = new Display_passenger();
            dpass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
