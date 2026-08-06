using System;

class RandomHelper
{
    static Random random = new Random();

    public static int randint(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public static double randdouble(double min, double max)
    {
        return min + random.NextDouble() * (max - min);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Random Integer: " + RandomHelper.randint(1, 10));

        Console.WriteLine("Random Double: " + RandomHelper.randdouble(1, 10));
    }
}

