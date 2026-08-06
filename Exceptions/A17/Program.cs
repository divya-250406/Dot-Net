using System;
using System.Text.RegularExpressions;

class NegativeNumberException:Exception
{
    public NegativeNumberException(string message):base(message)
    {
    }
}
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person(string firstName,string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name should not be empty.");
        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name should not be empty.");
        if (!Regex.IsMatch(firstName, "^[A-Za-z]+$"))
            throw new Exception("First Name should contain only alphabets.");
        if (!Regex.IsMatch(lastName, "^[A-Za-z]+$"))
            throw new Exception("Last Name should contain only alphabets.");
        FirstName=firstName;
        LastName=lastName;
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter First Name: ");
            string firstName=Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName=Console.ReadLine();
            Person p=new Person(firstName,lastName);
            Console.Write("Enter Subject 1 Marks: ");
            int m1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Subject 2 Marks: ");
            int m2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Subject 3 Marks: ");
            int m3=Convert.ToInt32(Console.ReadLine());
            if (m1<0 || m2<0 || m3<0)
                throw new NegativeNumberException("Marks cannot be less than zero.");
            Console.WriteLine();
            Console.WriteLine("Student Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Name : " + p.FirstName + " " +p.LastName);
            Console.WriteLine("Subject 1: " +m1);
            Console.WriteLine("Subject 2: " +m2);
            Console.WriteLine("Subject 3: " +m3);
            double average=(m1+m2+m3)/3.0;
            Console.WriteLine("Average Marks: " + average);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input! Please enter integer values for marks.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}
