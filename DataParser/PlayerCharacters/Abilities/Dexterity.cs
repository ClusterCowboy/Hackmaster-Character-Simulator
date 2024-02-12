using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    internal class Dexterity : AbilityScore
    {
        public Dexterity(int Score, int Fractional, int RacialMax, int RacialMin)
        {
            Ability = Score;
            AbilityFractional = Fractional;
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
        }

        public int GetDefenseAdjustment()
        {
            if (Ability <= 1) return 5;
            else if (Ability <= 2) return 4;
            else if (Ability <= 3 && AbilityFractional < 51) return 4;
            else if (Ability <= 3 && AbilityFractional > 50) return 3;
            else if (Ability <= 4) return 3;
            else if (Ability <= 5) return 2;
            else if (Ability <= 6 && AbilityFractional < 51) return 2;
            else if (Ability <= 6 && AbilityFractional > 50) return 1;
            else if (Ability <= 7) return 1;
            else if (Ability <= 12) return 0;
            else if (Ability <= 13 && AbilityFractional < 51) return 0;
            else if (Ability <= 13 && AbilityFractional > 50) return -1;
            else if (Ability <= 14) return -1;
            else if (Ability <= 15) return -2;
            else if (Ability <= 16 && AbilityFractional < 51) return -2;
            else if (Ability <= 16 && AbilityFractional > 50) return -3;
            else if (Ability <= 17) return -3;
            else if (Ability <= 18) return -4;
            else if (Ability <= 19 && AbilityFractional < 51) return -4;
            else if (Ability <= 19 && AbilityFractional > 50) return -5;
            else if (Ability <= 20) return -5;
            else if (Ability <= 21) return -6;
            else if (Ability <= 22 && AbilityFractional < 51) return -6;
            else if (Ability <= 22 && AbilityFractional > 50) return -7;
            else if (Ability <= 23) return -7;
            else return -8;
        }

        /***
         * Modifies the die roll for initiatieve to see how quickly the character
         * reacts, or if the character is surprised. The more positive the value,
         * the harder it is to surprise the character
         * */
        public int GetReactionAdjustment()
        {
            if (Ability <= 1 && AbilityFractional < 51) return -5;
            else if (Ability <= 1 && AbilityFractional > 50) return -5;
            else if (Ability <= 2 && AbilityFractional < 51) return -5;
            else if (Ability <= 2 && AbilityFractional > 50) return -4;
            else if (Ability <= 3 && AbilityFractional < 51) return -4;
            else if (Ability <= 3 && AbilityFractional > 50) return -4;
            else if (Ability <= 4 && AbilityFractional < 51) return -3;
            else if (Ability <= 4 && AbilityFractional > 50) return -3;
            else if (Ability <= 5 && AbilityFractional < 51) return -3;
            else if (Ability <= 5 && AbilityFractional > 50) return -2;
            else if (Ability <= 6 && AbilityFractional < 51) return -2;
            else if (Ability <= 6 && AbilityFractional > 50) return -2;
            else if (Ability <= 7 && AbilityFractional < 51) return -1;
            else if (Ability <= 7 && AbilityFractional > 50) return -1;
            else if (Ability <= 8 && AbilityFractional < 51) return -1;
            else if (Ability <= 8 && AbilityFractional > 50) return 0;
            else if (Ability <= 9 && AbilityFractional < 51) return 0;
            else if (Ability <= 9 && AbilityFractional > 50) return 0;
            else if (Ability <= 10 && AbilityFractional < 51) return 0;
            else if (Ability <= 10 && AbilityFractional > 50) return 0;
            else if (Ability <= 11 && AbilityFractional < 51) return 0;
            else if (Ability <= 11 && AbilityFractional > 50) return 0;
            else if (Ability <= 12 && AbilityFractional < 51) return 0;
            else if (Ability <= 12 && AbilityFractional > 50) return 0;
            else if (Ability <= 13 && AbilityFractional < 51) return 1;
            else if (Ability <= 13 && AbilityFractional > 50) return 1;
            else if (Ability <= 14 && AbilityFractional < 51) return 1;
            else if (Ability <= 14 && AbilityFractional > 50) return 2;
            else if (Ability <= 15 && AbilityFractional < 51) return 2;
            else if (Ability <= 15 && AbilityFractional > 50) return 2;
            else if (Ability <= 16 && AbilityFractional < 51) return 3;
            else if (Ability <= 16 && AbilityFractional > 50) return 3;
            else if (Ability <= 17 && AbilityFractional < 51) return 3;
            else if (Ability <= 17 && AbilityFractional > 50) return 4;
            else if (Ability <= 18 && AbilityFractional < 51) return 4;
            else if (Ability <= 18 && AbilityFractional > 50) return 4;
            else if (Ability <= 19 && AbilityFractional < 51) return 5;
            else if (Ability <= 19 && AbilityFractional > 50) return 5;
            else if (Ability <= 20 && AbilityFractional < 51) return 5;
            else if (Ability <= 20 && AbilityFractional > 50) return 6;
            else if (Ability <= 21 && AbilityFractional < 51) return 6;
            else if (Ability <= 21 && AbilityFractional > 50) return 6;
            else if (Ability <= 22 && AbilityFractional < 51) return 7;
            else if (Ability <= 22 && AbilityFractional > 50) return 7;
            else if (Ability <= 23 && AbilityFractional < 51) return 7;
            else if (Ability <= 23 && AbilityFractional > 50) return 8;
            else if (Ability <= 24 && AbilityFractional < 51) return 8;
            else if (Ability <= 24 && AbilityFractional > 50) return 8;
            else return 9;
        }

        /***
         * Ranged Attack Bonus
         * */
        public int GetMissileAdjustment()
        {
            if (Ability <= 1 && AbilityFractional < 51) return -6;
            else if (Ability <= 1 && AbilityFractional > 50) return -5;
            else if (Ability <= 2 && AbilityFractional < 51) return -5;
            else if (Ability <= 2 && AbilityFractional > 50) return -5;
            else if (Ability <= 3 && AbilityFractional < 51) return -4;
            else if (Ability <= 3 && AbilityFractional > 50) return -4;
            else if (Ability <= 4 && AbilityFractional < 51) return -4;
            else if (Ability <= 4 && AbilityFractional > 50) return -3;
            else if (Ability <= 5 && AbilityFractional < 51) return -3;
            else if (Ability <= 5 && AbilityFractional > 50) return -3;
            else if (Ability <= 6 && AbilityFractional < 51) return -2;
            else if (Ability <= 6 && AbilityFractional > 50) return -2;
            else if (Ability <= 7 && AbilityFractional < 51) return -2;
            else if (Ability <= 7 && AbilityFractional > 50) return -1;
            else if (Ability <= 8 && AbilityFractional < 51) return -1;
            else if (Ability <= 8 && AbilityFractional > 50) return 1;
            else if (Ability <= 9 && AbilityFractional < 51) return 0;
            else if (Ability <= 9 && AbilityFractional > 50) return 0;
            else if (Ability <= 10 && AbilityFractional < 51) return 0;
            else if (Ability <= 10 && AbilityFractional > 50) return 0;
            else if (Ability <= 11 && AbilityFractional < 51) return 0;
            else if (Ability <= 11 && AbilityFractional > 50) return 0;
            else if (Ability <= 12 && AbilityFractional < 51) return 0;
            else if (Ability <= 12 && AbilityFractional > 50) return 1;
            else if (Ability <= 13 && AbilityFractional < 51) return 1;
            else if (Ability <= 13 && AbilityFractional > 50) return 1;
            else if (Ability <= 14 && AbilityFractional < 51) return 2;
            else if (Ability <= 14 && AbilityFractional > 50) return 2;
            else if (Ability <= 15 && AbilityFractional < 51) return 2;
            else if (Ability <= 15 && AbilityFractional > 50) return 3;
            else if (Ability <= 16 && AbilityFractional < 51) return 3;
            else if (Ability <= 16 && AbilityFractional > 50) return 3;
            else if (Ability <= 17 && AbilityFractional < 51) return 4;
            else if (Ability <= 17 && AbilityFractional > 50) return 4;
            else if (Ability <= 18 && AbilityFractional < 51) return 4;
            else if (Ability <= 18 && AbilityFractional > 50) return 5;
            else if (Ability <= 19 && AbilityFractional < 51) return 5;
            else if (Ability <= 19 && AbilityFractional > 50) return 5;
            else if (Ability <= 20 && AbilityFractional < 51) return 6;
            else if (Ability <= 20 && AbilityFractional > 50) return 6;
            else if (Ability <= 21 && AbilityFractional < 51) return 6;
            else if (Ability <= 21 && AbilityFractional > 50) return 7;
            else if (Ability <= 22 && AbilityFractional < 51) return 7;
            else if (Ability <= 22 && AbilityFractional > 50) return 7;
            else if (Ability <= 23 && AbilityFractional < 51) return 8;
            else if (Ability <= 23 && AbilityFractional > 50) return 8;
            else if (Ability <= 24 && AbilityFractional < 51) return 8;
            else if (Ability <= 24 && AbilityFractional > 50) return 9;
            else return 9;
        }
    }
}
