using System;
using System.Collections.Generic;

namespace AlphaDigitList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> AlphaList=new List<char>();
            List<char> DigitList=new List<char>();
            Console.Write("Enter a string: ");
            string input=Console.ReadLine();
            foreach(char ch in input)
            {
                if(char.IsLetter(ch))
                {
                    AlphaList.Add(ch);
                }
                else if(char.IsDigit(ch))
                {
                    DigitList.Add(ch);
                }
            }
            AlphaList.Sort();
            DigitList.Sort();
            Console.WriteLine("\nAlphabets in Sorted Order:");
            foreach(char c in AlphaList)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine("\n\nDigits in Sorted Order:");
            foreach(char c in DigitList)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
    }
}