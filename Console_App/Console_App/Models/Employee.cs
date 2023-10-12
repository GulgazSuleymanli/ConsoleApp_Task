using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public string DepartmentNo { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string surname, byte age, string departmentNo, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
        }
    }
}
