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

namespace DailyPlanner2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=DailyPlanner; Integrated Security=True");
            da = new SqlDataAdapter("Select *From DailyPlannerTable", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "DailyPlannerTable");
            dataGridView1.DataSource = ds.Tables["DailyPlannerTable"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into DailyPlannerTable(Task,Date,Description) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update DailyPlannerTable set Task='" + textBox2.Text + "',Date='" + textBox3.Text + "',Description='" + textBox4.Text + "' where id=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from DailyPlannerTable where id=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select *from DailyPlannerTable where id=" + textBox1.Text + "";
            //cmd.CommandText = "select *from DailyPlannerTable where Task=" + textBox2.Text + "";
            //cmd.CommandText = "select *from DailyPlannerTable where Date=" + textBox3.Text + "";
            //cmd.CommandText = "select *from DailyPlannerTable where Description=" + textBox4.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
