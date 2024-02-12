using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEnums
{
    public static class GenericEnums
    {
        #region Sizes
        public enum Size { T, S, M, L, H, G };

        public static string TranslateSize(Size size)
        {
            switch (size)
            {
                case Size.T:
                    return "Tiny";
                case Size.S:
                    return "Small";
                case Size.M:
                    return "Medium";
                case Size.L:
                    return "Large";
                case Size.H:
                    return "Huge";
                case Size.G:
                    return "Gargantuan";
                default:
                    return "";

            }
        }
        #endregion

        #region Armor Enums
        public enum ItemBulk { non, fairly, bulky }
        #endregion

        #region Weapon Enums
        public enum WeaponType { H, C, P, H_C, H_P, C_P };

        public static string TranslateWeaponType(WeaponType wt)
        {
            switch (wt)
            {
                case WeaponType.H:
                    return "Hacking";
                case WeaponType.C:
                    return "Crushing";
                case WeaponType.P:
                    return "Piercing";
                default:
                    return "";

            }
        }

        public enum WeaponStyle { Melee, Polearm, Ranged }
        #endregion

        #region Class Enums
        public enum CharacterArchtypes
        {
            Fighter,
            Thief,
            Cleric,
            MagicUser
        }

        public enum CharacterClasses {
            Fighter,
            Barbarian,
            Berserker,
            Cavalier,
            DarkKnight,
            KnightErrant,
            Monk,
            Paladin,
            Ranger,
            MagicUser,
            BattleMage,
            Illusionist,
            Cleric,
            Druid,
            Thief,
            Assassin,
            Bard
        }

        /***
         * Translate a class into the archtype. Important for attack matrix, saving throws,
         * etc.
         * */
        public static CharacterArchtypes GetArchtype(CharacterClasses c)
        {
            switch (c)
            {
                case CharacterClasses.Fighter:
                case CharacterClasses.Barbarian:
                case CharacterClasses.Berserker:
                case CharacterClasses.Cavalier:
                case CharacterClasses.DarkKnight:
                case CharacterClasses.KnightErrant:
                case CharacterClasses.Monk:
                case CharacterClasses.Paladin:
                case CharacterClasses.Ranger:
                    return CharacterArchtypes.Fighter;
                case CharacterClasses.MagicUser:
                case CharacterClasses.BattleMage:
                case CharacterClasses.Illusionist:
                    return CharacterArchtypes.MagicUser;
                case CharacterClasses.Cleric:
                case CharacterClasses.Druid:
                    return CharacterArchtypes.Cleric;
                case CharacterClasses.Thief:
                case CharacterClasses.Assassin:
                case CharacterClasses.Bard:
                    return CharacterArchtypes.Thief;
                default:
                    return CharacterArchtypes.Fighter;
            }
        }
        #endregion

        #region Saving Throws
        public enum SavingThrowCategories {
            ParalyzationPoisonDeathMagic = 0,
            RodStaffWand,
            PetrificationHackFrenzyHackLustPolymorph,
            BreathWeapon,
            Apology,
            Spells
        }
        #endregion

        #region Time
        public enum Time
        {
            Segments,
            MeleeRounds,
            Rounds,
            Turns
        }

        private static readonly Dictionary<Time, double> SegmentTo = new Dictionary<Time, double>
        {
            { Time.Segments, 1},
            { Time.MeleeRounds, .1},
            { Time.Rounds, .01},
            { Time.Turns, .001}
        };
        private static readonly Dictionary<Time, double> MeleeRoundTo = new Dictionary<Time, double>
        {
            { Time.Segments, 10},
            { Time.MeleeRounds, 1},
            { Time.Rounds, .1},
            { Time.Turns, .01}
        };
        private static readonly Dictionary<Time, double> RoundsTo = new Dictionary<Time, double>
        {
            { Time.Segments, 100},
            { Time.MeleeRounds, 10},
            { Time.Rounds, 1},
            { Time.Turns, .1}
        };
        private static readonly Dictionary<Time, double> TurnsTo = new Dictionary<Time, double>
        {
            { Time.Segments, 1000},
            { Time.MeleeRounds, 100},
            { Time.Rounds, 10},
            { Time.Turns, 1}
        };

        public static double ConvertTimeToTime(double value, Time unitFrom, Time unitTo)
        {
            switch (unitFrom)
            {
                case Time.Segments:
                    return SegmentTo[unitTo] * value;
                case Time.MeleeRounds: 
                    return MeleeRoundTo[unitTo] * value;
                case Time.Rounds:
                    return RoundsTo[unitTo] * value;
                case Time.Turns:
                    return TurnsTo[unitTo] * value;
            }
            return 0;
        }
        #endregion

        #region Distances
        private static readonly Dictionary<Distances, double> FeetTo = new Dictionary<Distances, double>
        {
            { Distances.Feet, 1},
            { Distances.Yards, (1.0/3.0)}
        };
        private static readonly Dictionary<Distances, double> YardsTo = new Dictionary<Distances, double>
        {
            { Distances.Feet, 3},
            { Distances.Yards, 1}
        };
        public enum Distances
        {
            Feet,
            Yards
        }

        public static double ConvertDistToDist(double value, Distances unitFrom, Distances unitTo)
        {
            switch (unitFrom)
            {
                case Distances.Feet:
                    return FeetTo[unitTo] * value;
                case Distances.Yards:
                    return YardsTo[unitTo] * value;
            }
            return 0;
        }
        #endregion

    }
}
