using System;
/* Working with Nullable Value Types and Strings: 
 * Using the HasValue and Value Properties
 * By J. Roberts Pluralsight*/
namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();

            player.Name = ""; /* "   ", null <- every of theese three values are
            returning true for the IsNullOrWhiteSpace() method            */
            //player.DaysSinceLastLogin = 42;
            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
