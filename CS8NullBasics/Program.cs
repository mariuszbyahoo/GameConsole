using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Specifying That a Reference Should Be Allowed to Be Null     */

    class Program
    {
        static void Main(string[] args)
        {
            string? message = null; /* This question mark Specifies
            That a Reference Should Be Allowed to Be Null */

            Console.WriteLine(message);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
