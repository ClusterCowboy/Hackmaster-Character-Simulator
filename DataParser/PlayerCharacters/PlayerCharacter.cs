using Armor;
using Weapons;
using static GenericEnums.GenericEnums;

namespace PlayerCharacters
{
    [Serializable]
    public class PlayerCharacter
    {
        public required string Name { get; set; }
        public List<IWeapon>? Weapons { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public CharacterClasses Class { get; set; }
        public int AC { get; set; }
        public Armor.Armor? CurrentlyWornArmor { get; set; }
        public Shield? CurrentlyWornShield { get; set; }
        public Helmet? CurrentlyWornHelmet { get; set; }
        public required CharacterStatBlock CharacterStats {  get; set; }
    }
}
