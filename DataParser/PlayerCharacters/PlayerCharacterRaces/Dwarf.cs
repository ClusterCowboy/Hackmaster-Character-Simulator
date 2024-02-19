using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public class Dwarf : IRace
    {
        public string Name => "Dwarf";

        public int SpeedRating => 12;

        public int StrRacialModifier => 0;

        public int StrMax => 18;

        public int StrMin => 8;

        public int DexRacialModifier => 0;

        public int DexMax => 17;

        public int DexMin => 3;

        public int ConRacialModifier => 1;

        public int ConMax => 19;

        public int ConMin => 12;

        public int IntRacialModifier => 0;

        public int IntMax => 18;

        public int IntMin => 3;

        public int WisRacialModifier => 0;

        public int WisMax => 18;

        public int WisMin => 3;

        public int ChaRacialModifier => -1;

        public int ChaMax => 16;

        public int ChaMin => 3;

        public int ComRacialModifier => -1;

        public int ComMax => 15;

        public int ComMin => 3;

        public Dictionary<PCStatics.ClassList, int> ClassList => new Dictionary<PCStatics.ClassList, int>
        {
            {PCStatics.ClassList.Cleric, 10},
            {PCStatics.ClassList.Druid, -1},
            {PCStatics.ClassList.Fighter, 15},
            {PCStatics.ClassList.Barbarian, -1},
            {PCStatics.ClassList.Berserker, 16},
            {PCStatics.ClassList.Cavalier, -1},
            {PCStatics.ClassList.DarkKnight, -1},
            {PCStatics.ClassList.KnightErrant, 15},
            {PCStatics.ClassList.Paladin, -1},
            {PCStatics.ClassList.Ranger, -1},
            {PCStatics.ClassList.MagicUser, -1},
            {PCStatics.ClassList.BattleMage, 99},
            {PCStatics.ClassList.Illusionist, -1},
            {PCStatics.ClassList.Thief, 99},
            {PCStatics.ClassList.Assassin, 12},
            {PCStatics.ClassList.Bard, -1}
        };
    }
}
