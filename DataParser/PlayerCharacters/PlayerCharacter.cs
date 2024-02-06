using System.Text.Json.Serialization;
using Weapons;
using static GenericEnums.GenericEnums;

namespace PlayerCharacters
{
    [Serializable]
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public List<IWeapon> Weapons { get; set; }
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        public CharacterClasses Class { get; set; }
        public int AC { get; set; }

    }
}
