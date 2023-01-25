using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProjectAirline
{
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIRLINE_TICKET_RESERVATIONDataSet.flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.aIRLINE_TICKET_RESERVATIONDataSet.flights);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket Tic = new Ticket();
            Tic.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
            
            ;
        }
    }
}
