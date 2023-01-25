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
    public partial class Registeration : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Registeration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty
                           || textBox4.Text != string.Empty || textBox5.Text != string.Empty
                           || textBox6.Text != string.Empty || textBox7.Text != string.Empty
                           || textBox8.Text != string.Empty || textBox9.Text != string.Empty || textBox10.Text != string.Empty)
            {
                if (textBox5.Text == textBox6.Text)
                {
                    cmd = new SqlCommand("select* from passenger where email='" + textBox3.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Email Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into passenger values(@email,@fname,@lname,@phone,@address,@passport_id,@national_id,@password,@bank_account_no)", cn);
                        cmd.Parameters.AddWithValue("fname", textBox1.Text);
                        cmd.Parameters.AddWithValue("lname", textBox2.Text);
                        cmd.Parameters.AddWithValue("phone", textBox4.Text);
                        cmd.Parameters.AddWithValue("address", textBox7.Text);
                        cmd.Parameters.AddWithValue("passport_id", textBox8.Text);
                        cmd.Parameters.AddWithValue("national_id", textBox9.Text);
                        cmd.Parameters.AddWithValue("bank_account_no", textBox10.Text);
                        cmd.Parameters.AddWithValue("email", textBox3.Text);
                        cmd.Parameters.AddWithValue("password", textBox5.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Passenger_Log Pas2 = new Passenger_Log();
                        Pas2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=HAMMOD;Initial Catalog=AIRLINE TICKET RESERVATION;Integrated Security=True");
            cn.Open();
        }
    }
}
