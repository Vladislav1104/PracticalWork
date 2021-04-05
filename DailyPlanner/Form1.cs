using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dailyPlannerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dailyPlannerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dailyPlannerDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dailyPlannerDataSet.DailyPlanner". При необходимости она может быть перемещена или удалена.
            this.dailyPlannerTableAdapter.Fill(this.dailyPlannerDataSet.DailyPlanner);

        }

        private void taskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dailyPlannerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
