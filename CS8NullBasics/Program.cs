using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Enabling Non-nullable Reference Types for Specific Lines of Code     */

    class Program
    {
        static void Main(string[] args)
        {
#nullable enable
            string message = null; /* Surrounding this line with '#nullable' directives will 
            effectively turn this 'message' variable into a non-nullable reference type, whereas before,
            it was a nullable reference type.  In C#8 if we will set a nullable variable to a non nullable
            one we won't get errors, instead, we get warnings. */
#nullable disable
            Console.WriteLine(message);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
