using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public class Human : IRace
    {
        public string Name => "Human";

        public int SpeedRating => 12;

        public int StrRacialModifier => 0;

        public int StrMax => 25;

        public int StrMin => 1;

        public int DexRacialModifier => 0;

        public int DexMax => 25;

        public int DexMin => 1;

        public int ConRacialModifier => 0;

        public int ConMax => 25;

        public int ConMin => 1;

        public int IntRacialModifier => 0;

        public int IntMax => 25;

        public int IntMin => 1;

        public int WisRacialModifier => 0;

        public int WisMax => 25;

        public int WisMin => 1;

        public int ChaRacialModifier => 0;

        public int ChaMax => 25;

        public int ChaMin => 1;

        public int ComRacialModifier => 0;

        public int ComMax => 25;

        public int ComMin => 1;
    }
}
