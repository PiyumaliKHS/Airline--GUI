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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btn_passengers_Click(object sender, EventArgs e)
        {
            passenger p = new passenger();
            p.Show();
            this.Hide();
        }

        private void btnf_Click(object sender, EventArgs e)
        {
            Flight f = new Flight();
            f.Show();
            this.Hide();
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            Ticket t= new Ticket();
            t.Show();
            this.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
