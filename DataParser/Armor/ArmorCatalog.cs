using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armor
{
    public class ArmorCatalog
    {

        public Dictionary<ArmorType, Armor> BodyArmor = new Dictionary<ArmorType, Armor>();


        public ArmorCatalog()
        {
            Armor Robes = new Armor()
            {
                ItemName = "Robes",
                CurrentAC = 9,
                MaxAC = 9,
                Weight = 5,
                Bulk = GenericEnums.GenericEnums.ItemBulk.non,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int,int> { { 9, 1 } },
                ArmorType = ArmorType.Robes,
                Value = 1
            };
            Armor Leather = new Armor()
            {
                ItemName = "Leather",
                CurrentAC = 8,
                MaxAC = 8,
                Weight = 15,
                Bulk = GenericEnums.GenericEnums.ItemBulk.non,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.Leather,
                Value = 5
            };
            Armor Padded = new Armor()
            {
                ItemName = "Padded",
                CurrentAC = 8,
                MaxAC = 8,
                Weight = 10,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.Padded,
                Value = 4
            };
            Armor RingMail = new Armor()
            {
                ItemName = "Ring Mail",
                CurrentAC = 7,
                MaxAC = 7,
                Weight = 30,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 7, 6 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 7, 6 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.RingMail,
                Value = 65
            };
            Armor StuddedLeather = new Armor()
            {
                ItemName = "Studded Leather",
                CurrentAC = 7,
                MaxAC = 7,
                Weight = 25,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.StuddedLeather,
                Value = 40
            };
            Armor ScaleMail = new Armor()
            {
                ItemName = "Scale Mail",
                CurrentAC = 6,
                MaxAC = 6,
                Weight = 40,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 6, 7 },  { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 6, 7 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.ScaleMail,
                Value = 120
            };
            Armor Hide = new Armor()
            {
                ItemName = "Hide",
                CurrentAC = 6,
                MaxAC = 6,
                Weight = 35,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 6, 5 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 6, 5 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.Hide,
                Value = 75
            };
            Armor Brigandine = new Armor()
            {
                ItemName = "Brigandine",
                CurrentAC = 6,
                MaxAC = 6,
                Weight = 35,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.Brigandine,
                Value = 120
            };
            Armor ChainMail = new Armor()
            {
                ItemName = "Chain Mail",
                CurrentAC = 5,
                MaxAC = 5,
                Weight = 40,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.ChainMail,
                Value = 350
            };
            Armor ElvenChainMail = new Armor()
            {
                ItemName = "Elven Chain Mail",
                CurrentAC = 5,
                MaxAC = 5,
                Weight = 20,
                Bulk = GenericEnums.GenericEnums.ItemBulk.non,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.ElvenChainMail,
                Value = 700
            };
            Armor BronzePlateMail = new Armor()
            {
                ItemName = "Bronze Plate Mail",
                CurrentAC = 4,
                MaxAC = 4,
                Weight = 45,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 4, 12 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 4, 12 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.BronzePlateMail,
                Value = 1000
            };
            Armor BandedMail = new Armor()
            {
                ItemName = "Banded Mail",
                CurrentAC = 4,
                MaxAC = 4,
                Weight = 35,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 4, 9 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 4, 9 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.BandedMail,
                Value = 900
            };
            Armor SplintMail = new Armor()
            {
                ItemName = "Splint Mail",
                CurrentAC = 4,
                MaxAC = 4,
                Weight = 40,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 4, 8 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 4, 8 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.SplintMail,
                Value = 600
            };
            Armor PlateMail = new Armor()
            {
                ItemName = "Plate Mail",
                CurrentAC = 3,
                MaxAC = 3,
                Weight = 50,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                IsFullOrFieldPlate = false,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 3, 12 }, { 4, 10 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 3, 12 }, { 4, 10 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.PlateMail,
                Value = 2000
            };
            Armor FieldPlate = new Armor()
            {
                ItemName = "Field Plate",
                CurrentAC = 2,
                MaxAC = 2,
                Weight = 60,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                IsFullOrFieldPlate = true,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 2, 12 }, { 3, 12 }, { 4, 10 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 2, 12 }, { 3, 12 }, { 4, 10 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.FieldPlate,
                Value = 4000
            };
            Armor FullPlate = new Armor()
            {
                ItemName = "Full Plate",
                CurrentAC = 1,
                MaxAC = 1,
                Weight = 70,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                IsFullOrFieldPlate = true,
                ArmorHPWhenUndamaged = new Dictionary<int, int> { { 1, 18 }, { 2, 12 }, { 3, 12 }, { 4, 10 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorHPRemaining = new Dictionary<int, int> { { 1, 18 }, { 2, 12 }, { 3, 12 }, { 4, 10 }, { 5, 8 }, { 6, 6 }, { 7, 4 }, { 8, 2 }, { 9, 1 } },
                ArmorType = ArmorType.FullPlate,
                Value = 8000
            };

            BodyArmor.Add(ArmorType.Robes, Robes);
            BodyArmor.Add(ArmorType.Leather, Leather);
            BodyArmor.Add(ArmorType.Padded, Padded);
            BodyArmor.Add(ArmorType.RingMail, RingMail);
            BodyArmor.Add(ArmorType.StuddedLeather, StuddedLeather);
            BodyArmor.Add(ArmorType.ScaleMail, ScaleMail);
            BodyArmor.Add(ArmorType.Hide, Hide);
            BodyArmor.Add(ArmorType.Brigandine, Brigandine);
            BodyArmor.Add(ArmorType.ChainMail, ChainMail);
            BodyArmor.Add(ArmorType.ElvenChainMail, ElvenChainMail);
            BodyArmor.Add(ArmorType.BronzePlateMail, BronzePlateMail);
            BodyArmor.Add(ArmorType.BandedMail, BandedMail);
            BodyArmor.Add(ArmorType.SplintMail, SplintMail);
            BodyArmor.Add(ArmorType.PlateMail, PlateMail);
            BodyArmor.Add(ArmorType.FieldPlate, FieldPlate);
            BodyArmor.Add(ArmorType.FullPlate, FullPlate);
        }
    
        public void ShieldCatalog()
        {
            Shield Buckler = new Shield()
            {
                ItemName = "Buckler",
                CurrentAC = 1,
                MaxAC = 1,
                Weight = 5,
                Bulk = GenericEnums.GenericEnums.ItemBulk.non,
                ShieldHPWhenUndamaged = new Dictionary<int, int> { { 1, 3 } },
                ShieldHPRemaining = new Dictionary<int, int> { { 1, 3 } },
                ShieldType = ShieldType.Buckler,
                Value = 5
            };
            Shield SpikedBuckler = new Shield()
            {
                ItemName = "Buckler",
                CurrentAC = 1,
                MaxAC = 1,
                Weight = 4,
                Bulk = GenericEnums.GenericEnums.ItemBulk.non,
                ShieldHPWhenUndamaged = new Dictionary<int, int> { { 1, 3 } },
                ShieldHPRemaining = new Dictionary<int, int> { { 1, 3 } },
                ShieldType = ShieldType.SpikedBuckler,
                Value = 15
            };
            Shield SmallShield = new Shield()
            {
                ItemName = "Small Shield",
                CurrentAC = 2,
                MaxAC = 2,
                Weight = 5,
                Bulk = GenericEnums.GenericEnums.ItemBulk.non,
                ShieldHPWhenUndamaged = new Dictionary<int, int> { { 2, 4 }, { 1, 3 } },
                ShieldHPRemaining = new Dictionary<int, int> { { 2, 4 }, { 1, 3 } },
                ShieldType = ShieldType.Small,
                Value = 20
            };
            Shield MediumShield = new Shield()
            {
                ItemName = "Medium Shield",
                CurrentAC = 3,
                MaxAC = 3,
                Weight = 10,
                Bulk = GenericEnums.GenericEnums.ItemBulk.fairly,
                ShieldHPWhenUndamaged = new Dictionary<int, int> { { 3, 5 }, { 2, 4 }, { 1, 3 } },
                ShieldHPRemaining = new Dictionary<int, int> { { 3, 5 }, { 2, 4 }, { 1, 3 } },
                ShieldType = ShieldType.Medium,
                Value = 20
            };
            Shield BodyShield = new Shield()
            {
                ItemName = "Body Shield",
                CurrentAC = 4,
                MaxAC = 4,
                Weight = 25,
                Bulk = GenericEnums.GenericEnums.ItemBulk.bulky,
                ShieldHPWhenUndamaged = new Dictionary<int, int> { { 4, 6 }, { 3, 5 }, { 2, 4 }, { 1, 3 } },
                ShieldHPRemaining = new Dictionary<int, int> { { 4, 6 }, { 3, 5 }, { 2, 4 }, { 1, 3 } },
                ShieldType = ShieldType.Body,
                Value = 100
            };
        }
    }
}
