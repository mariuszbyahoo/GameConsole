using System;

namespace CS8NullBasics
{/*
    Understanding Non-nullable Reference Types in C# 8: 
    Refactoring Existing Code to C# 8     */

    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter?[] players = new PlayerCharacter[4]
            {
                new PlayerCharacter("Sarah"),
                new PlayerCharacter ("Gentry"),
                new PlayerCharacter (null), // name will be default
                null
            };

            PlayerDisplayer.Write(players[0]);
            PlayerDisplayer.Write(players[1]);
            PlayerDisplayer.Write(players[2]);
            PlayerDisplayer.Write(players[3]);

            Console.ReadLine();
        }
    }
}
