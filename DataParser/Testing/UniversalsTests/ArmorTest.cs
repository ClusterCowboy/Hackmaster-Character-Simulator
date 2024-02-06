
using Armor;
using Universals;
using static Armor.ArmorCatalog;

namespace Testing.UniversalsTests
{
    [TestClass]
    public class ArmorTest
    {
        [TestMethod]
        public void FullPlateTesterFireball()
        {
            ArmorCatalog catalog = new ArmorCatalog();
            Armor.Armor fullPlate = catalog.BodyArmor[ArmorType.FullPlate];
            // 10th level fireball
            int numOfDice = 10;
            int totalDamage = 36;
            int finalDamage = fullPlate.ProcessDamageAndReturnFinalAmount(numOfDice, totalDamage);
            Assert.AreEqual(totalDamage - 20, finalDamage, "Damage Check");
            Assert.AreEqual(fullPlate.CurrentAC, 1, "Current AC Check");
            Assert.AreEqual(fullPlate.ArmorHPLeftAtCurrentLevel(), 8, "Armor HP left at Current Level");
            Assert.AreEqual(fullPlate.ArmorIsDestroyed(), false, "Is Armor Destroyed");
        }

        [TestMethod]
        public void FullPlateTester4Fireballs()
        {
            ArmorCatalog catalog = new ArmorCatalog();
            Armor.Armor fullPlate = catalog.BodyArmor[ArmorType.FullPlate];
            // 10th level fireball
            int numOfDice = 10;
            int totalDamage = 36;
            int finalDamage = fullPlate.ProcessDamageAndReturnFinalAmount(numOfDice, totalDamage);
            Assert.AreEqual(totalDamage - 20, finalDamage);
            Assert.AreEqual(fullPlate.CurrentAC, 1);
            Assert.AreEqual(fullPlate.ArmorHPLeftAtCurrentLevel(), 8);
            Assert.AreEqual(fullPlate.ArmorIsDestroyed(), false);

            finalDamage = fullPlate.ProcessDamageAndReturnFinalAmount(numOfDice, totalDamage);
            Assert.AreEqual(totalDamage - 20, finalDamage);
            Assert.AreEqual(fullPlate.CurrentAC, 2);
            Assert.AreEqual(fullPlate.ArmorHPLeftAtCurrentLevel(), 10);
            Assert.AreEqual(fullPlate.ArmorIsDestroyed(), false);

            finalDamage = fullPlate.ProcessDamageAndReturnFinalAmount(numOfDice, totalDamage);
            Assert.AreEqual(totalDamage - 20, finalDamage);
            Assert.AreEqual(fullPlate.CurrentAC, 3);
            Assert.AreEqual(fullPlate.ArmorHPLeftAtCurrentLevel(), 12);
            Assert.AreEqual(fullPlate.ArmorIsDestroyed(), false);

            finalDamage = fullPlate.ProcessDamageAndReturnFinalAmount(numOfDice, totalDamage);
            Assert.AreEqual(totalDamage - 10, finalDamage);
            Assert.AreEqual(fullPlate.CurrentAC, 3);
            Assert.AreEqual(fullPlate.ArmorHPLeftAtCurrentLevel(), 2);
            Assert.AreEqual(fullPlate.ArmorIsDestroyed(), false);
        }

        [TestMethod]
        public void PaddedArmorFireball()
        {
            ArmorCatalog catalog = new ArmorCatalog();
            Armor.Armor padded = catalog.BodyArmor[ArmorType.Padded];
            // 10th level fireball
            int numOfDice = 10;
            int totalDamage = 36;
            int finalDamage = padded.ProcessDamageAndReturnFinalAmount(numOfDice, totalDamage);
            Assert.AreEqual(totalDamage - 3, finalDamage);
            Assert.AreEqual(padded.CurrentAC, 10);
            Assert.AreEqual(padded.ArmorHPLeftAtCurrentLevel(), 0);
            Assert.AreEqual(padded.ArmorIsDestroyed(), true);

        }

    }
}
