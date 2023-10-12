using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_App.Models
{
    internal class Department
    {
		private string _no;

		public string No
		{
			get 
			{ 
				return _no; 
			}
			set 
			{ 
				if(CheckNo(value))
				{
					_no = value;
				}
			}
		}

		private int _employeeLimit;

		public int EmployeeLimit
		{
			get 
			{ 
				return _employeeLimit; 
			}
			set 
			{ 
				if(value>0 && value<=20)
				{
					_employeeLimit = value;
				}
			}
		}

		Employee[] Employees=new Employee[0];

        public Department(string no, int limit)
        {
            No = no;
			EmployeeLimit = limit;
        }

        public bool CheckNo(string no)
		{
			if (char.IsUpper(no[0]) && char.IsUpper(no[1]) && no.Length==2)
			{
				return true;
			}
			return false;
		}

		public void AddEmployee(Employee emp)
		{
			Array.Resize(ref Employees, Employees.Length+1);
			Employees[Employees.Length-1] = emp;
		}

		public Employee GetEmployee(string name,string surname)
		{
			for (int i = 0; i < Employees.Length; i++)
			{
				if (Employees[i].Name==name && Employees[i].Surname==surname) 
				{
					return Employees[i];
					break;
				}
			}
			return null;
		}

		public void GetEmployeeInfo(string name)
		{
            for (int i = 0; i < Employees.Length; i++)
            {
				if (Employees[i].Name == name)
				{
					Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}, Age: {Employees[i].Age}, Department No: {Employees[i].DepartmentNo}, Salary: {Employees[i].Salary}");
				}
            }
        }

		public void GetAllEmployees()
		{
			for(int i = 0;i < Employees.Length;i++)
			{
                Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}, Department No: {Employees[i].DepartmentNo}");

            }
        }

		public void GetAllEmployeesBySalary(int minSlary, int maxSalary)
		{
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSlary && Employees[i].Salary <= maxSalary)
                {
                    Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}, Salary: {Employees[i].Salary}");
                }
            }
        }

        public void GetAllEmployeesByDepartmentNo(string departmentno)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].DepartmentNo == departmentno)
                {
                    Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}");
                }
            }
        }
    }
}
