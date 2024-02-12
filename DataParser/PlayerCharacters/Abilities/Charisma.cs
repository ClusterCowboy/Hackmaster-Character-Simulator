using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    public class Charisma : AbilityScore
    {
        public Charisma(int Score, int Fractional, int RacialMax, int RacialMin)
        {
            Ability = Score;
            AbilityFractional = Fractional;
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
        }

        public int MaxNumHenchmenChroniesSidekicks()
        {
            if (Ability <= 1) return 0;
            else if (Ability <= 4) return 1;
            else if (Ability <= 6) return 2;
            else if (Ability <= 8) return 3;
            else if (Ability <= 11) return 4;
            else if (Ability <= 13) return 5;
            else if (Ability <= 14) return 6;
            else if (Ability <= 15) return 7;
            else if (Ability <= 16) return 8;
            else if (Ability <= 17) return 10;
            else if (Ability <= 18) return 15;
            else if (Ability <= 19) return 18;
            else if (Ability <= 20) return 20;
            else if (Ability <= 21) return 25;
            else if (Ability <= 22) return 30;
            else if (Ability <= 23) return 35;
            else if (Ability <= 24) return 40;
            else return 45;
        }
        
        public int GetLoyaltyBase()
        {
            if (Ability <= 1) return -8;
            else if (Ability <= 2) return -7;
            else if (Ability <= 3) return -6;
            else if (Ability <= 4) return -5;
            else if (Ability <= 5) return -4;
            else if (Ability <= 6) return -3;
            else if (Ability <= 7) return -2;
            else if (Ability <= 8) return -1;
            else if (Ability <= 13) return 0;
            else if (Ability <= 14) return 1;
            else if (Ability <= 15) return 3;
            else if (Ability <= 16) return 4;
            else if (Ability <= 17) return 6;
            else if (Ability <= 18) return 8;
            else if (Ability <= 19) return 10;
            else if (Ability <= 20) return 12;
            else if (Ability <= 21) return 14;
            else if (Ability <= 22) return 16;
            else if (Ability <= 23) return 18;
            else return 20;
        }

        public int GetSocialReactionAdjustment()
        {
            if (Ability <= 1) return -7;
            else if (Ability <= 2) return -6;
            else if (Ability <= 3) return -5;
            else if (Ability <= 4) return -4;
            else if (Ability <= 5) return -3;
            else if (Ability <= 6) return -2;
            else if (Ability <= 7) return -1;
            else if (Ability <= 12) return 0;
            else if (Ability <= 13) return 1;
            else if (Ability <= 14) return 2;
            else if (Ability <= 15) return 3;
            else if (Ability <= 16) return 5;
            else if (Ability <= 17) return 6;
            else if (Ability <= 18) return 7;
            else if (Ability <= 19) return 8;
            else if (Ability <= 20) return 9;
            else if (Ability <= 21) return 10;
            else if (Ability <= 22) return 11;
            else if (Ability <= 23) return 12;
            else if (Ability <= 24) return 13;
            else return 14;
        }

        public int GetComelinessModifier()
        {
            if (Ability <= 2) return -8;
            else if (Ability <= 3) return -5;
            else if (Ability <= 5) return -3;
            else if (Ability <= 8) return -1;
            else if (Ability <= 12) return 0;
            else if (Ability <= 15) return 1;
            else if (Ability <= 17) return 2;
            else if (Ability <= 18) return 3;
            else if (Ability <= 20) return 4;
            else if (Ability <= 22) return 5;
            else if (Ability <= 23) return 6;
            else if (Ability <= 24) return 7;
            else return 8;
        }

        public int GetStartingHonorModifier()
        {
            if (Ability <= 1) return -9;
            else if (Ability <= 2) return -8;
            else if (Ability <= 3) return -7;
            else if (Ability <= 4) return -6;
            else if (Ability <= 5) return -5;
            else if (Ability <= 6) return -4;
            else if (Ability <= 7) return -3;
            else if (Ability <= 8) return -2;
            else if (Ability <= 9) return -1;
            else if (Ability <= 11) return 0;
            else if (Ability <= 12) return 1;
            else if (Ability <= 13) return 2;
            else if (Ability <= 14) return 3;
            else if (Ability <= 15) return 4;
            else if (Ability <= 16) return 5;
            else if (Ability <= 17) return 6;
            else if (Ability <= 18) return 7;
            else if (Ability <= 19) return 8;
            else if (Ability <= 20) return 9;
            else if (Ability <= 21) return 10;
            else if (Ability <= 22) return 11;
            else if (Ability <= 23) return 12;
            else if (Ability <= 24) return 13;
            else return 14;
        }
    }
}
