using CsvHelper;
using CsvHelper.Configuration;
using GenericEnums;
using System.Globalization;
using System.Text;
using Universals;
using Weapons;
using static GenericEnums.GenericEnums;

internal class Program
{
    private static void Main(string[] args)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            NewLine = Environment.NewLine,
            HasHeaderRecord = false,
            MissingFieldFound = null
        };

        WeaponAccessor w = new WeaponAccessor();

        using (var reader = new StreamReader("C:\\Users\\user\\source\\repos\\Hackmaster-Character-Simulator\\DataParser\\DataFiles\\Melee Weapons (2).csv"))
        using (var csv = new CsvReader(reader, config))
        {
            List<MeleeWeapon> mw = csv.GetRecords<MeleeWeapon>().ToList();


            w.InsertData(mw);

            foreach (MeleeWeapon x in mw)
            {

                Console.WriteLine(x.ItemName);
            }
        }
    }
}