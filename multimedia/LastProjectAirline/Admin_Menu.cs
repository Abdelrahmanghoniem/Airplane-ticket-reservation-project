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
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passenger Pas = new Passenger();
            Pas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flights Fli = new Flights();
            Fli.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets Tick = new Tickets();
            Tick.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Airport Aip = new Airport();
            Aip.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Airplane Ain = new Airplane();
            Ain.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Airline Ail = new Airline();
            Ail.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Payment Pay = new Payment();
            Pay.Show();
        }
    }
}
