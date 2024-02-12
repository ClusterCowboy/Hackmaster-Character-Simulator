using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Spells
{
    [Serializable]
    public class MagicUserSpell : Spell
    {
        /*
         * 
         * MagicUserSpell s = new MagicUserSpell()
        {
            SpellName = "Magic Missile",
            SpellLevel = 1,
            SpellSchool = new List<Magic.SchoolOfMagic> { Magic.SchoolOfMagic.Evocation },
            
            BaseDuration = 0,
            DurationPerLevel = 0,
            DurationUnits = Time.Segments,
            
            BaseRange = 60,
            RangeIncrementPerLevel = 10,
            RangeUnits = Distances.Yards,
            
            HasVerbalComponents = true,
            HasSomaticComponents    = true,
            HasMaterialComponents = true,

            CastingTimeValue = 1,
            CastingTimeUnit = Time.Segments,

            AreaOfEffect = "Single Target",
            SavingThrowType = Magic.SpellSavingThrowType.None,
            Description = ""

        };*/

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("SpellName", SpellName);
            info.AddValue("Level", SpellLevel);
            info.AddValue("Schools", SpellSchool);

            info.AddValue("BaseDuration", BaseDuration);
            info.AddValue("DurationPerLevel", DurationPerLevel);
            info.AddValue("DurationUnits", DurationUnits);

            info.AddValue("BaseRange", BaseRange);
            info.AddValue("RangeIncrementPerLevel", RangeIncrementPerLevel);
            info.AddValue("RangeUnits", RangeUnits);

            info.AddValue("HasVerbalComponents", HasVerbalComponents);
            info.AddValue("HasSomaticComponents", HasSomaticComponents);
            info.AddValue("HasMaterialComponents", HasMaterialComponents);
            
            info.AddValue("CastingTimeValue", CastingTimeValue);
            info.AddValue("CastingTimeUnit", CastingTimeUnit);
            
            info.AddValue("AreaOfEffect", AreaOfEffect);
            info.AddValue("SavingThrowType", SavingThrowType);
            info.AddValue("Description", Description);
        }
    }

}
