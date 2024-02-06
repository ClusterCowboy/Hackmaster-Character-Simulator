using Universals;
using static Armor.ArmorCatalog;
using static GenericEnums.GenericEnums;

namespace Armor
{
    public enum ArmorType
    {
        Robes,
        Leather,
        Padded,
        RingMail,
        StuddedLeather,
        ScaleMail,
        Hide,
        Brigandine,
        ChainMail,
        ElvenChainMail,
        BronzePlateMail,
        BandedMail,
        SplintMail,
        PlateMail,
        FieldPlate,
        FullPlate
    }

    public class Armor : IWeight, IItemName, IMoney
    {
        public double Weight { get; set; }
        public string ItemName { get; set; }
        public int MaxAC { get; set; }
        public int CurrentAC { get; set; }
        public bool IsFullOrFieldPlate { get; set; }
        // AC, points left
        public Dictionary<int, int> ArmorHPRemaining { get; set; }
        public Dictionary<int, int> ArmorHPWhenUndamaged { get; set; }
        public ItemBulk Bulk { get; set; }
        public ArmorType ArmorType { get; set; }
        public double Value { get; set; }

        /**
* Destroyed Armor cannot be repaired
* */
        public bool ArmorIsDestroyed()
        {
            return ArmorHPRemaining[9] == 0;
        }

        public int ArmorHPLeftAtCurrentLevel() 
        { 
            if (CurrentAC > 9)
            {
                return 0;
            }
            return ArmorHPRemaining[CurrentAC];
        }

        /**
         * Recursively deal with damage
         * */
        public int ProcessDamageAndReturnFinalAmount (int numOfDice, int TotalDamage)
        {
            int damReturned = TotalDamage;

            // Armor which gives an AC of less than 3 subtracts 2 points of damage per die
            if (CurrentAC < 3)
            {
                if (ArmorHPRemaining[CurrentAC] > numOfDice)
                {
                    ArmorHPRemaining[CurrentAC] -= numOfDice;
                    TotalDamage -= (numOfDice * 2);
                    return (TotalDamage <= 0 ? 0 : TotalDamage);
                }
                else
                {
                    TotalDamage -= ArmorHPRemaining[CurrentAC] * 2;
                    numOfDice -= ArmorHPRemaining[CurrentAC];
                    ArmorHPRemaining[CurrentAC] = 0;

                    CurrentAC++;
                    return ProcessDamageAndReturnFinalAmount(numOfDice, TotalDamage);
                }
            }

            if (ArmorHPRemaining[CurrentAC] > numOfDice) 
            {
                ArmorHPRemaining[CurrentAC] -= numOfDice;
                TotalDamage -= numOfDice;
                return (TotalDamage <= 0 ? 0 : TotalDamage);
            }
            else
            {
                TotalDamage -= ArmorHPRemaining[CurrentAC];
                numOfDice -= ArmorHPRemaining[CurrentAC];
                ArmorHPRemaining[CurrentAC] = 0;

                CurrentAC++;
                if (CurrentAC >= 10)
                {
                    return TotalDamage;
                }
                return ProcessDamageAndReturnFinalAmount(numOfDice, TotalDamage);
            }
        }
    }
}
