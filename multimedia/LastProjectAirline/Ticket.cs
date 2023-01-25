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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIRLINE_TICKET_RESERVATIONDataSet.ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.aIRLINE_TICKET_RESERVATIONDataSet.ticket);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reserve Re = new Reserve();
            Re.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           MessageBox.Show("Your Reservation Has Been Confirmed \n \n Thank You For Using '' WE FLY ''  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Home H = new Home();
            H.Show();
            this.Hide();

        }
    }
}
