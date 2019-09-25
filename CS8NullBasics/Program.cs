using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Using the Null-forgiving Operator to Override the Compiler     */

    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message()
            {
                Text = null!, // Using the Null-Forgiving operator, in this case it effects the runtime.
                From = null
            };

            MessagePopulator.Populate(message);

            Console.WriteLine(message.Text);
            Console.WriteLine(message.From);
            Console.WriteLine(message.From!.Length); /* Using the Null-Forgiving Operator effects
            only the compile time, it won't automatically go and add null reference checks into the 
            compiled program. 
            If we will comment the Populate() line will make the program generate a NullReferenceException
            at a runtime. */

            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
