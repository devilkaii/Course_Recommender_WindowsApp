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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string genter = "";
            if (radioButton1.Checked)
            {
                genter = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                genter = radioButton2.Text;
            }


            
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");
            //open your connection
            con.Open();
            string query = "insert into customer_details values('"+textBox1.Text+ "','"+textBox2.Text+ "','+gender+','"+textBox4.Text+ "','"+textBox5.Text+ "','"+textBox6.Text+ "','"+textBox7.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("registered Successfully...");
            this.Close();
            dashboard ec = new dashboard();
            ec.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            home ec = new home();
            ec.Show();
            

            
        }
    }
}
