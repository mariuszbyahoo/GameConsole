using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter playerCharacter)
        {
            Console.WriteLine(playerCharacter.Name);
            if (playerCharacter.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(playerCharacter.DaysSinceLastLogin);
            }

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
