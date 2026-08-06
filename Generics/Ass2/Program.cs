using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public Employee(int id,string name,double salary)
        {
            EmployeeID=id;
            EmployeeName=name;
            Salary=salary;
        }
    }
    class EmployeeDAL
    {
        SortedList<int, Employee> employees=new SortedList<int, Employee>();
        public bool AddEmployee(Employee e)
        {
            if(employees.ContainsKey(e.EmployeeID))
                return false;
            employees.Add(e.EmployeeID,e);
            return true;
        }
        public bool DeleteEmployee(int id)
        {
            if(employees.ContainsKey(id))
            {
                employees.Remove(id);
                return true;
            }
            return false;
        }
        public string SearchEmployee(int id)
        {
            if(employees.ContainsKey(id))
            {
                return employees[id].EmployeeName;
            }
            return null;
        }
        public SortedList<int,Employee> GetAllEmployees()
        {
            return employees;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL dal=new EmployeeDAL();
            while(true)
            {
                Console.WriteLine("\n===== Employee Management =====");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Delete Employee");
                Console.WriteLine("3.Search Employee");
                Console.WriteLine("4.Display All Employees");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice: ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter Employee ID: ");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Employee Name: ");
                        string name=Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        double salary=Convert.ToDouble(Console.ReadLine());
                        Employee emp=new Employee(id,name,salary);
                        if(dal.AddEmployee(emp))
                            Console.WriteLine("Employee Added Successfully.");
                        else
                            Console.WriteLine("Employee ID already exists.");
                        break;
                    case 2:
                        Console.Write("Enter Employee ID to Delete: ");
                        id=Convert.ToInt32(Console.ReadLine());
                        if(dal.DeleteEmployee(id))
                            Console.WriteLine("Employee Deleted Successfully.");
                        else
                            Console.WriteLine("Employee Not Found.");
                        break;
                    case 3:
                        Console.Write("Enter Employee ID to Search: ");
                        id=Convert.ToInt32(Console.ReadLine());
                        string empName=dal.SearchEmployee(id);
                        if(empName!=null)
                            Console.WriteLine("Employee Name: "+empName);
                        else
                            Console.WriteLine("Employee Not Found.");
                        break;
                    case 4:
                        SortedList<int, Employee> list=dal.GetAllEmployees();
                        if(list.Count==0)
                        {
                            Console.WriteLine("No Employees Found.");
                        }
                        else
                        {
                            Console.WriteLine("\nEmployee Details:");
                            foreach (KeyValuePair<int, Employee> item in list)
                            {
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Employee ID :"+item.Value.EmployeeID);
                                Console.WriteLine("Employee Name :"+item.Value.EmployeeName);
                                Console.WriteLine("Salary : "+item.Value.Salary);
                            }
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}
