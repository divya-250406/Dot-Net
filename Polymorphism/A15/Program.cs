using System;

class Area
{
    public double CalculateArea(double radius)
    {
        return 3.14*radius*radius;
    }
    public double CalculateArea(double length,double breadth)
    {
        return length*breadth;
    }
    public double CalculateArea(double b,double h,bool triangle)
    {
        return 0.5*b*h;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Area obj=new Area();
        Console.Write("Enter Radius of Circle: ");
        double radius=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Length of Rectangle: ");
        double length=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Breadth of Rectangle: ");
        double breadth=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Base of Triangle: ");
        double baseValue=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Height of Triangle: ");
        double height=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Area of Circle= " +obj.CalculateArea(radius));
        Console.WriteLine("Area of Rectangle= " +obj.CalculateArea(length, breadth));
        Console.WriteLine("Area of Triangle= " +obj.CalculateArea(baseValue, height, true));
    }
}
