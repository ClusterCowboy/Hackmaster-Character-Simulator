using PlayerCharacters.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters
{
    public class CharacterStatBlock
    {
        public required Strength Strength{ get;set;}
        public required Dexterity Dexterity { get; set; }
        public required Constitution Constitution { get; set; }
        public required Intelligence Intelligence { get; set; }
        public required Wisdom Wisdom { get; set; }
        public required Charisma Charisma { get; set; }
        public required Comeliness Comeliness { get; set; }
        public required int Honor { get; set; }
        public required int TempHonor { get; set; }
    }
}
