using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFrisbi
{
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm(EmployeesForm employeesForm)
        {
            this.employeesForm = employeesForm;
            InitializeComponent();
        }

        private EmployeesForm employeesForm;

        // Проверка ввода и добавление нового сотрудника в бд 
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!IsEmployeesDataCorrect()) return;

            employeesForm.InsertEmployeeToDatabase(CreateEmployee());
            ResetForm();
        }

        private bool IsEmployeesDataCorrect()
        {
            // Дополнительная проверка ввода в поле "Оклад"
            if (salaryTextBox.Text.Any(c => char.IsLetter(c) || (char.IsSymbol(c) && c != '.' && c != ',') || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Оклад не может содержать цифры, пробелы и символы", "Проверьте корректность ввода");
                return false;
            }

            if (!decimal.TryParse(salaryTextBox.Text, out decimal salar))
            {
                MessageBox.Show("Оклад не может содержать цифры, пробелы и символы", "Проверьте корректность ввода");
                return false;
            } 

            if(specializationTextBox.Text == String.Empty)
            {
                MessageBox.Show("Заполните должность сотрудника", "Проверьте корректность ввода");
                return false;
            }

            // Проверка полей ФИО на корректность ввода
            return CheckIfContainSymbolsOrDigits(lastnameTextBox)
                && CheckIfContainSymbolsOrDigits(nameTextBox)
                && CheckIfContainSymbolsOrDigits(patronymicTextBox);
        }

        private Employee CreateEmployee()
        {
            var salary = Math.Round(decimal.Parse(salaryTextBox.Text), 2);
            var employmentDate = employmentDatePicker.Value.ToString("dd.MM.yyyy");            

            return new Employee(lastnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, specializationTextBox.Text, salary, employmentDate);
        }

        // Проверка корректного ввода в текстовое поле "Оклад"
        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-')
            {
                MessageBox.Show("Оклад не может быть отрицательным", "Проверьте корректность ввода");
            }
        }

        // Проверка на содержание пробелов/символов/цифр
        private bool CheckIfContainSymbolsOrDigits(TextBox textBox)
        {
            if(textBox.Text.Any(c=>char.IsDigit(c) || (char.IsSymbol(c) && c != '-') || char.IsWhiteSpace(c)))
            {
                MessageBox.Show($"Поле {textBox.AccessibleName} не может содержать цифры, пробелы и символы, за исключением '-'", 
                    "Проверьте корректность ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Сбросить значения компонентов формы
        private void ResetForm()
        {
            foreach(Control control in Controls)
            {
                if(control is TextBox)
                {
                    control.Text = null;
                }
            }
        }
    }
}
