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
    public partial class Admin_Log : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HAMMOD;Initial Catalog=AIRLINE TICKET RESERVATION;Integrated Security=True");

        public Admin_Log()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = textBox1.Text;
            user_password = textBox2.Text;
            try
            {
                String querry = "SELECT * FROM Admins WHERE User_Name_ = '" + textBox1.Text + "' AND Pass_word = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    user_password = textBox2.Text;
                    //page that needed to be load next
                    Admin_Menu Adm = new Admin_Menu();
                    Adm.Show();
                    this.Hide();
                }

                else
                {

                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    //to focus username
                    textBox1.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            //to focus username
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Main Mai = new Main();
            Mai.SendToBack();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                var checkBox1 = (CheckBox)sender;
                checkBox1.Text = "Hide";
            }
            else
                textBox2.UseSystemPasswordChar = true;
            var checkBox = (CheckBox)sender;
            checkBox.Text = "View";
        }
    }
}
