using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public class HalfElf : IRace
    {
        public string Name => "Half-Elf";

        public int SpeedRating => 12;

        public int StrRacialModifier => 0;

        public int StrMax => 18;

        public int StrMin => 3;

        public int DexRacialModifier => 0;

        public int DexMax => 18;

        public int DexMin => 6;

        public int ConRacialModifier => 0;

        public int ConMax => 18;

        public int ConMin => 6;

        public int IntRacialModifier => 0;

        public int IntMax => 18;

        public int IntMin => 4;

        public int WisRacialModifier => 0;

        public int WisMax => 18;

        public int WisMin => 3;

        public int ChaRacialModifier => 0;

        public int ChaMax => 18;

        public int ChaMin => 3;

        public int ComRacialModifier => 1;

        public int ComMax => 17;

        public int ComMin => 5;
    }
}
