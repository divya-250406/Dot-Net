using System;

class Person
{
    private string FirstName;
    private string LastName;
    private string EmailAddress;
    private DateTime DateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        FirstName=firstName;
        LastName=lastName;
        EmailAddress=email;
        DateOfBirth=dob;
    }
    public bool IsAdult
    {
        get
        {
            int age=DateTime.Now.Year - DateOfBirth.Year;
            if (DateOfBirth>DateTime.Now.AddYears(-age))
                age--;

            return age>=18;
        }
    }
    public string SunSign
    {
        get
        {
            int day=DateOfBirth.Day;
            int month=DateOfBirth.Month;

            if ((month==3 && day>=21) || (month==4 && day<=19))
                return "Aries";
            else if ((month==4 && day>=20) || (month==5 && day<=20))
                return "Taurus";
            else if ((month==5 && day>=21) || (month==6 && day<=20))
                return "Gemini";
            else if ((month==6 && day>=21) || (month==7 && day<=22))
                return "Cancer";
            else if ((month==7 && day>=23) || (month==8 && day<=22))
                return "Leo";
            else if ((month==8 && day>=23) || (month==9 && day<=22))
                return "Virgo";
            else if ((month==9 && day>=23) || (month==10 && day<=22))
                return "Libra";
            else if ((month==10 && day>=23) || (month==11 && day<=21))
                return "Scorpio";
            else if ((month==11 && day>=22) || (month==12 && day<=21))
                return "Sagittarius";
            else if ((month==12 && day>=22) || (month==1 && day<=19))
                return "Capricorn";
            else if ((month==1 && day>=20) || (month==2 && day<=18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }
    public bool IsBirthDay
    {
        get
        {
            return DateTime.Now.Day==DateOfBirth.Day && DateTime.Now.Month==DateOfBirth.Month;
        }
    }
    public string ScreenName
    {
        get
        {
            return FirstName.ToLower()+
                   LastName.ToLower()+
                   DateOfBirth.ToString("ddMMyy");
        }
    }
}

class Employee:Person
{
    public double Salary{ get; set; }

    public Employee(string firstName, string lastName, string email, DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary=salary;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string fname=Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lname=Console.ReadLine();

        Console.Write("Enter Email: ");
        string email=Console.ReadLine();

        Console.Write("Enter Date of Birth (dd/mm/yyyy): ");
        DateTime dob=Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Salary: ");
        double salary=Convert.ToDouble(Console.ReadLine());

        Employee emp=new Employee(fname, lname, email, dob, salary);

        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("------------------------");
        Console.WriteLine("Is Adult : " +emp.IsAdult);
        Console.WriteLine("Sun Sign : " +emp.SunSign);
        Console.WriteLine("Is Birthday : " +emp.IsBirthDay);
        Console.WriteLine("Screen Name : " +emp.ScreenName);
        Console.WriteLine("Salary : " +emp.Salary);
    }
}
