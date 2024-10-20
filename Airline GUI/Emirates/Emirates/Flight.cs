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
    public partial class Flight : Form
    {
        public Flight()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Emirates.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfc.Text == "" || cbto.SelectedItem.ToString() == "" || cbfrom.SelectedItem.ToString() == "" || dateTimePicker1.Value.ToString() == "")
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Flight values ('" + txtfc.Text + "','" + cbfrom.SelectedItem.ToString() + "','" + cbto.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString()  + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfc.Clear();
            cbfrom.SelectedItem = null;
            cbto.SelectedItem = null;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display_Flights view = new Display_Flights();
            view.Show();
            this.Hide();
        }
    }
}
