
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label taskLabel;
            this.dailyPlannerDataSet = new WindowsFormsApp1.DailyPlannerDataSet();
            this.dailyPlannerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyPlannerTableAdapter = new WindowsFormsApp1.DailyPlannerDataSetTableAdapters.DailyPlannerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DailyPlannerDataSetTableAdapters.TableAdapterManager();
            this.dailyPlannerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dailyPlannerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dailyPlannerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            taskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerBindingNavigator)).BeginInit();
            this.dailyPlannerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyPlannerDataSet
            // 
            this.dailyPlannerDataSet.DataSetName = "DailyPlannerDataSet";
            this.dailyPlannerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyPlannerBindingSource
            // 
            this.dailyPlannerBindingSource.DataMember = "DailyPlanner";
            this.dailyPlannerBindingSource.DataSource = this.dailyPlannerDataSet;
            // 
            // dailyPlannerTableAdapter
            // 
            this.dailyPlannerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyPlannerTableAdapter = this.dailyPlannerTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DailyPlannerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dailyPlannerBindingNavigator
            // 
            this.dailyPlannerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dailyPlannerBindingNavigator.BindingSource = this.dailyPlannerBindingSource;
            this.dailyPlannerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dailyPlannerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dailyPlannerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dailyPlannerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dailyPlannerBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.dailyPlannerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dailyPlannerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dailyPlannerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dailyPlannerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dailyPlannerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dailyPlannerBindingNavigator.Name = "dailyPlannerBindingNavigator";
            this.dailyPlannerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dailyPlannerBindingNavigator.Size = new System.Drawing.Size(836, 27);
            this.dailyPlannerBindingNavigator.TabIndex = 1;
            this.dailyPlannerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // dailyPlannerBindingNavigatorSaveItem
            // 
            this.dailyPlannerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dailyPlannerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dailyPlannerBindingNavigatorSaveItem.Image")));
            this.dailyPlannerBindingNavigatorSaveItem.Name = "dailyPlannerBindingNavigatorSaveItem";
            this.dailyPlannerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.dailyPlannerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.dailyPlannerBindingNavigatorSaveItem.Click += new System.EventHandler(this.dailyPlannerBindingNavigatorSaveItem_Click);
            // 
            // dailyPlannerDataGridView
            // 
            this.dailyPlannerDataGridView.AutoGenerateColumns = false;
            this.dailyPlannerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyPlannerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dailyPlannerDataGridView.DataSource = this.dailyPlannerBindingSource;
            this.dailyPlannerDataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dailyPlannerDataGridView.Location = new System.Drawing.Point(12, 72);
            this.dailyPlannerDataGridView.Name = "dailyPlannerDataGridView";
            this.dailyPlannerDataGridView.RowHeadersWidth = 51;
            this.dailyPlannerDataGridView.RowTemplate.Height = 24;
            this.dailyPlannerDataGridView.Size = new System.Drawing.Size(812, 237);
            this.dailyPlannerDataGridView.TabIndex = 2;
            this.dailyPlannerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dailyPlannerDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Task";
            this.dataGridViewTextBoxColumn2.HeaderText = "Task";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(274, 348);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dailyPlannerBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(322, 346);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(597, 348);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPlannerBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(686, 343);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new System.Drawing.Point(30, 348);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new System.Drawing.Size(43, 17);
            taskLabel.TabIndex = 7;
            taskLabel.Text = "Task:";
            taskLabel.Click += new System.EventHandler(this.taskLabel_Click);
            // 
            // taskTextBox
            // 
            this.taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPlannerBindingSource, "Task", true));
            this.taskTextBox.Location = new System.Drawing.Point(79, 348);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(100, 22);
            this.taskTextBox.TabIndex = 8;
            this.taskTextBox.TextChanged += new System.EventHandler(this.taskTextBox_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(taskLabel);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.dailyPlannerDataGridView);
            this.Controls.Add(this.dailyPlannerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerBindingNavigator)).EndInit();
            this.dailyPlannerBindingNavigator.ResumeLayout(false);
            this.dailyPlannerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPlannerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DailyPlannerDataSet dailyPlannerDataSet;
        private System.Windows.Forms.BindingSource dailyPlannerBindingSource;
        private DailyPlannerDataSetTableAdapters.DailyPlannerTableAdapter dailyPlannerTableAdapter;
        private DailyPlannerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dailyPlannerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dailyPlannerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dailyPlannerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

