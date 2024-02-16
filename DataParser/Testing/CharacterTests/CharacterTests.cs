using Armor;
using PlayerCharacters;
using PlayerCharacters.PlayerCharacterRaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Testing.CharacterTests
{
    [TestClass]
    public class CharacterTests
    {
        public PlayerCharacter CreateTestCharacter()
        {
            IRace r = new Human();

            PlayerCharacter pc = new PlayerCharacter()
            {
                Name = "El Testo",
                Race = r,
                CharacterStats = new CharacterStatBlock()
                {
                    Strength = new PlayerCharacters.Abilities.Strength(10, 0, r.StrMax, r.StrMin),
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

            return pc;
        }


        /// <summary>
        /// Verify that weight is being added up properly
        /// </summary>
        [TestMethod]
        public void CharacterWeightTest()
        {
           PlayerCharacter pc = CreateTestCharacter();

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

        /// <summary>
        /// Check that the Weight Status returns the weight status
        /// </summary>
        [TestMethod]
        public void CharacterBurdenTest()
        {
            PlayerCharacter pc = CreateTestCharacter();

            ArmorCatalog armorCatalog = new ArmorCatalog();
            pc.EquipArmor(armorCatalog.BodyArmor[ArmorType.ScaleMail]);

            Assert.AreEqual(pc.GetCurrentWeightStatus(), PCStatics.WeightStatus.Unencumbered);

            WeaponAccessor weaponCatalog = new WeaponAccessor();
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Battle axe"]);

            Assert.AreEqual(pc.GetCurrentWeightStatus(), PCStatics.WeightStatus.Light);

            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);

            Assert.AreEqual(pc.GetCurrentWeightStatus(), PCStatics.WeightStatus.Moderate);

            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);

            Assert.AreEqual(pc.GetCurrentWeightStatus(), PCStatics.WeightStatus.HeavyLaden);

            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);

            Assert.AreEqual(pc.GetCurrentWeightStatus(), PCStatics.WeightStatus.Severe);

            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);
            pc.EquipWeapon(weaponCatalog.MeleeWeaponsCatalog["Footman's mace"]);

            Assert.AreEqual(pc.GetCurrentWeightStatus(), PCStatics.WeightStatus.Overloaded);


        }
    }
}
