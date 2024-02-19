using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    public class Constitution : AbilityScore
    {
        public Constitution(int Score, int Fractional, int RacialMax, int RacialMin)
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
        public Constitution(int RacialMax, int RacialMin)
        {
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
            GenerateStartingValues();
        }

        /***
         * Insert Hit point roll, get total Hit points
         * */
        public int AddHitPointAdjustment(int hpRoll)
        {
            int totalHp = hpRoll;
            // Extraordinary Constitution means minimum die rolls
            if (hpRoll == 1 && Ability == 20) { hpRoll = 2;  }
            else if (hpRoll <= 2 && (Ability == 21 || Ability == 22)) { hpRoll = 3; }
            else if (hpRoll <= 3 && Ability >= 23) { hpRoll = 4; }


            if (Ability <= 1) hpRoll += -5;
            else if (Ability <= 2) hpRoll += -4;
            else if (Ability <= 3) hpRoll += -4;
            else if (Ability <= 4) hpRoll += -3;
            else if (Ability <= 5) hpRoll += -3;
            else if (Ability <= 6) hpRoll += -2;
            else if (Ability <= 7) hpRoll += -2;
            else if (Ability <= 8) hpRoll += -1;
            else if (Ability <= 9) hpRoll += -1;
            else if (Ability <= 10) hpRoll += 0;
            else if (Ability <= 11) hpRoll += 0;
            else if (Ability <= 12) hpRoll += 1;
            else if (Ability <= 13) hpRoll += 1;
            else if (Ability <= 14) hpRoll += 2;
            else if (Ability <= 15) hpRoll += 2;
            else if (Ability <= 16) hpRoll += 3;
            else if (Ability <= 17) hpRoll += 3;
            else if (Ability <= 18) hpRoll += 4;
            else if (Ability <= 19) hpRoll += 4;
            else if (Ability <= 20) hpRoll += 5;
            else if (Ability <= 21) hpRoll += 5;
            else if (Ability <= 22) hpRoll += 6;
            else if (Ability <= 23) hpRoll += 6;
            else if (Ability <= 24) hpRoll += 7;
            else hpRoll += 7;

            return hpRoll;
        }

        public int GetSystemShock()
        {
            if (Ability <= 1) return 25;
            else if (Ability <= 2) return 30;
            else if (Ability <= 3) return 35;
            else if (Ability <= 4) return 40;
            else if (Ability <= 5) return 45;
            else if (Ability <= 6) return 50;
            else if (Ability <= 7) return 55;
            else if (Ability <= 8) return 60;
            else if (Ability <= 9) return 65;
            else if (Ability <= 10) return 70;
            else if (Ability <= 11) return 75;
            else if (Ability <= 12) return 80;
            else if (Ability <= 13) return 85;
            else if (Ability <= 14) return 88;
            else if (Ability <= 15) return 90;
            else if (Ability <= 16) return 95;
            else if (Ability <= 17) return 97;
            else if (Ability <= 18) return 99;
            else if (Ability <= 19) return 99;
            else if (Ability <= 20) return 99;
            else if (Ability <= 21) return 99;
            else if (Ability <= 22) return 99;
            else if (Ability <= 23) return 99;
            else if (Ability <= 24) return 99;
            else return 100;
        }

        public int GetResurrectionSurvival()
        {
            if (Ability <= 1) return 30;
            else if (Ability <= 2) return 35;
            else if (Ability <= 3) return 40;
            else if (Ability <= 4) return 45;
            else if (Ability <= 5) return 50;
            else if (Ability <= 6) return 55;
            else if (Ability <= 7) return 60;
            else if (Ability <= 8) return 65;
            else if (Ability <= 9) return 70;
            else if (Ability <= 10) return 75;
            else if (Ability <= 11) return 80;
            else if (Ability <= 12) return 85;
            else if (Ability <= 13) return 90;
            else if (Ability <= 14) return 92;
            else if (Ability <= 15) return 94;
            else if (Ability <= 16) return 96;
            else if (Ability <= 17) return 98;
            else return 100;
        }

        public int GetPoisonSave()
        {
            if (Ability <= 1) return -2;
            else if (Ability <= 2) return -1;
            else if (Ability <= 18) return 0;
            else if (Ability <= 20) return 1;
            else if (Ability <= 22) return 2;
            else if (Ability <= 24) return 3;
            else return 4;
        }


        public int GetImmunityToDiseaseAndAlcohol()
        {
            if (Ability <= 1) return 30;
            else if (Ability <= 2) return 25;
            else if (Ability <= 3) return 20;
            else if (Ability <= 4) return 15;
            else if (Ability <= 5) return 10;
            else if (Ability <= 6) return 5;
            else if (Ability <= 7) return 0;
            else if (Ability <= 8) return -5;
            else if (Ability <= 9) return -10;
            else if (Ability <= 10) return -20;
            else if (Ability <= 11) return -25;
            else if (Ability <= 12) return -30;
            else if (Ability <= 13) return -35;
            else if (Ability <= 14) return -40;
            else if (Ability <= 15) return -45;
            else if (Ability <= 16) return -50;
            else if (Ability <= 17) return -55;
            else if (Ability <= 18) return -60;
            else if (Ability <= 19) return -65;
            else if (Ability <= 20) return -70;
            else if (Ability <= 21) return -75;
            else if (Ability <= 22) return -85;
            else if (Ability <= 23) return -90;
            else if (Ability <= 24) return -95;
            else return -99;
        }

        /**
         * These rates are per day
         * 
         * TODO: rework this when we get a timer running
         * 
         * This is pretty awful, but a trigger should be able to be created.
         * 
         * Possibly have a time trigger for when things elapse, but a timer 
         * or a calendar will have to run to trigger this stuff. 2 rates,
         * a combat speed and an exploration rate
         * */
        public double GetRegenerationRate()
        {
            if (Ability <= 7) return 0;
            else if (Ability <= 17) return 1;
            else if (Ability <= 18) return 1.3;
            else if (Ability <= 19) return 2;
            else if (Ability <= 20) return 12;
            else if (Ability <= 21) return 28.8;
            else if (Ability <= 22) return 36;
            else if (Ability <= 23) return 48;
            else if (Ability <= 24) return 72;
            else return 144;
        }
    }
}
