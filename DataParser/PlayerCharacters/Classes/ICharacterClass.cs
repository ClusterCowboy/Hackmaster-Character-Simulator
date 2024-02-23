using Universals;
using Weapons;
using static GenericEnums.GenericEnums;

namespace PlayerCharacters.Classes
{
    public interface ICharacterClass
    {
        public string ClassName { get; }
        public int HitDie { get; }
        public int Level { get; set; }
        public Dictionary<int, int> AC20Range { get; }
        public int NonProficentWeaponPenalty { get; }
        public int InitialWeaponProficiencySlots { get; }
        public int NumberOfLevelsBetweenProficiencySlots { get; }
        public List<IWeapon>? WeaponProficiencies { get; set;  }


        public int RollToHitAC(int toHitModifier, bool isProficent = true)
        {
            int dieRoll = Di.ce.Roll(1, 20, toHitModifier) + (isProficent ? 0 : NonProficentWeaponPenalty);

            if (dieRoll == 20)
            {
                return AC20Range[Level];
            }
            else if (dieRoll > 20)
            {
                return (AC20Range[Level] - 5) - (dieRoll - 20);
            }
            else
            {
                return AC20Range[Level] + (20 - dieRoll);
            }
        }

        public int GetBaseSeverityLevel(int enemyAC, int toHitModifier) =>
            enemyAC 
                - (AC20Range[Level] + 15) // Chance to hit AC 15 
                + toHitModifier
                + Di.ce.RollExplodingDice(1, 8);

        public bool SaveVs(SavingThrowCategories type, int modifier);

        
    }
}
