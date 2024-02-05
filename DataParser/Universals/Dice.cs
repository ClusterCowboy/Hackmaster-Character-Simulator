using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Universals
{
    public sealed class Dice
    {
        private static readonly Lazy<Dice> lazy =
            new Lazy<Dice>(() => new Dice());

        public static Dice Instance { get { return lazy.Value; } }

        private Dice() { }

        public int Roll(int numOfDice, int sidesOfDice, int modifier = 0) =>
            RandomNumberGenerator.GetInt32(numOfDice, numOfDice * sidesOfDice) + modifier;

        /// <summary>
        /// Roll dice that explode! Exploding is when you roll the highest value, 
        /// then roll again. Add the new value -1 to the total. If it's the highest
        /// value, repeat, always at only -1.
        /// </summary>
        /// <param name="additionalModifier"></param>
        /// <returns></returns>
        public int RollExplodingDice(int numOfDice, int sidesOfDice, int modifier = 0)
        {
            int result = modifier;
            for (int i = 0; i < numOfDice; i++)
            {
                int thisRun = RandomNumberGenerator.GetInt32(1, sidesOfDice + 1);

                if (thisRun == sidesOfDice && sidesOfDice > 1)
                {
                    while (true)
                    {
                        int rollResult2 = RandomNumberGenerator.GetInt32(1, sidesOfDice + 1);
                        thisRun += (rollResult2 - 1);

                        if (rollResult2 != sidesOfDice)
                        {
                            break;
                        }
                    }
                }
                result += thisRun;
            }
            return result;
        }
    }
}
