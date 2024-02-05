using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEnums
{
    public static class GenericEnums
    {
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
    }
}
