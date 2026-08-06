using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int i, j, temp;

        Console.WriteLine("Enter 10 integers:");

        for (i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find Min, Max and Sum
        int min = arr[0];
        int max = arr[0];
        int sum = 0;

        for (i = 0; i < 10; i++)
        {
            if (arr[i] < min)
                min = arr[i];

            if (arr[i] > max)
                max = arr[i];

            sum = sum + arr[i];
        }

        // Sort in Descending Order (Bubble Sort)
        for (i = 0; i < 9; i++)
        {
            for (j = 0; j < 9 - i; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nArray in Descending Order:");
        for (i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\n\nMinimum Value = " + min);
        Console.WriteLine("Maximum Value = " + max);
        Console.WriteLine("Sum = " + sum);
    }
}
