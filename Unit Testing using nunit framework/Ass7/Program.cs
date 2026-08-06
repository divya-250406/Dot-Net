using System;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=====Calculator=====");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice: ");
                int choice=Convert.ToInt32(Console.ReadLine());
                if(choice==5)
                {
                    Console.WriteLine("Thank You!");
                    break;
                }
                Console.Write("Enter First Number: ");
                double num1=Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                double num2=Convert.ToDouble(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Result= "+(num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("Result= "+(num1-num2));
                        break;
                    case 3:
                        Console.WriteLine("Result= "+(num1*num2));
                        break;
                    case 4:
                        if (num2!=0)
                            Console.WriteLine("Result= "+(num1/num2));
                        else
                            Console.WriteLine("Division by zero is not allowed.");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
