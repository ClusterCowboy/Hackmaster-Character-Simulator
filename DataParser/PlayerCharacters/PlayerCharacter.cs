using System.Text.Json.Serialization;
using Weapons;

namespace PlayerCharacters
{
    [Serializable]
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public List<IWeapon> Weapons { get; set; }
        public int maxHp { get; set; }
        public int currentMp { get; set; }

        
    }
}
