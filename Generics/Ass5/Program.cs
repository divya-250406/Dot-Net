using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeCSV
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public string DepartmentName { get; set; }
        public Employee(int id,string name,string designation,DateTime joiningDate,string department)
        {
            EmployeeID=id;
            EmployeeName=name;
            Designation=designation;
            JoiningDate=joiningDate;
            DepartmentName=department;
        }
    }
    class EmployeeData
    {
        public List<Employee> EmployeeInfo { get; set; }
        public EmployeeData()
        {
            EmployeeInfo=new List<Employee>();
        }
        public void AddEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter Designation: ");
            string designation=Console.ReadLine();
            Console.Write("Enter Joining Date (dd-MM-yyyy): ");
            DateTime joiningDate=DateTime.ParseExact(
                Console.ReadLine(),
                "dd-MM-yyyy",
                null);
            Console.Write("Enter Department Name: ");
            string department=Console.ReadLine();
            Employee emp=new Employee(
                id,
                name,
                designation,
                joiningDate,
                department);
            EmployeeInfo.Add(emp);
            SaveToCSV(emp);
            Console.WriteLine("\nEmployee Added Successfully.");
        }
        public void SaveToCSV(Employee emp)
        {
            string path="EmployeeData.csv";
            using(StreamWriter sw=new StreamWriter(path, true))
            {
                sw.WriteLine(
                    emp.EmployeeID + "," +
                    emp.EmployeeName + "," +
                    emp.Designation + "," +
                    emp.JoiningDate.ToString("dd-MM-yyyy") + "," +
                    emp.DepartmentName);
            }
        }
        public void DisplayEmployees()
        {
            if(EmployeeInfo.Count==0)
            {
                Console.WriteLine("No Employees Available.");
                return;
            }
            Console.WriteLine("\nEmployee Details\n");
            foreach(Employee emp in EmployeeInfo)
            {
                Console.WriteLine("Employee ID: "+emp.EmployeeID);
                Console.WriteLine("Employee Name: "+emp.EmployeeName);
                Console.WriteLine("Designation: "+emp.Designation);
                Console.WriteLine("Joining Date: "+emp.JoiningDate.ToString("dd-MM-yyyy"));
                Console.WriteLine("Department Name: "+emp.DepartmentName);
                Console.WriteLine("----------------------------------------");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeData data=new EmployeeData();
            while(true)
            {
                Console.WriteLine("\n========== Employee Management ==========");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Display Employees");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice: ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        data.AddEmployee();
                        break;
                    case 2:
                        data.DisplayEmployees();
                        break;
                    case 3:
                        Console.WriteLine("Thank You!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}