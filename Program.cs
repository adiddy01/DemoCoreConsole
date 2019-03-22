using System;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, this is the experimental branch. Experiences may vary.");
            Student c = new Student();
            c.Name = "Joe Smith";
            c.Id = 4;
            Console.WriteLine(c.Name);
        }
    }
}
