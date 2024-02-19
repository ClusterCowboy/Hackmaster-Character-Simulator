using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Abilities
{
    public class Comeliness : AbilityScore
    {
        /***
         * TODO: Implement this
         * */
        public Comeliness(int Score, int Fractional, int RacialMax, int RacialMin)
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
        public Comeliness(int RacialMax, int RacialMin)
        {
            AbilityMax = RacialMax;
            AbilityMin = RacialMin;
            GenerateStartingValues();
        }
    }
}
