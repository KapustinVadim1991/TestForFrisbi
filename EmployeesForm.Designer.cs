namespace TestFrisbi
{
    partial class EmployeesForm
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
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.dismissalButton = new System.Windows.Forms.Button();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.lastnameSearchTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.patronymicSearchTextBox = new System.Windows.Forms.TextBox();
            this.PatronicLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DismissalCount = new System.Windows.Forms.Label();
            this.AvgSalary = new System.Windows.Forms.Label();
            this.ActualEmployeeCount = new System.Windows.Forms.Label();
            this.DismissalCountLabel = new System.Windows.Forms.Label();
            this.ActualEmployeeCountLabel = new System.Windows.Forms.Label();
            this.AvgSalaryLabel = new System.Windows.Forms.Label();
            this.dismissalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new TestFrisbi.DatabaseDataSet();
            this.employeesTableAdapter = new TestFrisbi.DatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new TestFrisbi.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(7, 7);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(142, 28);
            this.newEmployeeButton.TabIndex = 0;
            this.newEmployeeButton.Text = "Добавить сотрудника";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.newEmployeeButton_Click);
            // 
            // dismissalButton
            // 
            this.dismissalButton.Location = new System.Drawing.Point(126, 4);
            this.dismissalButton.Name = "dismissalButton";
            this.dismissalButton.Size = new System.Drawing.Size(143, 33);
            this.dismissalButton.TabIndex = 1;
            this.dismissalButton.Text = "Установить";
            this.dismissalButton.UseVisualStyleBackColor = true;
            this.dismissalButton.Click += new System.EventHandler(this.dismissalButton_Click);
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.AllowUserToOrderColumns = true;
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesDataGridView.Location = new System.Drawing.Point(1, 87);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(817, 262);
            this.employeesDataGridView.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(60, 42);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // lastnameSearchTextBox
            // 
            this.lastnameSearchTextBox.Location = new System.Drawing.Point(63, 58);
            this.lastnameSearchTextBox.Name = "lastnameSearchTextBox";
            this.lastnameSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.lastnameSearchTextBox.TabIndex = 6;
            this.lastnameSearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBoxesChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(194, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя";
            // 
            // nameSearchTextBox
            // 
            this.nameSearchTextBox.Location = new System.Drawing.Point(197, 58);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.nameSearchTextBox.TabIndex = 8;
            this.nameSearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBoxesChanged);
            // 
            // patronymicSearchTextBox
            // 
            this.patronymicSearchTextBox.Location = new System.Drawing.Point(328, 58);
            this.patronymicSearchTextBox.Name = "patronymicSearchTextBox";
            this.patronymicSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.patronymicSearchTextBox.TabIndex = 9;
            this.patronymicSearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBoxesChanged);
            // 
            // PatronicLabel
            // 
            this.PatronicLabel.AutoSize = true;
            this.PatronicLabel.Location = new System.Drawing.Point(325, 42);
            this.PatronicLabel.Name = "PatronicLabel";
            this.PatronicLabel.Size = new System.Drawing.Size(54, 13);
            this.PatronicLabel.TabIndex = 10;
            this.PatronicLabel.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.SlateGray;
            this.BottomPanel.Controls.Add(this.exportButton);
            this.BottomPanel.Controls.Add(this.DismissalCount);
            this.BottomPanel.Controls.Add(this.AvgSalary);
            this.BottomPanel.Controls.Add(this.ActualEmployeeCount);
            this.BottomPanel.Controls.Add(this.DismissalCountLabel);
            this.BottomPanel.Controls.Add(this.ActualEmployeeCountLabel);
            this.BottomPanel.Controls.Add(this.AvgSalaryLabel);
            this.BottomPanel.Location = new System.Drawing.Point(1, 348);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(817, 102);
            this.BottomPanel.TabIndex = 12;
            // 
            // DismissalCount
            // 
            this.DismissalCount.AutoSize = true;
            this.DismissalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DismissalCount.Location = new System.Drawing.Point(349, 57);
            this.DismissalCount.Name = "DismissalCount";
            this.DismissalCount.Size = new System.Drawing.Size(16, 17);
            this.DismissalCount.TabIndex = 5;
            this.DismissalCount.Text = "0";
            // 
            // AvgSalary
            // 
            this.AvgSalary.AutoSize = true;
            this.AvgSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgSalary.Location = new System.Drawing.Point(203, 30);
            this.AvgSalary.Name = "AvgSalary";
            this.AvgSalary.Size = new System.Drawing.Size(16, 17);
            this.AvgSalary.TabIndex = 4;
            this.AvgSalary.Text = "0";
            // 
            // ActualEmployeeCount
            // 
            this.ActualEmployeeCount.AutoSize = true;
            this.ActualEmployeeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActualEmployeeCount.Location = new System.Drawing.Point(504, 4);
            this.ActualEmployeeCount.Name = "ActualEmployeeCount";
            this.ActualEmployeeCount.Size = new System.Drawing.Size(16, 17);
            this.ActualEmployeeCount.TabIndex = 3;
            this.ActualEmployeeCount.Text = "0";
            // 
            // DismissalCountLabel
            // 
            this.DismissalCountLabel.AutoSize = true;
            this.DismissalCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DismissalCountLabel.Location = new System.Drawing.Point(3, 57);
            this.DismissalCountLabel.Name = "DismissalCountLabel";
            this.DismissalCountLabel.Size = new System.Drawing.Size(340, 17);
            this.DismissalCountLabel.TabIndex = 2;
            this.DismissalCountLabel.Text = "Количество уволенных/уволившихся сотрудников:";
            // 
            // ActualEmployeeCountLabel
            // 
            this.ActualEmployeeCountLabel.AutoSize = true;
            this.ActualEmployeeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActualEmployeeCountLabel.Location = new System.Drawing.Point(4, 4);
            this.ActualEmployeeCountLabel.Name = "ActualEmployeeCountLabel";
            this.ActualEmployeeCountLabel.Size = new System.Drawing.Size(494, 17);
            this.ActualEmployeeCountLabel.TabIndex = 1;
            this.ActualEmployeeCountLabel.Text = "Количество сотрудников работающих в организации в настоящее время:";
            // 
            // AvgSalaryLabel
            // 
            this.AvgSalaryLabel.AutoSize = true;
            this.AvgSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgSalaryLabel.Location = new System.Drawing.Point(3, 30);
            this.AvgSalaryLabel.Name = "AvgSalaryLabel";
            this.AvgSalaryLabel.Size = new System.Drawing.Size(194, 17);
            this.AvgSalaryLabel.TabIndex = 0;
            this.AvgSalaryLabel.Text = "Средняя зароботная плата:";
            // 
            // dismissalDateTimePicker
            // 
            this.dismissalDateTimePicker.Location = new System.Drawing.Point(126, 40);
            this.dismissalDateTimePicker.Name = "dismissalDateTimePicker";
            this.dismissalDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.dismissalDateTimePicker.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dismissalButton);
            this.panel1.Controls.Add(this.dismissalDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(533, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 67);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-17, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 56);
            this.label2.TabIndex = 14;
            this.label2.Text = "Установить дату увольнения сотрудника:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Specialisation";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn6.HeaderText = "Оклад";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmploymentDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата приема на работу";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DismissalDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата увольнения";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = TestFrisbi.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(690, 7);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(112, 31);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Экспорт в Xml";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatronicLabel);
            this.Controls.Add(this.patronymicSearchTextBox);
            this.Controls.Add(this.nameSearchTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.lastnameSearchTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.newEmployeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeesForm";
            this.Text = "Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeesForm_FormClosing);
            this.Load += new System.EventHandler(this.TestFrisbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button dismissalButton;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox lastnameSearchTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.TextBox patronymicSearchTextBox;
        private System.Windows.Forms.Label PatronicLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label DismissalCount;
        private System.Windows.Forms.Label AvgSalary;
        private System.Windows.Forms.Label ActualEmployeeCount;
        private System.Windows.Forms.Label DismissalCountLabel;
        private System.Windows.Forms.Label ActualEmployeeCountLabel;
        private System.Windows.Forms.Label AvgSalaryLabel;
        private System.Windows.Forms.DateTimePicker dismissalDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportButton;
    }
}

