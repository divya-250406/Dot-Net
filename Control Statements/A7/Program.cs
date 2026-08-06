using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Units place.");
        }
        else if ((num1 / 10) % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Tens place.");
        }
        else if ((num1 / 100) % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Hundreds place.");
        }
        else if ((num1 / 1000) % 10 == num2)
        {
            Console.WriteLine(num2 + " is in Thousands place.");
        }
        else
        {
            Console.WriteLine(num2 + " is not present in Units, Tens, Hundreds, or Thousands place.");
        }
    }
}
