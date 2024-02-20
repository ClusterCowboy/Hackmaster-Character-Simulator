using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.Classes
{
    public interface ICharacterClass
    {
        string Name { get; }
        int HitDie { get; }
        public int RollToHitAC(int toHitModifier);

    }
}
