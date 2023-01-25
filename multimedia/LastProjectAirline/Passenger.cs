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


namespace LastProjectAirline
{
    public partial class Passenger : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HAMMOD;Initial Catalog=AIRLINE TICKET RESERVATION;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;
    
        public Passenger()
        {
            InitializeComponent();
            
            Da = new SqlDataAdapter("select * from passenger", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Passenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIRLINE_TICKET_RESERVATIONDataSet.passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this.aIRLINE_TICKET_RESERVATIONDataSet.passenger);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
