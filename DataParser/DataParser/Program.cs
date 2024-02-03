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

        //using (var reader = new StreamWriter("C:\\Users\\user\\Proton Drive\\imakerobots\\My files\\Coding\\RPGProject\\DataFiles\\Melee Weapons.csv"))
        //using (var csv = new CsvWriter(reader, config))
        //{
        //    MeleeWeapon mw = new MeleeWeapon()
        //    {
        //        ItemName = "Sword2",
        //        Value = 22.22,
        //        _weight = 1,
        //        WeaponDamageType = WeaponType.H,
        //        _weaponSize = Size.M,
        //        SpeedFactor = -1,
        //        _tinyDice = new Dice(1, 2),
        //        _smallDice = new Dice(1, 4),
        //        _mediumDice = new Dice(1, 6),
        //        _largeDice = new Dice(1, 8),
        //        _hugeDice = new Dice(1, 10),
        //        _gargantuanDice = new Dice(1, 12),
        //        _avaHi = 95,
        //        _avaMid = 75,
        //        _avaLow = 35
        //    };

        //    StringBuilder sb = new StringBuilder();
        //    StringWriter sw = new StringWriter(sb);

        //    csv.WriteRecord<MeleeWeapon>(mw);
        //}


        using (var reader = new StreamReader("C:\\Users\\user\\Proton Drive\\imakerobots\\My files\\Coding\\RPGProject\\DataFiles\\Melee Weapons1.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            List<MeleeWeapon> mw = csv.GetRecords<MeleeWeapon>().ToList();

            foreach (var x in mw)
            {
                Console.WriteLine(x);
            }
        }
    }
}