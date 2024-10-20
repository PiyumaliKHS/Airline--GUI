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
    public partial class Display_Flights : Form
    {
        public Display_Flights()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Emirates.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateData()
        {
            Con.Open();
            string query = "select*from Flight";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVdf.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(txtfc.Text == "" ||  cbfrom.SelectedItem == null || cbTo.SelectedItem == null || dateTimePicker1.Value == null)
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update Flight set Starting='" + cbfrom.SelectedItem.ToString() + "',Ending='" + cbTo.SelectedItem.ToString() + "',Date='" + dateTimePicker1.Value.Date.ToString() + "' where Flight_Code='" + txtfc.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Flight updated");
                    Con.Close();

                    UpdateData();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfc.Text == "")
            {
                MessageBox.Show("Enter Flight Code to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Flight where Flight_Code='" + txtfc.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight deleted successfully");
                    Con.Close();
                    UpdateData();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           txtfc.Clear();
           cbfrom.SelectedItem = null;
           cbTo.SelectedItem = null;
        }

        private void DGVdf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVdf.Rows[e.RowIndex];
                txtfc.Text = row.Cells["Flight_code"].Value.ToString();
                cbfrom.SelectedItem = row.Cells["Starting"].Value.ToString();
                cbTo.SelectedItem = row.Cells["Ending"].Value.ToString();
               



            }
        }

        private void Display_Flights_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
    
}

