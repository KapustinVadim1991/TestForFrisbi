using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace TestFrisbi
{
    public class Employee
    {
        public string LastName { get; private set; } 
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public string Specialisation { get; private set; }
        public decimal Salary { get; private set; }
        public string EmploymentDate { get; private set; }

        public Employee(string LastName, string Name, string Patronymic, string Specialisation, decimal Salary, string EmploymentDate)
        {
            this.LastName = LastName;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Specialisation = Specialisation;
            this.Salary = Salary;
            this.EmploymentDate = EmploymentDate;
        }

        public bool IsValidData()
        {
            return LastName != String.Empty &&
                   Name != String.Empty &&
                   Patronymic != String.Empty &&
                   Specialisation != String.Empty &&
                   EmploymentDate != String.Empty;
        }
    }
}
