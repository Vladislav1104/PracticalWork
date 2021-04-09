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

namespace DailyPlanner3._0
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
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=DailyPlanner3.0; Integrated Security=True");
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            if (label11.Visible)
                label11.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                cmd.CommandText = "insert into DailyPlannerTable(Task,Date,Description,Type) values ('" + textBox1.Text + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + textBox3.Text + "', '" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
            }
            else 
            {
                label11.Visible = true;
                label11.Text = "Поля 'Задача', 'Введите описание' и 'Выберите тип задачи' должны быть заполнены!";
            }
            con.Close();
            GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            if (label12.Visible)
                label12.Visible = false;

            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) && !string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                cmd.CommandText = "update DailyPlannerTable set Task='" + textBox4.Text + "', Date='" + dateTimePicker1.Value.ToShortDateString() + "', Description='" + textBox6.Text + "', Type = '" + comboBox2.Text + "' where id=" + textBox7.Text + "";
                cmd.ExecuteNonQuery();
            }
            else 
            {
                label12.Visible = true;
                label12.Text = "Поля 'Задача', 'Описание', 'Номер задачи которую вы хотите изменить' и 'Тип' должны быть заполнены!";
            }
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            if (label13.Visible)
                label13.Visible = false;

            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text))
            {
                cmd.CommandText = "delete from DailyPlannerTable where id=" + textBox8.Text + "";
                cmd.ExecuteNonQuery();
            }
            else 
            {
                label13.Visible = true;
                label13.Text = "Поле 'Номер задачи, которую нужно удалить' должны быть заполнены!";
            }
            con.Close();
            GetList();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Task LIKE '%{textBox9.Text}%' OR Description LIKE '%{textBox9.Text}%'";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("date = '{0}'", dateTimePicker3.Value.Date);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Type LIKE '%{comboBox3.SelectedItem = "Работа"}%'";
                break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Type LIKE '%{comboBox3.SelectedItem = "Отдых"}%'";
                break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Type LIKE '%{comboBox3.SelectedItem = "Хобби"}%'";
                break;
                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Type LIKE '%{comboBox3.SelectedItem = "Покупки"}%'";
                break;
                case 4:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Type LIKE '%{comboBox3.SelectedItem = "Другое"}%'";
                break;
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
