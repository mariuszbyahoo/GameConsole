using System;
/* Working with Nullable Value Types and Strings: 
 * Refactoring to Nullable<T> and Removing Magic Numbers
 * By J. Roberts Pluralsight*/
namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();

            player.Name = "Sarah";
            player.DaysSinceLastLogin = 42;
            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
