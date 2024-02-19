using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    public class Intelligence : AbilityScore
    {
        public Intelligence(int Score, int Fractional, int RacialMax, int RacialMin)
        {
            Ability = Score;
            AbilityFractional = Fractional;
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
        }

        /// <summary>
        /// First time roll, generate values
        /// </summary>
        /// <param name="RacialMax"></param>
        /// <param name="RacialMin"></param>
        public Intelligence(int RacialMax, int RacialMin)
        {
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
            GenerateStartingValues();
        }

        public int GetMaxNumberOfLanguages()
        {
            if (Ability <= 1) return 0;
            else if (Ability <= 8) return 1;
            else if (Ability <= 11) return 2;
            else if (Ability <= 13) return 3;
            else if (Ability <= 15) return 4;
            else if (Ability <= 16) return 5;
            else if (Ability <= 17) return 6;
            else if (Ability <= 18) return 7;
            else if (Ability <= 19) return 8;
            else if (Ability <= 20) return 9;
            else if (Ability <= 21) return 10;
            else if (Ability <= 22) return 11;
            else if (Ability <= 23) return 12;
            else if (Ability <= 24) return 15;
            else return 20;
        }

        public int GetMaxSpellLevel()
        {
            if (Ability <= 7) return -1;
            else if (Ability <= 8) return 0;
            else if (Ability <= 9) return 4;
            else if (Ability <= 11) return 5;
            else if (Ability <= 13) return 6;
            else if (Ability <= 15) return 7;
            else if (Ability <= 17) return 8;
            else return 9;
        }

        public int GetLearningAbility()
        {
            if (Ability <= 1) return 1;
            else if (Ability <= 2) return 5;
            else if (Ability <= 3) return 10;
            else if (Ability <= 4) return 15;
            else if (Ability <= 5) return 20;
            else if (Ability <= 6) return 25;
            else if (Ability <= 7) return 30;
            else if (Ability <= 9) return 35;
            else if (Ability <= 10) return 40;
            else if (Ability <= 11) return 45;
            else if (Ability <= 12) return 50;
            else if (Ability <= 13) return 55;
            else if (Ability <= 14) return 60;
            else if (Ability <= 15) return 65;
            else if (Ability <= 16) return 70;
            else if (Ability <= 17) return 75;
            else if (Ability <= 18 && AbilityFractional < 51) return 85;
            else if (Ability <= 18 && AbilityFractional > 50) return 90;
            else if (Ability <= 19) return 95;
            else if (Ability <= 20) return 96;
            else if (Ability <= 21) return 97;
            else if (Ability <= 22) return 98;
            else if (Ability <= 23) return 99;
            else return 100;
        }
        
        public int GetMaxNumSpellsPerLevel()
        {
            if (Ability <= 7) return 0;
            else if (Ability <= 8) return 5;
            else if (Ability <= 9) return 6;
            else if (Ability <= 12) return 7;
            else if (Ability <= 14) return 9;
            else if (Ability <= 16) return 11;
            else if (Ability <= 17) return 14;
            else if (Ability <= 18 && AbilityFractional < 51) return 18;
            else if (Ability <= 18 && AbilityFractional > 50) return 20;
            else return 999;
        }

        public int GetIllusionImmunity()
        {
            if (Ability <= 17) return -1;
            else if (Ability <= 18) return 0;
            else if (Ability <= 19) return 1;
            else if (Ability <= 20) return 2;
            else if (Ability <= 21) return 3;
            else if (Ability <= 22) return 4;
            else if (Ability <= 23) return 5;
            else if (Ability <= 24) return 6;
            else return 7;
        }

        public int GetBaseChanceOfSpellMishap()
        {
            if (Ability <= 7) return 0;
            else if (Ability <= 8) return 35;
            else if (Ability <= 9) return 20;
            else if (Ability <= 10) return 15;
            else if (Ability <= 11) return 10;
            else if (Ability <= 12) return 5;
            else return 0;
        }
    }
}
