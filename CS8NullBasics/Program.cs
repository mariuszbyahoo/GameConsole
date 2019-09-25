using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Working with Nullable and Non-nullable Properties     */

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
            Console.WriteLine(message.From);
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
