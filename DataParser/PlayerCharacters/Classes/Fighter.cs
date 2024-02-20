using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universals;

namespace PlayerCharacters.Classes
{
    public class Fighter : ICharacterClass
    {
        public string Name => "Fighter";

        public int HitDie => 10;

        public int Level { get; set; } = 1;

        public Dictionary<int, int> HitAC15PerLevel = new Dictionary<int, int>
        {
            {   1   ,   3   }   ,
            {   2   ,   2   }   ,
            {   3   ,   1   }   ,
            {   4   ,   0   }   ,
            {   5   ,   -1  }   ,
            {   6   ,   -2  }   ,
            {   7   ,   -3  }   ,
            {   8   ,   -4  }   ,
            {   9   ,   -5  }   ,
            {   10  ,   -6  }   ,
            {   11  ,   -7  }   ,
            {   12  ,   -8  }   ,
            {   13  ,   -9  }   ,
            {   14  ,   -10 }   ,
            {   15  ,   -11 }   ,
            {   16  ,   -12 }   ,
            {   17  ,   -13 }   ,
            {   18  ,   -14 }   ,
            {   19  ,   -15 }   ,
            {   20  ,   -16 }   ,
            {   21  ,   -17 }
        };

        public Dictionary<int, Tuple<int, int>> AC20Range = new Dictionary<int, Tuple<int, int>>
        {
            {   1   , new Tuple<int, int>(  -2  ,   -7  ) },
            {   2   , new Tuple<int, int>(  -3  ,   -8  ) },
            {   3   , new Tuple<int, int>(  -4  ,   -9  ) },
            {   4   , new Tuple<int, int>(  -5  ,   -10 ) },
            {   5   , new Tuple<int, int>(  -6  ,   -11 ) },
            {   6   , new Tuple<int, int>(  -7  ,   -12 ) },
            {   7   , new Tuple<int, int>(  -8  ,   -13 ) },
            {   8   , new Tuple<int, int>(  -9  ,   -14 ) },
            {   9   , new Tuple<int, int>(  -10 ,   -15 ) },
            {   10  , new Tuple<int, int>(  -11 ,   -16 ) },
            {   11  , new Tuple<int, int>(  -12 ,   -17 ) },
            {   12  , new Tuple<int, int>(  -13 ,   -18 ) },
            {   13  , new Tuple<int, int>(  -14 ,   -19 ) },
            {   14  , new Tuple<int, int>(  -15 ,   -20 ) },
            {   15  , new Tuple<int, int>(  -16 ,   -21 ) },
            {   16  , new Tuple<int, int>(  -17 ,   -22 ) },
            {   17  , new Tuple<int, int>(  -18 ,   -23 ) },
            {   18  , new Tuple<int, int>(  -19 ,   -24 ) },
            {   19  , new Tuple<int, int>(  -20 ,   -25 ) },
            {   20  , new Tuple<int, int>(  -21 ,   -26 ) },
            {   21  , new Tuple<int, int>(  -22 ,   -27 ) }
        };

        public int RollToHitAC(int toHitModifier)
        {
            int dieRoll = Dice.Instance.Roll(1, 20, toHitModifier);
            int ACHit = 15 - (dieRoll - HitAC15PerLevel[Level]);

            return ACHit;
        }
    }
}
