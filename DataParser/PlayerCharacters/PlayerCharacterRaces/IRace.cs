using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlayerCharacters.PCStatics;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public interface IRace
    {
        string Name { get; }

        // This is table 16A in the PHB
        int SpeedRating { get; }

        #region Stats
        #region Strength
        int StrRacialModifier { get; }
        int StrMax { get; }
        int StrMin { get; }
        #endregion

        #region Dexterity
        int DexRacialModifier { get; }
        int DexMax { get; }
        int DexMin { get; }
        #endregion

        #region Constitution
        int ConRacialModifier { get; }
        int ConMax { get; }
        int ConMin { get; }
        #endregion

        #region Intelligence
        int IntRacialModifier { get; }
        int IntMax { get; }
        int IntMin { get; }
        #endregion

        #region Wisdom
        int WisRacialModifier { get; }
        int WisMax { get; }
        int WisMin { get; }
        #endregion

        #region Charisma
        int ChaRacialModifier { get; }
        int ChaMax { get; }
        int ChaMin { get; }
        #endregion

        #region Comeliness
        int ComRacialModifier { get; }
        int ComMax { get; }
        int ComMin { get; }
        #endregion
        #endregion

        #region Physical Characteristics
        public int CurrentAge { get; set; }
        public int MaxAge { get; set; }
        public void GenerateStartingAge(int ageModifierFromClass);
        public Handedness Handedness { get; set; }
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }
        public void GenerateHeightAndWeight();
        public SocialClass SocialClass { get; set; }
        public int GetCircumstancesOfBirthRacialMod { get; }
        public int GetIllegitimateBirthRacialMod { get; }
        #endregion

        int GetInfravisionDistance() { return 0; }

        int GetBuildingPointBonus() { return 0; }

        public Dictionary<ClassList, int> ClassList { get; }
    }
}
