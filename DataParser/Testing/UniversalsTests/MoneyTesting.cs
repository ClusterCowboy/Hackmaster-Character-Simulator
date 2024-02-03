using Universals;

namespace Testing.UniversalsTests
{
    [TestClass]
    public class MoneyTesting
    {
        [TestMethod]
        public void ConvertMoneyTester()
        {
            double money = 37.19;
            for (int i = 0; i < 10; i++)
            {
                money = money + .01;
                Console.WriteLine(Money.ConvertMoneyToHumanReadable(money));
            }
        }

        [TestMethod]
        public void StringToMoney()
        {
            string money1 = "5pp 4   sp";
            string money2 = " 4sp 1  pp 2gp 3g p 77sp 1 cp";

            Console.WriteLine(money1 + " - " + Money.ConvertMoneyToDouble(money1));
            Console.WriteLine(money2 + " - " + Money.ConvertMoneyToDouble(money2));
        }
    }
}