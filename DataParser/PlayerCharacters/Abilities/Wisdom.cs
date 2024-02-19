using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    public class Wisdom : AbilityScore
    {
        public Wisdom(int Score, int Fractional, int RacialMax, int RacialMin)
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
        public Wisdom (int RacialMax, int RacialMin)
        {
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
            GenerateStartingValues();
        }

        public int GetMagicalDefenseAdjustment()
        {
            if (Ability <= 1) return -6;
            else if (Ability <= 2) return -4;
            else if (Ability <= 3) return -3;
            else if (Ability <= 4) return -2;
            else if (Ability <= 7) return -1;
            else if (Ability <= 14) return 0;
            else if (Ability <= 15) return 1;
            else if (Ability <= 16) return 2;
            else if (Ability <= 17) return 3;
            else return 4;
        }

        /**
         * These are bonus spells that only clerics get.
         * 
         * Index: Spell level, value: number of bonus slots
         * */ 
        public Dictionary <int, int> GetBonusSpells()
        {
            Dictionary<int, int> bonus = new Dictionary<int, int>();

            if (Ability == 13)
            {
                bonus[1] = 1;
            }
            else if (Ability == 14)
            {
                bonus[1] = 2;

            }
            else if (Ability == 15)
            {
                bonus[1] = 2;
                bonus[2] = 1;
            }
            else if (Ability == 16)
            {
                bonus[1] = 2;
                bonus[2] = 2;
            }
            else if (Ability == 17)
            {
                bonus[1] = 2;
                bonus[2] = 2;
                bonus[3] = 1;
            }
            else if (Ability <= 18 && AbilityFractional < 51)
            {
                bonus[1] = 2;
                bonus[2] = 2;
                bonus[3] = 1;
                bonus[4] = 1;
            }
            else if (Ability <= 18 && AbilityFractional > 50)
            {
                bonus[1] = 2;
                bonus[2] = 2;
                bonus[3] = 1;
                bonus[4] = 1;
                bonus[5] = 1;
            }
            else if (Ability <= 19)
            {
                bonus[1] = 3;
                bonus[2] = 2;
                bonus[3] = 2;
                bonus[4] = 1;
                bonus[5] = 1;
            }
            else if (Ability <= 20)
            {
                bonus[1] = 3;
                bonus[2] = 3;
                bonus[3] = 2;
                bonus[4] = 2;
                bonus[5] = 1;
            }
            else if (Ability <= 21)
            {
                bonus[1] = 3;
                bonus[2] = 3;
                bonus[3] = 3;
                bonus[4] = 2;
                bonus[5] = 2;
            }
            else if (Ability <= 22)
            {
                bonus[1] = 3;
                bonus[2] = 3;
                bonus[3] = 3;
                bonus[4] = 3;
                bonus[5] = 3;
            }
            else if (Ability <= 23)
            {
                bonus[1] = 4;
                bonus[2] = 3;
                bonus[3] = 3;
                bonus[4] = 3;
                bonus[5] = 3;
                bonus[6] = 1;
            }
            else if (Ability <= 24)
            {
                bonus[1] = 4;
                bonus[2] = 3;
                bonus[3] = 3;
                bonus[4] = 3;
                bonus[5] = 4;
                bonus[6] = 2;
            }
            else if (Ability <= 25)
            {
                bonus[1] = 4;
                bonus[2] = 3;
                bonus[3] = 3;
                bonus[4] = 3;
                bonus[5] = 4;
                bonus[6] = 3;
                bonus[7] = 1;
            }

            return bonus;
        }

        public List<string> GetListOfImmuneSpells()
        {
            List<string> immuneList = new List<string>();

            if (Ability <= 18 && AbilityFractional > 50)
            {
                immuneList.Add("Befriend");
            }
            else if (Ability <= 19)
            {
                immuneList.Add("Cause Fear");
                immuneList.Add("Charm Person");
                immuneList.Add("Command");
                immuneList.Add("Hypnotism");
            }
            else if (Ability <= 20)
            {
                immuneList.Add("Forget");
                immuneList.Add("Hold Person");
                immuneList.Add("Ray of Enfeeblement");
                immuneList.Add("Scare");
            }
            else if (Ability <= 21)
            {
                immuneList.Add("Fear");
            }
            else if (Ability <= 22)
            {
                immuneList.Add("Charm Monster");
                immuneList.Add("Confusion");
                immuneList.Add("Emotion");
                immuneList.Add("Fumble");
                immuneList.Add("Suggestion");
            }
            else if (Ability <= 23)
            {
                immuneList.Add("Chaos");
                immuneList.Add("Feeblemind");
                immuneList.Add("Hold Monster");
                immuneList.Add("Magic Jar");
                immuneList.Add("Quest");
            }
            else if (Ability <= 24)
            {
                immuneList.Add("Geas");
                immuneList.Add("Mass Suggestion");
                immuneList.Add("Rod of Rulership");
            }
            else if (Ability <= 25)
            {
                immuneList.Add("Antipathy/Sympathy");
                immuneList.Add("Death Spell");
                immuneList.Add("Mass Charm");
            }

            return immuneList;
        }
    

        public int ChanceToImproveSkill()
        {
            if (Ability <= 3) return 3;
            else if (Ability <= 4) return 2;
            else if (Ability <= 6) return 3;
            else if (Ability <= 8) return 4;
            else if (Ability <= 13) return 5;
            else if (Ability <= 14) return 6;
            else if (Ability <= 15) return 7;
            else if (Ability <= 16) return 8;
            else if (Ability <= 17) return 9;
            else if (Ability <= 18 && AbilityFractional < 51) return 10;
            else if (Ability <= 18 && AbilityFractional > 50) return 11;
            else if (Ability <= 19) return 12;
            else if (Ability <= 20) return 13;
            else if (Ability <= 21) return 14;
            else if (Ability <= 22) return 15;
            else if (Ability <= 23) return 16;
            else if (Ability <= 24) return 18;
            else return 20;
        }
    }
}
