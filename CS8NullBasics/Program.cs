
#nullable enable // This directive is make the whole file of code a "Non-nullable"

using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Enabling Non-nullable Reference Types for an Entire file of Code     */

    class Program
    {
        static void Main(string[] args)
        {
#nullable disable
            string message = null; // We can opt out the specific lines of code by theese two directives
#nullable enable
            Console.WriteLine(message);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
