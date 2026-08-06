using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int alphabets = 0;
        int digits = 0;

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
                alphabets++;
            else if (char.IsDigit(ch))
                digits++;
        }

        Console.WriteLine("Number of alphabets = " + alphabets);
        Console.WriteLine("Number of digits = " + digits);
    }
}
