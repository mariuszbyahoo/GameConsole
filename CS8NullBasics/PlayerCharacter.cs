using System;
using System.Collections.Generic;
using System.Text;

namespace CS8NullBasics
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool? isNoob { get; set; }

        public PlayerCharacter(string name)
        {
            Name = name;
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }
    }
}
