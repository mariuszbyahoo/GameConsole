using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter playerCharacter)
        {
            if (string.IsNullOrWhiteSpace(playerCharacter.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(playerCharacter.Name);
            }
            /* Below, a Null-Coalescing operator. Similar to Conditional Operator but it only stores the procedure to run
               If the referrence on the left hand of double question marks points to a null value.*/
            int days = playerCharacter.DaysSinceLastLogin ?? -1;

            // Conditional Operator -> Wyrażenie Warunkowe.
            //int days = playerCharacter.DaysSinceLastLogin.HasValue ? 
            //playerCharacter.DaysSinceLastLogin.Value : -1; 

            //int days = playerCharacter.DaysSinceLastLogin.GetValueOrDefault(); // 0


            Console.WriteLine($"{days} days since last login");

            /*if (playerCharacter.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(playerCharacter.DaysSinceLastLogin.Value);
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }*/

            if(playerCharacter.DateOfBirth == null)
            {
                Console.WriteLine("No date birth specified");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

            if(playerCharacter.isNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (playerCharacter.isNoob == true)
            {
                Console.WriteLine("Player is a noob");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
