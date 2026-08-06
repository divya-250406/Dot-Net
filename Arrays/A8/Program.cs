using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        int count = 0;

        foreach (int i in arr)
        {
            count++;
        }

        Console.WriteLine("Number of elements in the array = " + count);
    }
}
