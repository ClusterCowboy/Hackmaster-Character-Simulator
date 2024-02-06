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
    }
}
