using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Universals;
using static GenericEnums.GenericEnums;

namespace Weapons
{
    public interface IWeapon
    {
        public int RollDice(Size size, int modifier);

        string ItemName { get; set; }
        public double _weight { get; set; }
        public Size _weaponSize { get; set; }
        public Dice _tinyDice { get; set; }
        public Dice _smallDice { get; set; }
        public Dice _mediumDice { get; set; }
        public Dice _largeDice { get; set; }
        public Dice _hugeDice { get; set; }
        public Dice _gargantuanDice { get; set; }
        public int _avaHi { get; set; }
        public int _avaMid { get; set; }
        public int _avaLow { get; set; }

    }
}
