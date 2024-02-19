using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Classes
{
    public class Fighter : ICharacterClass
    {
        public string Name => "Fighter";

        public int HitDie => 10;
    }
}
