using System;
/* Eliminating the null Reference Exception: 
 * Refactoring to a Base Class and Single Null Instance
 * By J. Roberts Pluralsight*/
namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);
        }
    }
}
