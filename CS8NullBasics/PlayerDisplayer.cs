using System;
using System.Collections.Generic;
using System.Text;

namespace CS8NullBasics
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter? playerCharacter)
        {
            if (string.IsNullOrWhiteSpace(playerCharacter.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(playerCharacter.Name);
            }

            int days = playerCharacter.DaysSinceLastLogin ?? -1;

            Console.WriteLine($"{days} days since last login");

            if (playerCharacter.DateOfBirth == null)
            {
                Console.WriteLine("No date birth specified");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

            if (playerCharacter.isNoob == null)
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
