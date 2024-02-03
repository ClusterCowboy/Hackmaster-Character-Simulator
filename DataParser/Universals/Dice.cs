using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Universals
{
    [Serializable]
    public class Dice : ISerializable
    {
        public Dice(int NumOfDice, int SidesOfDice, int Modifier = 0) 
        {
            numOfDice = NumOfDice;
            sidesOfDice = SidesOfDice;
            modifier = Modifier;
        }
        public int numOfDice { get; set; }
        public int sidesOfDice { get; set; }
        public int modifier { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("NumOfDice", this.numOfDice);
            info.AddValue("SidesOnDice", this.sidesOfDice);
            info.AddValue("Modifier", this.modifier);
        }

        public int Roll(int additionalModifier = 0) =>
            RandomNumberGenerator.GetInt32(numOfDice, numOfDice * sidesOfDice) + (modifier + additionalModifier);

        /// <summary>
        /// Roll dice that explode! Exploding is when you roll the highest value, 
        /// then roll again. Add the new value -1 to the total. If it's the highest
        /// value, repeat, always at only -1.
        /// </summary>
        /// <param name="additionalModifier"></param>
        /// <returns></returns>
        public int RollExplodingDice(int additionalModifier = 0)
        {
            int result = modifier + additionalModifier;
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
