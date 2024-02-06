using System.Runtime.Serialization;
using Universals;
using static GenericEnums.GenericEnums;

namespace Weapons
{
    [Serializable]
    public class MeleeWeapon : IWeapon, IWeight, IItemName, IMoney, ISerializable
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public Size _weaponSize { get; set; }
        public WeaponType WeaponDamageType { get; set; }
        public int SpeedFactor { get; set; }
        public int tinyDiceNum { get; set; }
        public int tinyDiceSides { get; set; }
        public int tinyDiceMod { get; set; }
        public int smallDiceNum { get; set; }
        public int smallDiceSides { get; set; }
        public int smallDiceMod { get; set; }
        public int mediumDiceNum { get; set; }
        public int mediumDiceSides { get; set; }
        public int mediumDiceMod { get; set; }
        public int largeDiceNum { get; set; }
        public int largeDiceSides { get; set; }
        public int largeDiceMod { get; set; }
        public int hugeDiceNum { get; set; }
        public int hugeDiceSides { get; set; }
        public int hugeDiceMod { get; set; }
        public int gargantuanDiceNum { get; set; }
        public int gargantuanDiceSides { get; set; }
        public int gargantuanDiceMod { get; set; }
        public int _avaHi { get; set; }
        public int _avaMid { get; set; }
        public int _avaLow { get; set; }


        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(ItemName), ItemName);
            info.AddValue(nameof(Value), Value);
            info.AddValue(nameof(Weight), Weight);
            info.AddValue(nameof(WeaponDamageType), WeaponDamageType);
            info.AddValue(nameof(_weaponSize), _weaponSize);
            info.AddValue(nameof(SpeedFactor), SpeedFactor);
            info.AddValue(nameof(tinyDiceNum), tinyDiceNum);
            info.AddValue(nameof(tinyDiceSides), tinyDiceSides);
            info.AddValue(nameof(tinyDiceMod), tinyDiceMod);
            info.AddValue(nameof(smallDiceNum), smallDiceNum);
            info.AddValue(nameof(smallDiceSides), smallDiceSides);
            info.AddValue(nameof(smallDiceMod), smallDiceMod);
            info.AddValue(nameof(mediumDiceNum), mediumDiceNum);
            info.AddValue(nameof(mediumDiceSides), mediumDiceSides);
            info.AddValue(nameof(mediumDiceMod), mediumDiceMod);
            info.AddValue(nameof(largeDiceNum), largeDiceNum);
            info.AddValue(nameof(largeDiceSides), largeDiceSides);
            info.AddValue(nameof(largeDiceMod), largeDiceMod);
            info.AddValue(nameof(hugeDiceNum), hugeDiceNum);
            info.AddValue(nameof(hugeDiceSides), hugeDiceSides);
            info.AddValue(nameof(hugeDiceMod), hugeDiceMod);
            info.AddValue(nameof(gargantuanDiceNum), gargantuanDiceNum);
            info.AddValue(nameof(gargantuanDiceSides), gargantuanDiceSides);
            info.AddValue(nameof(gargantuanDiceMod), gargantuanDiceMod);
            info.AddValue(nameof(_avaHi), _avaHi);
            info.AddValue(nameof(_avaMid), _avaMid);
            info.AddValue(nameof(_avaLow), _avaLow);
        }

        public int RollDice(Size size, int modifier)
        {
            switch (size)
            {
                case Size.T:
                    return Dice.Instance.RollExplodingDice(tinyDiceNum, tinyDiceSides, tinyDiceMod + modifier);
                case Size.S:
                    return Dice.Instance.RollExplodingDice(smallDiceNum, smallDiceSides, smallDiceMod + modifier);
                case Size.M:
                    return Dice.Instance.RollExplodingDice(mediumDiceNum, mediumDiceSides, mediumDiceMod + modifier);
                case Size.L:
                    return Dice.Instance.RollExplodingDice(largeDiceNum, largeDiceSides, largeDiceMod + modifier);
                case Size.H:
                    return Dice.Instance.RollExplodingDice(hugeDiceNum, hugeDiceSides, hugeDiceMod + modifier);
                case Size.G:
                    return Dice.Instance.RollExplodingDice(gargantuanDiceNum, gargantuanDiceSides, gargantuanDiceMod + modifier);
                default:
                    return 0;
            }
        }
    }
}
