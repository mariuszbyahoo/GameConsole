using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        /*String is a class, so it can points to a null value */
        public string Name { get; set; }
        /* DateTime and int are a struckts, ie; value type itself so they cannot 
         be set as a 'null' */
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool? isNoob { get; set; }

        public PlayerCharacter()
        {
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }
    }
}
