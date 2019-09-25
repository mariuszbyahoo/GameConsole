using System;
/* Working with Nullable Value Types and Strings: 
 * Using the Confitional Operator to Check for Nulls
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

            /*player.DaysSinceLastLogin = 42; <- Uncommenting this line will result in assigning the 
              value 42 to the player.DaysSinceLastLogin member*/

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
