using System;
using System.Reflection;
namespace ReflectionDemo
{
    class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public Movie()
        {
        }
        public Movie(int id,string name)
        {
            MovieId=id;
            MovieName=name;
        }
        public void DisplayMovie()
        {
            Console.WriteLine("Movie Details");
        }
        public void UpdateMovie(int id,string name)
        {
            MovieId=id;
            MovieName=name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly=Assembly.GetExecutingAssembly();
            Console.WriteLine("Assembly Name: "+assembly.GetName().Name);
            foreach (Module module in assembly.GetModules())
            {
                Console.WriteLine("\nModule Name: "+module.Name);
                foreach(Type type in module.GetTypes())
                {
                    Console.WriteLine("\nClass Name: "+type.Name);
                    Console.WriteLine("Constructors:");
                    foreach(ConstructorInfo constructor in type.GetConstructors())
                    {
                        Console.Write("  "+constructor.Name+"(");
                        ParameterInfo[] parameters=constructor.GetParameters();
                        for(int i=0;i<parameters.Length;i++)
                        {
                            Console.Write(parameters[i].ParameterType.Name+" "+parameters[i].Name);
                            if(i<parameters.Length-1)
                                Console.Write(", ");
                        }
                        Console.WriteLine(")");
                    }
                    Console.WriteLine("Properties:");
                    foreach(PropertyInfo property in type.GetProperties())
                    {
                        Console.WriteLine("  "+property.PropertyType.Name+" "+property.Name);
                    }
                    Console.WriteLine("Methods:");
                    foreach(MethodInfo method in type.GetMethods())
                    {
                        if(method.DeclaringType==type)
                        {
                            Console.Write("  "+method.Name+"(");
                            ParameterInfo[] parameters=method.GetParameters();
                            for(int i=0;i<parameters.Length;i++)
                            {
                                Console.Write(parameters[i].ParameterType.Name+" "+parameters[i].Name);
                                if (i<parameters.Length-1)
                                    Console.Write(", ");
                            }
                            Console.WriteLine(")");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
