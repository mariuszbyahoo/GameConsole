using System;
/* Working with Nullable Value Types and Strings: 
 * Using the Null-Coalescing Operator
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

            //player.DaysSinceLastLogin = 42;// <- Uncommenting this line will result in assigning the value to a nullable property
            

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
