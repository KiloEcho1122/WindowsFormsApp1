using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string connString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlConnection sqlcon = new SqlConnection(connString);

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(connString);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Login]", sqlcon);
            adapter.SelectCommand = cmd;

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Login]", sqlcon);
            adapter.SelectCommand = cmd;

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
