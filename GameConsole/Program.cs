using System;
/* Accessing and Checking for Null Values: 
 * Using the Null-Conditional Operator
 * By J. Roberts Pluralsight*/
namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();

            //int days = player.DaysSinceLastLogin.Value; // throws InvalidOperationException()

            int days = player?.DaysSinceLastLogin ?? -1 ; /* This line will return a default value 
            (in this case: '-1') if the player reverence is set to null, or if the DaysSinceLastLogin
            member of this reference is set to null also. */
            
            //player.DaysSinceLastLogin = days;

            Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
