using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select mail,password from customer_details where mail='" + textBox1.Text + "' and password='" + textBox2.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())

            {

                MessageBox.Show("Login successfully...");
                home home = new home();
                home.Hide();
                this.Close();
                dashboard db = new dashboard();
                db.Show();
                
                
                dr.Close();

            }

            else

            {
                dr.Close();
                string query1 = "select mail from customer_details where mail='" + textBox1.Text + "'";
                cmd = new SqlCommand(query1, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Invalid password");
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }

                    

            }

            dr.Close();

            con.Close();
        }

       
    }
}
