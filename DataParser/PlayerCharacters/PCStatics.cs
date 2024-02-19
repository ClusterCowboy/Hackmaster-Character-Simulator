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

        public enum Handedness
        {
            Right,
            Left,
            Ambidextrous
        }

        public enum SocialClass
        {
            Slave,
            LowerLowerClass,
            MiddleLowerClass,
            UpperLowerClass,
            LowerMiddleClass,
            MiddleMiddleClass,
            UpperMiddleClass,
            LowerUpperClass,
            MiddleUpperClass,
            UpperUpperClass
        }

        public int GetSocialClassModifierToInitialHonor(SocialClass social)
        {
            switch (social)
            {
                case SocialClass.Slave:
                case SocialClass.LowerLowerClass:
                    return -10;
                case SocialClass.MiddleLowerClass:
                    return -5;
                case SocialClass.UpperLowerClass:
                    return -1;
                case SocialClass.LowerUpperClass:
                    return 1;
                case SocialClass.MiddleUpperClass:
                    return 5;
                case SocialClass.UpperUpperClass:
                    return 10;
                default:
                    return 0;
            }
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
