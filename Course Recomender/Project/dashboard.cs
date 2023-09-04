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
using System.Data.Common;

namespace Project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];

            
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like '"+textBox1.Text+ "%' or  name like '%"+textBox1.Text+ "' or name like '%"+textBox1.Text+"%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like ' mobile%' or  name like '%mobile' or name like '%mobile%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like ' web%' or  name like '%web' or name like '%web%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like ' cloud%' or  name like '%cloud ' or name like '%cloud%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like 'python%' or  name like '%python' or name like '%python%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like ' ai%' or  name like '%ai' or name like '%ai%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like ' java%' or  name like '%java' or name like '%java%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=HUNTER\\SQLEXPRESS01;Database=course;Integrated Security=true");

            //open your connection

            con.Open();

            string query = "select * from course where name like ' dotnet%' or  name like '%dotnet' or name like '%dotnet%'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //create dataset to store the data

            DataSet ds = new DataSet();

            //fill the data

            da.Fill(ds);

            //retrieve the records

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
