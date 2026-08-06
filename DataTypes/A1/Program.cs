using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the side of the square: ");
        int side=Convert.ToInt32(Console.ReadLine());
        int area=side*side;
        Console.WriteLine("Area of the square="+area);
    }
}
