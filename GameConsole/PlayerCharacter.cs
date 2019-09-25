using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;
        public string Name { get; set; }

        public int Health { get; set; } = 100;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public void Hit(int damage)
        {
            //int damageReduction = 0;
            //// Below is the most crucial code for us now:
            //if (_specialDefence != null)
            //{
            //    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //}

            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}
