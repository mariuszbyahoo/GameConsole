using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Writing Some Simple Null Code
     */

    class Program
    {
        static void Main(string[] args)
        {
            string message = null;

            Console.WriteLine(message);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
