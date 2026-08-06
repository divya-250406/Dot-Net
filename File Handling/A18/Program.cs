using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath="StudentDetails.txt";
        Console.Write("Enter Student Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Roll Number: ");
        string rollNo=Console.ReadLine();
        Console.Write("Enter Department: ");
        string department=Console.ReadLine();
        StreamWriter writer=new StreamWriter(filePath);
        writer.WriteLine("Student Details");
        writer.WriteLine("----------------------");
        writer.WriteLine("Name: "+name);
        writer.WriteLine("Roll No: "+rollNo);
        writer.WriteLine("Department: "+department);
        writer.Close();
        Console.WriteLine();
        Console.WriteLine("File created successfully.");
        Console.WriteLine("Data has been written, saved and the file is closed.");
    }
}
