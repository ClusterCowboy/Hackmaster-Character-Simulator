using System.Text.Json.Serialization;
using static GenericEnums.GenericEnums;
using static Universals.Magic;

namespace Spells
{
    public abstract class Spell
    {
        public string SpellName { get; set; }
        public int SpellLevel { get; set; }
        public List<SchoolOfMagic> SpellSchool { get; set; }

        #region Duration
        public int BaseDuration { get; set; }
        public int DurationPerLevel { get; set; }
        public Time DurationUnits { get; set; }
        #endregion

        #region Range
        public int BaseRange { get; set; }
        public int RangeIncrementPerLevel { get; set; }
        public Distances RangeUnits { get; set; }
        #endregion

        #region Components
        public bool HasVerbalComponents { get; set; }
        public bool HasSomaticComponents { get; set; }
        public bool HasMaterialComponents { get; set; }
        #endregion

        #region Casting Time
        public double CastingTimeValue { get; set; }
        public Time CastingTimeUnit { get; set; }
        #endregion

        public string AreaOfEffect { get; set; }
        public SpellSavingThrowType SavingThrowType { get; set; }
        public string Description { get; set; }
    }
}
