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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Emirates.mdf;Integrated Security=True;Connect Timeout=30");
        private void Ticket_Load(object sender, EventArgs e)
        {
            passengers();
            Flight();
            UpdateData();
        }

        private void passengers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PId from passenger", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("PId", typeof(string));
            table.Load(reader);
            cbpid.ValueMember = "PId";
            cbpid.DataSource = table;
            Con.Close();

        }
        string passenger_name, passport_no, passenger_nation;

        private void getpassengers()
        {
            Con.Open();
            string query = "select*from passenger where PId=" + cbpid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);

            foreach (DataRow dr in table.Rows)
            {
                passenger_name = dr["Passenger_Name"].ToString();
                passport_no = dr["Passport_No"].ToString();
                passenger_nation = dr["Nationality"].ToString();
                txtn.Text = passenger_name;
                txtpp.Text = passport_no;
                txtnation.Text = passenger_nation;


            }
            Con.Close();

        }
        private void Flight()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Flight_Code from Flight", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Flight_Code", typeof(string));
            table.Load(reader);
            cmbfc.ValueMember = "Flight_Code";
            cmbfc.DataSource = table;
            Con.Close();

        }
        private void UpdateData()
        {
            Con.Open();
            string query = "select*from Ticket";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Booking_DataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cbpid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getpassengers();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttno.Text == "" || txtpp.Text == "" || txtn.Text == "" || txtnation.Text == "" || cbpid.SelectedItem == null || cmbfc.SelectedItem == null)
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Ticket values (" + txttno.Text + ",'" + cbpid.SelectedValue.ToString() + "'," + cmbfc.SelectedValue.ToString() + ",'" + txtpp.Text + "','" + txtn.Text + "','" + txtnation.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    Con.Close();
                    UpdateData();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
