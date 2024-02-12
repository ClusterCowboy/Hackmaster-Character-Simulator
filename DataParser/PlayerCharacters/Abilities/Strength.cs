using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    internal class Strength : AbilityScore
    {
        public Strength(int Score, int Fractional, int RacialMax, int RacialMin)
        {
            Ability = Score;
            AbilityFractional = Fractional;
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
        }

        public int GetMeleeHitProb()
        {
            if (Ability <= 3) return -3;
            else if (Ability <= 6) return -2;
            else if (Ability <= 8) return -1;
            else if (Ability <= 12) return 0;
            else if (Ability <= 15) return 1;
            else if (Ability <= 17) return 2;
            else if (Ability <= 20) return 3;
            else if (Ability <= 22) return 4;
            else if (Ability <= 23) return 5;
            else if (Ability <= 24) return 6;
            else return 7;
        }

        public int GetMeleeDamageAdj()
        {
            if (Ability <= 1) return -8;
            else if (Ability <= 2) return -7;
            else if (Ability <= 3) return -6;
            else if (Ability <= 4) return -5;
            else if (Ability <= 5) return -4;
            else if (Ability <= 6) return -3;
            else if (Ability <= 7) return -2;
            else if (Ability <= 9) return -1;
            else if (Ability <= 11) return 0;
            else if (Ability <= 13) return 1;
            else if (Ability <= 14) return 2;
            else if (Ability <= 15) return 3;
            else if (Ability <= 16) return 4;
            else if (Ability <= 17) return 5;
            else if (Ability <= 18) return 6;
            else if (Ability <= 19) return 7;
            else if (Ability <= 20) return 8;
            else if (Ability <= 21) return 9;
            else if (Ability <= 22) return 10;
            else if (Ability <= 23) return 11;
            else if (Ability <= 24) return 12;
            else return 14;
        }

        public int GetWeightAllowance()
        {
            if (Ability <= 1 && AbilityFractional < 51) return 1;
            else if (Ability <= 1 && AbilityFractional > 50) return 2;
            else if (Ability <= 2 && AbilityFractional < 51) return 3;
            else if (Ability <= 2 && AbilityFractional > 50) return 4;
            else if (Ability <= 3 && AbilityFractional < 51) return 5;
            else if (Ability <= 3 && AbilityFractional > 50) return 7;
            else if (Ability <= 4 && AbilityFractional < 51) return 9;
            else if (Ability <= 4 && AbilityFractional > 50) return 11;
            else if (Ability <= 5 && AbilityFractional < 51) return 13;
            else if (Ability <= 5 && AbilityFractional > 50) return 15;
            else if (Ability <= 6 && AbilityFractional < 51) return 18;
            else if (Ability <= 6 && AbilityFractional > 50) return 21;
            else if (Ability <= 7 && AbilityFractional < 51) return 24;
            else if (Ability <= 7 && AbilityFractional > 50) return 27;
            else if (Ability <= 8 && AbilityFractional < 51) return 30;
            else if (Ability <= 8 && AbilityFractional > 50) return 33;
            else if (Ability <= 9 && AbilityFractional < 51) return 36;
            else if (Ability <= 9 && AbilityFractional > 50) return 39;
            else if (Ability <= 10 && AbilityFractional < 51) return 43;
            else if (Ability <= 10 && AbilityFractional > 50) return 47;
            else if (Ability <= 11 && AbilityFractional < 51) return 51;
            else if (Ability <= 11 && AbilityFractional > 50) return 55;
            else if (Ability <= 12 && AbilityFractional < 51) return 59;
            else if (Ability <= 12 && AbilityFractional > 50) return 63;
            else if (Ability <= 13 && AbilityFractional < 51) return 67;
            else if (Ability <= 13 && AbilityFractional > 50) return 71;
            else if (Ability <= 14 && AbilityFractional < 51) return 76;
            else if (Ability <= 14 && AbilityFractional > 50) return 81;
            else if (Ability <= 15 && AbilityFractional < 51) return 86;
            else if (Ability <= 15 && AbilityFractional > 50) return 91;
            else if (Ability <= 16 && AbilityFractional < 51) return 97;
            else if (Ability <= 16 && AbilityFractional > 50) return 103;
            else if (Ability <= 17 && AbilityFractional < 51) return 109;
            else if (Ability <= 17 && AbilityFractional > 50) return 115;
            else if (Ability <= 18 && AbilityFractional < 51) return 130;
            else if (Ability <= 18 && AbilityFractional > 50) return 160;
            else if (Ability <= 19 && AbilityFractional < 51) return 200;
            else if (Ability <= 19 && AbilityFractional > 50) return 300;
            else if (Ability <= 20 && AbilityFractional < 51) return 400;
            else if (Ability <= 20 && AbilityFractional > 50) return 500;
            else if (Ability <= 21 && AbilityFractional < 51) return 600;
            else if (Ability <= 21 && AbilityFractional > 50) return 700;
            else if (Ability <= 22 && AbilityFractional < 51) return 800;
            else if (Ability <= 22 && AbilityFractional > 50) return 900;
            else if (Ability <= 23 && AbilityFractional < 51) return 1000;
            else if (Ability <= 23 && AbilityFractional > 50) return 1100;
            else if (Ability <= 24 && AbilityFractional < 51) return 1200;
            else if (Ability <= 24 && AbilityFractional > 50) return 1300;
            else return 1500;
        }

        public int GetMaxPress()
        {
            if (Ability <= 1 && AbilityFractional < 51) return 3;
            else if (Ability <= 1 && AbilityFractional > 50) return 4;
            else if (Ability <= 2 && AbilityFractional < 51) return 5;
            else if (Ability <= 2 && AbilityFractional > 50) return 7;
            else if (Ability <= 3 && AbilityFractional < 51) return 10;
            else if (Ability <= 3 && AbilityFractional > 50) return 20;
            else if (Ability <= 4 && AbilityFractional < 51) return 25;
            else if (Ability <= 4 && AbilityFractional > 50) return 30;
            else if (Ability <= 5 && AbilityFractional < 51) return 35;
            else if (Ability <= 5 && AbilityFractional > 50) return 40;
            else if (Ability <= 6 && AbilityFractional < 51) return 55;
            else if (Ability <= 6 && AbilityFractional > 50) return 60;
            else if (Ability <= 7 && AbilityFractional < 51) return 70;
            else if (Ability <= 7 && AbilityFractional > 50) return 80;
            else if (Ability <= 8 && AbilityFractional < 51) return 90;
            else if (Ability <= 8 && AbilityFractional > 50) return 95;
            else if (Ability <= 9 && AbilityFractional < 51) return 100;
            else if (Ability <= 9 && AbilityFractional > 50) return 110;
            else if (Ability <= 10 && AbilityFractional < 51) return 115;
            else if (Ability <= 10 && AbilityFractional > 50) return 125;
            else if (Ability <= 11 && AbilityFractional < 51) return 130;
            else if (Ability <= 11 && AbilityFractional > 50) return 135;
            else if (Ability <= 12 && AbilityFractional < 51) return 140;
            else if (Ability <= 12 && AbilityFractional > 50) return 145;
            else if (Ability <= 13 && AbilityFractional < 51) return 150;
            else if (Ability <= 13 && AbilityFractional > 50) return 160;
            else if (Ability <= 14 && AbilityFractional < 51) return 170;
            else if (Ability <= 14 && AbilityFractional > 50) return 175;
            else if (Ability <= 15 && AbilityFractional < 51) return 185;
            else if (Ability <= 15 && AbilityFractional > 50) return 190;
            else if (Ability <= 16 && AbilityFractional < 51) return 195;
            else if (Ability <= 16 && AbilityFractional > 50) return 220;
            else if (Ability <= 17 && AbilityFractional < 51) return 255;
            else if (Ability <= 17 && AbilityFractional > 50) return 290;
            else if (Ability <= 18 && AbilityFractional < 51) return 350;
            else if (Ability <= 18 && AbilityFractional > 50) return 480;
            else if (Ability <= 19 && AbilityFractional < 51) return 640;
            else if (Ability <= 19 && AbilityFractional > 50) return 660;
            else if (Ability <= 20 && AbilityFractional < 51) return 700;
            else if (Ability <= 20 && AbilityFractional > 50) return 725;
            else if (Ability <= 21 && AbilityFractional < 51) return 810;
            else if (Ability <= 21 && AbilityFractional > 50) return 865;
            else if (Ability <= 22 && AbilityFractional < 51) return 970;
            else if (Ability <= 22 && AbilityFractional > 50) return 1050;
            else if (Ability <= 23 && AbilityFractional < 51) return 1130;
            else if (Ability <= 23 && AbilityFractional > 50) return 1320;
            else if (Ability <= 24 && AbilityFractional < 51) return 1440;
            else if (Ability <= 24 && AbilityFractional > 50) return 1540;
            else return 1750;
        }

        public int GetOpenDoor()
        {
            if (Ability <= 2) return 1;
            else if (Ability <= 3) return 2;
            else if (Ability <= 4) return 3;
            else if (Ability <= 5 && AbilityFractional < 51) return 3;
            else if (Ability <= 5 && AbilityFractional > 50) return 4;
            else if (Ability <= 6) return 4;
            else if (Ability <= 7 && AbilityFractional < 51) return 4;
            else if (Ability <= 7 && AbilityFractional > 50) return 5;
            else if (Ability <= 8) return 5;
            else if (Ability <= 9 && AbilityFractional < 51) return 5;
            else if (Ability <= 9 && AbilityFractional > 50) return 6;
            else if (Ability <= 10) return 6;
            else if (Ability <= 11 && AbilityFractional < 51) return 6;
            else if (Ability <= 11 && AbilityFractional > 50) return 7;
            else if (Ability <= 12) return 7;
            else if (Ability <= 13 && AbilityFractional < 51) return 7;
            else if (Ability <= 13 && AbilityFractional > 50) return 8;
            else if (Ability <= 14) return 8;
            else if (Ability <= 15) return 9;
            else if (Ability <= 16) return 10;
            else if (Ability <= 17) return 11;
            else if (Ability <= 18 && AbilityFractional < 51) return 12;
            else if (Ability <= 18 && AbilityFractional > 50) return 14;
            else if (Ability <= 19 && AbilityFractional < 51) return 15;
            else if (Ability <= 19 && AbilityFractional > 50) return 16;
            else if (Ability <= 20) return 17;
            else if (Ability <= 21 && AbilityFractional < 51) return 17;
            else if (Ability <= 21 && AbilityFractional > 50) return 18;
            else if (Ability <= 22) return 18;
            else if (Ability <= 23 && AbilityFractional < 51) return 18;
            else if (Ability <= 23 && AbilityFractional > 50) return 19;
            else return 19;
        }

        public int GetOpenLockedBarredMagicallyHeldDoor()
        {
            if (Ability <= 17) return 0;
            else if (Ability <= 18 && AbilityFractional < 51) return 3;
            else if (Ability <= 18 && AbilityFractional > 50) return 6;
            else if (Ability <= 19 && AbilityFractional < 51) return 8;
            else if (Ability <= 19 && AbilityFractional > 50) return 9;
            else if (Ability <= 20 && AbilityFractional < 51) return 10;
            else if (Ability <= 20 && AbilityFractional > 50) return 11;
            else if (Ability <= 21 && AbilityFractional < 51) return 12;
            else if (Ability <= 21 && AbilityFractional > 50) return 13;
            else if (Ability <= 22 && AbilityFractional < 51) return 14;
            else if (Ability <= 22 && AbilityFractional > 50) return 15;
            else if (Ability <= 23) return 16;
            else if (Ability <= 24 && AbilityFractional < 51) return 16;
            else if (Ability <= 24 && AbilityFractional > 50) return 17;
            else return 18;
        }

        public int GetBendBarsLiftGates()
        {
            if (Ability <= 7) return 0;
            else if (Ability <= 9) return 1;
            else if (Ability <= 10 && AbilityFractional < 51) return 2;
            else if (Ability <= 10 && AbilityFractional > 50) return 3;
            else if (Ability <= 11) return 4;
            else if (Ability <= 12) return 5;
            else if (Ability <= 13) return 6;
            else if (Ability <= 14 && AbilityFractional < 51) return 7;
            else if (Ability <= 14 && AbilityFractional > 50) return 8;
            else if (Ability <= 15 && AbilityFractional < 51) return 9;
            else if (Ability <= 15 && AbilityFractional > 50) return 10;
            else if (Ability <= 16 && AbilityFractional < 51) return 11;
            else if (Ability <= 16 && AbilityFractional > 50) return 12;
            else if (Ability <= 17 && AbilityFractional < 51) return 15;
            else if (Ability <= 17 && AbilityFractional > 50) return 20;
            else if (Ability <= 18 && AbilityFractional < 51) return 25;
            else if (Ability <= 18 && AbilityFractional > 50) return 35;
            else if (Ability <= 19 && AbilityFractional < 51) return 50;
            else if (Ability <= 19 && AbilityFractional > 50) return 55;
            else if (Ability <= 20 && AbilityFractional < 51) return 60;
            else if (Ability <= 20 && AbilityFractional > 50) return 65;
            else if (Ability <= 21 && AbilityFractional < 51) return 70;
            else if (Ability <= 21 && AbilityFractional > 50) return 75;
            else if (Ability <= 22 && AbilityFractional < 51) return 80;
            else if (Ability <= 22 && AbilityFractional > 50) return 85;
            else if (Ability <= 23 && AbilityFractional < 51) return 90;
            else if (Ability <= 23 && AbilityFractional > 50) return 95;
            else if (Ability <= 24 && AbilityFractional < 51) return 97;
            else if (Ability <= 24 && AbilityFractional > 50) return 98;
            else return 99;
        }

    }
}
