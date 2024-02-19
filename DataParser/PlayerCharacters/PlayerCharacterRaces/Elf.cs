using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public class Elf : IRace
    {
        public string Name => "Elf";

        public int SpeedRating => 12;

        public int StrRacialModifier => 0;

        public int StrMax => 18;

        public int StrMin => 7;

        public int DexRacialModifier => 1;

        public int DexMax => 19;

        public int DexMin => 7;

        public int ConRacialModifier => -1;

        public int ConMax => 18;

        public int ConMin => 6;

        public int IntRacialModifier => 0;

        public int IntMax => 18;

        public int IntMin => 8;

        public int WisRacialModifier => 0;

        public int WisMax => 18;

        public int WisMin => 3;

        public int ChaRacialModifier => 0;

        public int ChaMax => 18;

        public int ChaMin => 8;

        public int ComRacialModifier => 1;

        public int ComMax => 18;

        public int ComMin => 5;

        public Dictionary<PCStatics.ClassList, int> ClassList => new Dictionary<PCStatics.ClassList, int>
        {
            {PCStatics.ClassList.Cleric, 13},
            {PCStatics.ClassList.Druid, 13},
            {PCStatics.ClassList.Fighter, 12},
            {PCStatics.ClassList.Barbarian, -1},
            {PCStatics.ClassList.Berserker, 13},
            {PCStatics.ClassList.Cavalier, 13},
            {PCStatics.ClassList.DarkKnight, -1},
            {PCStatics.ClassList.KnightErrant, 12},
            {PCStatics.ClassList.Paladin, -1},
            {PCStatics.ClassList.Ranger, 15},
            {PCStatics.ClassList.MagicUser, 15},
            {PCStatics.ClassList.BattleMage, 15},
            {PCStatics.ClassList.Illusionist, -1},
            {PCStatics.ClassList.Thief, 12},
            {PCStatics.ClassList.Assassin, 10},
            {PCStatics.ClassList.Bard, -1}
        };

        #region Physical Characteristics
        public int CurrentAge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxAge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PCStatics.Handedness Handedness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HeightInInches { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WeightInPounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PCStatics.SocialClass SocialClass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetCircumstancesOfBirthRacialMod => throw new NotImplementedException();

        public int GetIllegitimateBirthRacialMod => throw new NotImplementedException();

        public void GenerateHeightAndWeight()
        {
            throw new NotImplementedException();
        }

        public void GenerateStartingAge(int ageModifierFromClass)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
