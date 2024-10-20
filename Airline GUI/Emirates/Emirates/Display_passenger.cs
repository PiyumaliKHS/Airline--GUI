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
    public partial class Display_passenger : Form
    {
        public Display_passenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Emirates.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            passenger pass = new passenger();
            pass.Show();
            this.Hide();
        }

        private void UpdateData()
        {
            Con.Open();
            string query = "select *from passenger";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV_view.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtn.Text == "" || txtpp.Text == "" || txtadd.Text == "" || cbg.SelectedItem == null || cbn.SelectedItem == null)
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update passenger set Passenger_Name='" + txtn.Text + "',Passport_No='" + txtpp.Text + "',passenger_Address='" + txtadd.Text + "',Nationality='" + cbn.SelectedItem.ToString() + "',Gender='" + cbg.SelectedItem.ToString() + "',Contact_No='" + txtcon.Text + "' where PId='" + txtid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    Con.Close();
                    UpdateData();
                    Refresh();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Enter passenger id to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from passenger where PId=" + txtid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger deleted successfully");
                    Con.Close();
                    UpdateData();
                    Refresh();
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
            txtn.Clear();
            txtadd.Clear();
            txtpp.Clear();
            txtadd.Clear();
            txtcon.Clear();
            cbg.SelectedItem = null;
            cbn.SelectedItem = null;
        }

        private void DGV_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_view.Rows[e.RowIndex];
                txtid.Text = row.Cells["PId"].Value.ToString();
                txtn.Text = row.Cells["Passenger_Name"].Value.ToString();
                txtpp.Text = row.Cells["Passport_No"].Value.ToString();
                txtadd.Text = row.Cells["passenger_Address"].Value.ToString();
                cbn.SelectedItem = row.Cells["Nationality"].Value.ToString();
                cbg.SelectedItem = row.Cells["Gender"].Value.ToString();
                txtcon.Text = row.Cells["Contact_No"].Value.ToString();
            }

        }

        private void Display_passenger_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
