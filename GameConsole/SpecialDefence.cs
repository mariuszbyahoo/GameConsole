using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public abstract class SpecialDefence
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefence Null { get; } = new NullDefence();

        // Below a private, nested class
        private class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // No operation <- This is a "Do nothing" Operator
            }
        }
    }
}
