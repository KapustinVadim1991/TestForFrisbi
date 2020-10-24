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
using System.Configuration;
using System.IO;

namespace TestFrisbi
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        // Запись сотрудника в БД
        public void InsertEmployeeToDatabase(Employee employee)
        {
            if (employee == null || !employee.IsValidData())
                throw new ArgumentException("EmployeeForm.cs <InsertEmployeeToDatabase>: параметр employee не может содержать пустые значения и не может быть равен null");

            try
            {
                employeesTableAdapter.InsertNewEmployee(employee.Name, employee.LastName, employee.Patronymic,
                    employee.Specialisation, employee.Salary, employee.EmploymentDate);

                employeesTableAdapter.Fill(databaseDataSet.Employees);
                RefreshStatistics();
                MessageBox.Show("Сотрудник успешно добавлен");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestFrisbi_Load(object sender, EventArgs e)
        {
            try
            {
                employeesTableAdapter.Fill(databaseDataSet.Employees);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось вывести список сотрудников, проверьте соединение с БД\n", ex.Message);
            }

            if(databaseDataSet.Employees.Count != 0)
                RefreshStatistics();
        }

        private void RefreshStatistics()
        {
            ActualEmployeeCount.Text = employeesTableAdapter.ActualEmployeesSum().ToString();
            AvgSalary.Text = employeesTableAdapter.AverageSalary().ToString();
            DismissalCount.Text = employeesTableAdapter.DismissalEmployeesSum().ToString();
        }

        // Поиск по фамилии имени отчеству
        private void SearchTextBoxesChanged(object sender, EventArgs e)
        {
            employeesTableAdapter.FillBySearch(databaseDataSet.Employees, lastnameSearchTextBox.Text, 
                nameSearchTextBox.Text, patronymicSearchTextBox.Text);
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            new NewEmployeeForm(this).Show();
        }

        //увольнение сотрудника
        private void dismissalButton_Click(object sender, EventArgs e)
        {
            try
            {
                var employee_id = (int)employeesDataGridView.CurrentRow.Cells[0].Value;

                DialogResult answer = MessageBox.Show($"Установить дату увольнения {dismissalDateTimePicker.Value.ToString("dd.MM.yyyy")} для сотрудника:" +
                    $" {employeesDataGridView.CurrentRow.Cells[1].Value} {employeesDataGridView.CurrentRow.Cells[2].Value} " +
                    $"{employeesDataGridView.CurrentRow.Cells[3].Value}", "Увольнение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if(answer == DialogResult.OK)
                {
                    if (!EmploymentDateCompare()) return;

                    employeesTableAdapter.SetDismissalDate(dismissalDateTimePicker.Value.ToString("dd.MM.yyyy"), employee_id);
                    employeesTableAdapter.Fill(databaseDataSet.Employees);
                    RefreshStatistics();
                }
            }
            catch(NullReferenceException nullReferenceException)
            {
                MessageBox.Show($"Таблица с сотрудниками пуста\n {nullReferenceException.Message}", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        // Проверка на то, что выбранная дата увольнения не меньше даты приема на работу
        private bool EmploymentDateCompare()
        {
            DateTime employmentDate = DateTime.Parse(employeesDataGridView.CurrentRow.Cells[6].Value.ToString());

            if (dismissalDateTimePicker.Value < employmentDate)
            {
                MessageBox.Show("Дата увольнения не может быть меньше, чем дата приёма на работу");
                return false;
            }

            return true;
        }

        // Выгрузка из набора данных в файл формата XML
        private void exportButton_Click(object sender, EventArgs e)
        {
            if(databaseDataSet.Employees.Count == 0)
            {
                MessageBox.Show("Таблица с сотрудниками пуста", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Файлы XML|*.xml";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string xmlFilename = saveFileDialog.FileName;

                if (!xmlFilename.Contains(".xml"))
                    xmlFilename += ".xml";

                FileStream streamWrite = new FileStream(xmlFilename, FileMode.Create);
                databaseDataSet.WriteXml(streamWrite);
            }
        }

        private void EmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Validate();
            employeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(databaseDataSet);
        }
    }
}
