using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        FirstName=firstName;
        LastName=lastName;
        EmailAddress=email;
        DateOfBirth=dob;
    }
    public virtual void Display()
    {
        Console.WriteLine("First Name : "+FirstName);
        Console.WriteLine("Last Name  : "+LastName);
        Console.WriteLine("Email      : "+EmailAddress);
        Console.WriteLine("Date of Birth : "+DateOfBirth.ToShortDateString());
    }
}
interface IPayable
{
    void CalculatePay();
}
class HourlyEmployee : Person, IPayable
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }
    public double TotalPay { get; set; }
    public HourlyEmployee(string firstName, string lastName, string email,
        DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked=hoursWorked;
        PayPerHour=payPerHour;
    }
    public void CalculatePay()
    {
        TotalPay=HoursWorked*PayPerHour;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Hours Worked : " +HoursWorked);
        Console.WriteLine("Pay Per Hour : " +PayPerHour);
        Console.WriteLine("Total Pay    : " +TotalPay);
    }
}
class PermanentEmployee:Person,IPayable
{
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }
    public double TotalPay { get; set; }
    public PermanentEmployee(string firstName,string lastName,string email,
        DateTime dob, double basicSalary)
        : base(firstName, lastName, email, dob)
    {
        BasicSalary=basicSalary;
    }
    public void CalculatePay()
    {
        HRA=BasicSalary*0.15;
        DA=BasicSalary*0.10;
        TotalPay=BasicSalary+HRA+DA;
        Tax=TotalPay*0.08;
        NetPay=TotalPay-Tax;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Basic Salary : " +BasicSalary);
        Console.WriteLine("HRA          : " +HRA);
        Console.WriteLine("DA           : " +DA);
        Console.WriteLine("Total Pay    : " +TotalPay);
        Console.WriteLine("Tax          : " +Tax);
        Console.WriteLine("Net Pay      : " +NetPay);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Hourly Employee =====");

        HourlyEmployee h=new HourlyEmployee(
            "Divya",
            "Nagavalli",
            "divya@gmail.com",
            new DateTime(2004, 5, 20),
            40,
            500);
        h.CalculatePay();
        h.Display();
        Console.WriteLine();
        Console.WriteLine("===== Permanent Employee =====");
        PermanentEmployee p=new PermanentEmployee(
            "Rahul",
            "Kumar",
            "rahul@gmail.com",
            new DateTime(2000, 8, 15),
            50000);
        p.CalculatePay();
        p.Display();
    }
}