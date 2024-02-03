using System.Text;
using System.Text.RegularExpressions;

namespace Universals
{
    public static class Money
    {
        public static double ConvertMoneyToDouble(string money)
        {
            if (String.IsNullOrEmpty(money)) return 0;

            double result = 0;

            Regex platinum = new Regex("\\d+ *pp");
            Regex gold = new Regex("\\d+ *gp");
            Regex silver = new Regex("\\d+ *sp");
            Regex copper = new Regex("\\d+ *cp");

            MatchCollection m = platinum.Matches(money);

            foreach (var x in m)
            {
                result += Convert.ToDouble( x.ToString().Substring(0, x.ToString().Length - 2)) * 5;
            }

            MatchCollection q = gold.Matches(money);

            foreach (var x in q)
            {
                result += Convert.ToDouble(x.ToString().Substring(0, x.ToString().Length - 2));
            }

            MatchCollection w = silver.Matches(money);

            foreach (var x in w)
            {
                result += Convert.ToDouble(x.ToString().Substring(0, x.ToString().Length - 2)) * .1;
            }

            MatchCollection v = copper.Matches(money);

            foreach (var x in v)
            {
                result += Convert.ToDouble(x.ToString().Substring(0, x.ToString().Length - 2)) * .01;
            }

            return Math.Round(result, 2);
        }

        public static string ConvertMoneyToHumanReadable(double money)
        {
            int Platinum = 5;
            int Gold = 1;
            double Silver = .1;
            double Copper = .01;

            StringBuilder sb = new StringBuilder();
            int copper = ((int)(money * 100) % 10); ;
            int silver = ((int)(money * 10) % 10);
            int greaterThanFraction = ((int)Math.Round(money, 0, MidpointRounding.ToZero));
            int platinum = greaterThanFraction / 5;
            int gold = greaterThanFraction - (platinum * Platinum);

            if (platinum > 0)
            {
                sb.Append(platinum + " pp " );
            }
            if (gold > 0)
            {
                sb.Append(gold + " gp ");
            }
            if (silver > 0)
            {
                sb.Append(silver + " sp ");
            }
            if (copper > 0)
            {
                sb.Append(copper + " cp");
            }

            return sb.ToString();
        }
    }
}
