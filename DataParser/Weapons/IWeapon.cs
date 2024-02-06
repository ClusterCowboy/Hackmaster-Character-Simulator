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
        public int Id { get; set; }

        public Size _weaponSize { get; set; }
        public int tinyDiceNum { get; set; }
        public int tinyDiceSides { get; set; }
        public int tinyDiceMod { get; set; }
        public int smallDiceNum { get; set; }
        public int smallDiceSides { get; set; }
        public int smallDiceMod { get; set; }
        public int mediumDiceNum { get; set; }
        public int mediumDiceSides { get; set; }
        public int mediumDiceMod { get; set; }
        public int largeDiceNum { get; set; }
        public int largeDiceSides { get; set; }
        public int largeDiceMod { get; set; }
        public int hugeDiceNum { get; set; }
        public int hugeDiceSides { get; set; }
        public int hugeDiceMod { get; set; }
        public int gargantuanDiceNum { get; set; }
        public int gargantuanDiceSides { get; set; }
        public int gargantuanDiceMod { get; set; }
        public int _avaHi { get; set; }
        public int _avaMid { get; set; }
        public int _avaLow { get; set; }

    }
}
