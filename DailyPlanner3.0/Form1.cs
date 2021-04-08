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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < dataGridView1.ColumnCount; col++)
                for (int row = 0; row < dataGridView1.RowCount - 1; row++)
                    if (dataGridView1[col, row].Value.ToString().IndexOf(textBox5.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        dataGridView1[col, row].Style.BackColor = Color.Yellow;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
