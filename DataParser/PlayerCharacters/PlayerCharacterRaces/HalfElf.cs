using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public class HalfElf : IRace
    {
        public string Name => "Half-Elf";

        public int SpeedRating => 12;

        public int StrRacialModifier => 0;

        public int StrMax => 18;

        public int StrMin => 3;

        public int DexRacialModifier => 0;

        public int DexMax => 18;

        public int DexMin => 6;

        public int ConRacialModifier => 0;

        public int ConMax => 18;

        public int ConMin => 6;

        public int IntRacialModifier => 0;

        public int IntMax => 18;

        public int IntMin => 4;

        public int WisRacialModifier => 0;

        public int WisMax => 18;

        public int WisMin => 3;

        public int ChaRacialModifier => 0;

        public int ChaMax => 18;

        public int ChaMin => 3;

        public int ComRacialModifier => 1;

        public int ComMax => 17;

        public int ComMin => 5;

        public Dictionary<PCStatics.ClassList, int> ClassList => new Dictionary<PCStatics.ClassList, int>
        {
            {PCStatics.ClassList.Cleric, 14},
            {PCStatics.ClassList.Druid, 14},
            {PCStatics.ClassList.Fighter, 14},
            {PCStatics.ClassList.Barbarian, -1},
            {PCStatics.ClassList.Berserker, 14},
            {PCStatics.ClassList.Cavalier, -1},
            {PCStatics.ClassList.DarkKnight, -1},
            {PCStatics.ClassList.KnightErrant, 14},
            {PCStatics.ClassList.Paladin, -1},
            {PCStatics.ClassList.Ranger, 16},
            {PCStatics.ClassList.MagicUser, 12},
            {PCStatics.ClassList.BattleMage, 10},
            {PCStatics.ClassList.Illusionist, -1},
            {PCStatics.ClassList.Thief, 99},
            {PCStatics.ClassList.Assassin, 11},
            {PCStatics.ClassList.Bard, 99}
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
