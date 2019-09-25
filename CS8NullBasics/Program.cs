using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Using the Null-coalescing and Null-conditional Operators     */

    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message()
            {
                Text = "Hello there",
                From = null
            };

            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "No from"); // Using Null-Coalescing Operator
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
