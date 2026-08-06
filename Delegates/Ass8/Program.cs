using System;

namespace DelegateAssignment
{
    delegate void MathDelegate(int a,int b);
    class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition= "+(a+b));
        }
        public void Subtract(int a,int b)
        {
            Console.WriteLine("Subtraction= "+(a-b));
        }
        public void Multiply(int a,int b)
        {
            Console.WriteLine("Multiplication= "+(a*b));
        }
        public void Divide(int a,int b)
        {
            if (b!=0)
                Console.WriteLine("Division= "+(a/b));
            else
                Console.WriteLine("Cannot divide by zero.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c=new Calculator();
            Console.Write("Enter First Number: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice: ");
            int choice=Convert.ToInt32(Console.ReadLine());
            MathDelegate md;
            switch(choice)
            {
                case 1:
                    md=c.Add;
                    md(num1,num2);
                    break;
                case 2:
                    md=c.Subtract;
                    md(num1,num2);
                    break;
                case 3:
                    md=c.Multiply;
                    md(num1,num2);
                    break;
                case 4:
                    md=c.Divide;
                    md(num1,num2);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
