using Console_App.Models;

namespace Console_App
{
    internal class Program
    {
        public object Employees { get; private set; }

        static void Main(string[] args)
        {
            bool check=true;
            Employee[] Employees = new Employee[0];
            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("====== Menu ======");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Search employee");
                Console.WriteLine("3. Check all employee");
                Console.WriteLine("4. Search employee by salary");
                Console.WriteLine("5. Search employee by departmentno");
                Console.WriteLine("0. Exit");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Select operation");
                
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Insert employee name:");
                        string name= Console.ReadLine();
                        
                        Console.WriteLine("Insert employee surname:");
                        string surname= Console.ReadLine();
                       
                        Console.WriteLine("Insert employee age:");
                        byte age=byte.Parse(Console.ReadLine());

                        string departmentno;
                        do
                        {
                            Console.WriteLine("Insert employee departmentno:");
                            departmentno = Console.ReadLine();
                        }
                        while (!CheckNo(departmentno));
                        
                        Console.WriteLine("Insert employee salary:");
                        int salary=int.Parse(Console.ReadLine());
                        
                        Employee employee=new Employee(name, surname, age, departmentno, salary);

                        Array.Resize(ref Employees, Employees.Length + 1);
                        Employees[Employees.Length - 1] = employee;
                        break;
                    
                    case "2":
                        if (Employees!=null)
                        {
                            Console.WriteLine("Insert search name:");
                            string searchName=Console.ReadLine();

                            Console.WriteLine("Insert search surname:");
                            string searchSurname=Console.ReadLine();

                            for (int i = 0; i < Employees.Length; i++)
                            {
                                if (Employees[i].Name.ToLower() == searchName.ToLower() && Employees[i].Surname.ToLower() == searchSurname.ToLower())
                                {
					                Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}, Age: {Employees[i].Age}, Department No: {Employees[i].DepartmentNo}, Salary: {Employees[i].Salary}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please, first create an employee");
                        }
                    break;

                    case "3":
                        if (Employees!=null)
                        {
                            foreach (var emp in Employees)
                            {
                                Console.WriteLine($"Name: {emp.Name}, Surname: {emp.Surname}, Department No: {emp.DepartmentNo}");

                            }
                        }
                        else
                        {
                            Console.WriteLine("Please, first create an employee");
                        }
                    break;

                    case "4":
                        if (Employees != null)
                        {
                            Console.WriteLine("Insert min search salary");
                            int minSalary=int.Parse(Console.ReadLine());

                            Console.WriteLine("Insert max search salary");
                            int maxSalary=int.Parse(Console.ReadLine());

                            for (int i = 0; i < Employees.Length; i++)
                            {
                                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                                {
                                    Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}, Salary: {Employees[i].Salary}");
                                }
                            }
                            Console.WriteLine("None");
                        }
                        else
                        {
                            Console.WriteLine("Please, first create an employee");
                        }
                        break;

                    case "5":
                        if (Employees != null)
                        {
                            Console.WriteLine("Insert search departmentno");
                            string no=Console.ReadLine();

                            for (int i = 0; i < Employees.Length; i++)
                            {
                                if (Employees[i].DepartmentNo == no.ToUpper())
                                {
                                    Console.WriteLine($"Name: {Employees[i].Name}, Surname: {Employees[i].Surname}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please, first create an employee");
                        }
                        break;

                    case "0":
                        return;
                }
            }
            while (check);
        }

        //static void CreateDepartment()
        //{
        //    string no;
        //    int limit;
        //    do
        //    {
        //        Console.WriteLine("Insert DepartmentNo:");
        //        no = Console.ReadLine();
        //    }
        //    while (!CheckNo(no));
        //    do
        //    {
        //        Console.WriteLine("Insert employee limit:");
        //        limit=int.Parse(Console.ReadLine());
        //    }
        //    while(!(limit > 0 && limit <= 20));
        //    Department[] departments = new Department[0]; 
        //}

        public static bool CheckNo(string no)
        {
            if (char.IsUpper(no[0]) && char.IsUpper(no[1]) && no.Length == 2)
            {
                return true;
            }
            return false;
        }

        

    }
}