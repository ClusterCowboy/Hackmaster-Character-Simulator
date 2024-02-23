using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Universals;

namespace Testing.UniversalsTests
{
    [TestClass]
    public class DiceTesting
    {
        [TestMethod]
        public void DiceTester()
        {
            int attackTimes = 5;
            Console.WriteLine("Attack " + attackTimes + " times");
            for (int i = 0; i < attackTimes; i++)
            {
                Console.WriteLine(i.ToString() + " ... " + Di.ce.Roll(1, 20, 5));
            }

            int damageTimes = 15;
            Console.WriteLine("Damage " + damageTimes + " times");
            for (int i = 0; i < damageTimes; i++)
            {
                Console.WriteLine(i.ToString() + " ... " + Di.ce.RollExplodingDice(4, 4));
            }
        }
    }
}

