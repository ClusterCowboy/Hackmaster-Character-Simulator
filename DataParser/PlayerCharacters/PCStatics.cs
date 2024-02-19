using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters
{
    public class PCStatics
    {
        public enum WeightStatus
        {
            Unencumbered = 0,
            Light,
            Moderate,
            HeavyLaden,
            Severe,
            Overloaded
        }

        public enum ClassList
        {
            Cleric,
            Druid,
            Fighter,
            Barbarian,
            Berserker,
            Cavalier,
            DarkKnight,
            KnightErrant,
            Paladin,
            Ranger,
            MagicUser,
            BattleMage,
            Illusionist,
            Thief,
            Assassin,
            Bard
        }
    }
}
