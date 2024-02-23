using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universals;
using Weapons;
using static GenericEnums.GenericEnums;

namespace PlayerCharacters.Classes
{
    public class Fighter : ICharacterClass
    {
        public string ClassName => "Fighter";

        public int HitDie => 10;

        public int NonProficentWeaponPenalty => -2;

        public int InitialWeaponProficiencySlots => 4;

        public int NumberOfLevelsBetweenProficiencySlots => 2;

        public Dictionary<int, int> AC20Range
        {
            get => new Dictionary<int, int>
            {
                { 1 , -2 },
                { 2 , -3 },
                { 3 , -4 },
                { 4 , -5 },
                { 5 , -6 },
                { 6 , -7 },
                { 7 , -8 },
                { 8 , -9 },
                { 9 , -10 },
                { 10  , -11 },
                { 11  , -12 },
                { 12  , -13 },
                { 13  , -14 },
                { 14  , -15 },
                { 15  , -16 },
                { 16  , -17 },
                { 17  , -18 },
                { 18  , -19 },
                { 19  , -20 },
                { 20  , -21 },
                { 21  , -22 }
            };
        }
        public int Level { get; set; } = 1;
        public List<IWeapon>? WeaponProficiencies { get; set; }

        public bool SaveVs(SavingThrowCategories type, int modifier) =>
            Di.ce.D20CheckUnderPass(CharacterClassDBInterface.Instance.fighterSavingThrows[Level][type], modifier);

    }
}
