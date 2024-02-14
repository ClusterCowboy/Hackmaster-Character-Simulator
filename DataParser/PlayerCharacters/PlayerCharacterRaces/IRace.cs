using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacters.PlayerCharacterRaces
{
    public interface IRace
    {
        string Name { get; }
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

        int GetInfravisionDistance() { return 0; }

        int GetBuildingPointBonus() { return 0; }
    }
}
