using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universals;

namespace PlayerCharacters.Classes
{
    public class Fighter : ICharacterClass
    {
        public string Name => "Fighter";

        public int HitDie => 10;

        public int Level { get; set; } = 1;

        public Dictionary<int, int> AC20Range
        {
            get => new Dictionary<int, int>
            {
                { 1 , -2 },
                { 2 , -3 },
                { 3 , -4 },
                { 4 , -5 },
                { 5 , -6 },
                { 6 , -7 },
                { 7 , -8 },
                { 8 , -9 },
                { 9 , -10 },
                { 10  , -11 },
                { 11  , -12 },
                { 12  , -13 },
                { 13  , -14 },
                { 14  , -15 },
                { 15  , -16 },
                { 16  , -17 },
                { 17  , -18 },
                { 18  , -19 },
                { 19  , -20 },
                { 20  , -21 },
                { 21  , -22 }
            };
        }

        public int RollToHitAC(int toHitModifier)
        {
            int dieRoll = Dice.Instance.Roll(1, 20, toHitModifier);

            if (dieRoll == 20)
            {
                return AC20Range[Level];
            }
            else if (dieRoll > 20)
            {
                return (AC20Range[Level] - 5) - (dieRoll - 20);
            }
            else
            {
                return AC20Range[Level] + (20 - dieRoll);
            }
        }

        public int GetBaseSeverityLevel(int enemyAC, int toHitModifier)
        {
            return enemyAC 
                - (AC20Range[Level] + 15) // Chance to hit AC 15 
                + toHitModifier 
                + Dice.Instance.RollExplodingDice(1,8);
        }
    }
}
