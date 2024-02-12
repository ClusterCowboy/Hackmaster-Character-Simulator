using Armor;
using PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Testing.CharacterTests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void CharacterWeightTest()
        {
            PlayerCharacter pc = new PlayerCharacter()
            {
                Name = "El Testo",
                CharacterStats = new CharacterStatBlock()
                {
                    Strength = new PlayerCharacters.Abilities.Strength(10, 0, 18, 3),
                    Dexterity = new PlayerCharacters.Abilities.Dexterity(10, 0, 18, 3),
                    Constitution = new PlayerCharacters.Abilities.Constitution(10, 0, 18, 3),
                    Intelligence = new PlayerCharacters.Abilities.Intelligence(10, 0, 18, 3),
                    Wisdom = new PlayerCharacters.Abilities.Wisdom(10, 0, 18, 3),
                    Charisma = new PlayerCharacters.Abilities.Charisma(10, 0, 18, 3),
                    Comeliness = new PlayerCharacters.Abilities.Comeliness(10, 0, 18, 3),
                    Honor = 0,
                    TempHonor = 0
                }
            };

            ArmorCatalog armorCatalog = new ArmorCatalog();
            pc.EquipArmor(armorCatalog.BodyArmor[ArmorType.FullPlate]);

            Assert.AreEqual(pc.GetCurrentWeightCarried(), armorCatalog.BodyArmor[ArmorType.FullPlate].Weight);

            WeaponAccessor weaponCatalog = new WeaponAccessor();
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Battle axe"]);

            Assert.AreEqual(pc.GetCurrentWeightCarried(), armorCatalog.BodyArmor[ArmorType.FullPlate].Weight + 
                weaponCatalog.MeleeWeaponsCatalog["Battle axe"].Weight);

            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Heavy horse lance"]);

            Assert.AreEqual(pc.GetCurrentWeightCarried(), armorCatalog.BodyArmor[ArmorType.FullPlate].Weight +
                weaponCatalog.MeleeWeaponsCatalog["Battle axe"].Weight +
                weaponCatalog.MeleeWeaponsCatalog["Heavy horse lance"].Weight);

        }
    }
}
