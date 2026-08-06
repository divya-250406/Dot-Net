using System;

class Program
{
    static void Main()
    {
        string username = "admin";
        string password = "1234";

        string user, pass;
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter Username: ");
            user = Console.ReadLine();

            Console.Write("Enter Password: ");
            pass = Console.ReadLine();

            if (user == username && pass == password)
            {
                Console.WriteLine("Login Successful");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid Username or Password");

                if (attempts == 3)
                {
                    Console.WriteLine("You are Rejected");
                }
                else
                {
                    Console.WriteLine("Attempts Left: " + (3 - attempts));
                }
            }
        }
    }
}
