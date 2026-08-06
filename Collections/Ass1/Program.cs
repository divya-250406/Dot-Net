using System;
using System.Collections;

namespace EmployeeManagement
{
    class Employee
    {
        public string EmployeeName{ get; set; }
        public int EmployeeID{ get; set; }
        public double Salary{ get; set; }

        public Employee(string name,int id,double salary)
        {
            EmployeeName=name;
            EmployeeID=id;
            Salary=salary;
        }
    }
    class EmployeeDAL
    {
        ArrayList employees=new ArrayList();
        public bool AddEmployee(Employee e)
        {
            employees.Add(e);
            return true;
        }
        public bool DeleteEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeID==id)
                {
                    employees.Remove(emp);
                    return true;
                }
            }
            return false;
        }
        public string SearchEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeID==id)
                {
                    return emp.EmployeeName;
                }
            }
            return null;
        }
        public Employee[] GetAllEmployees()
        {
            Employee[] empArray=new Employee[employees.Count];

            for (int i = 0; i < employees.Count; i++)
            {
                empArray[i]=(Employee)employees[i];
            }
            return empArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL dal=new EmployeeDAL();
            while(true)
            {
                Console.WriteLine("\n----- Employee Management -----");
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
                        Employee emp=new Employee(name,id,salary);
                        if(dal.AddEmployee(emp))
                            Console.WriteLine("Employee Added Successfully.");
                        break;
                    case 2:
                        Console.Write("Enter Employee ID to Delete: ");
                        id=Convert.ToInt32(Console.ReadLine());
                        if (dal.DeleteEmployee(id))
                            Console.WriteLine("Employee Deleted Successfully.");
                        else
                            Console.WriteLine("Employee Not Found.");
                        break;
                    case 3:
                        Console.Write("Enter Employee ID to Search: ");
                        id=Convert.ToInt32(Console.ReadLine());
                        string empName=dal.SearchEmployee(id);
                        if (empName!=null)
                            Console.WriteLine("Employee Name: " + empName);
                        else
                            Console.WriteLine("Employee Not Found.");
                        break;
                    case 4:
                        Employee[] list=dal.GetAllEmployees();
                        if (list.Length==0)
                        {
                            Console.WriteLine("No Employees Found.");
                        }
                        else
                        {
                            Console.WriteLine("\nEmployee Details:");
                            foreach (Employee e in list)
                            {
                                Console.WriteLine("ID: "+e.EmployeeID);
                                Console.WriteLine("Name: "+e.EmployeeName);
                                Console.WriteLine("Salary: "+e.Salary);
                                Console.WriteLine("------------------------");
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
