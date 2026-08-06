using System;

class Program
{
    static void Main()
    {
        int num1, num2, temp;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nOriginal Values:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // 1. Pre-increment
        num2 = ++num1;
        Console.WriteLine("\nAfter Pre-Increment:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // Reset values
        Console.Write("\nEnter first number again: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number again: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // 2. Post-increment
        num2 = num1++;
        Console.WriteLine("\nAfter Post-Increment:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        // 3. Swap values
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
    }
}
