using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        // 1. Reverse
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("Reversed String : " + new string(arr));

        // 2. From 2nd position till end
        Console.WriteLine("Substring : " + str.Substring(1));

        // 3. Replace character
        Console.Write("Enter character to replace: ");
        char oldChar = Convert.ToChar(Console.ReadLine());

        string replaced = str.Replace(oldChar, '$');
        Console.WriteLine("New String : " + replaced);

        // 4. Copy string
        string str2 = str;

        Console.Write("Enter new value for second string: ");
        str2 = Console.ReadLine();

        Console.WriteLine("First String : " + str);
        Console.WriteLine("Second String : " + str2);
    }
}
