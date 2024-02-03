using System.Runtime.Serialization;
using Universals;
using static GenericEnums.GenericEnums;

namespace Weapons
{
    [Serializable]
    public class MeleeWeapon : IWeapon, IMoney, ISerializable
    {
        public required string ItemName { get; set; }
        public double Value { get; set; }
        public double _weight { get; set; }
        public Size _weaponSize { get; set; }
        public WeaponType WeaponDamageType { get; set; }
        public int SpeedFactor { get; set; }
        public required Dice _tinyDice { get; set; }
        public required Dice _smallDice { get; set; }
        public required Dice _mediumDice { get; set; }
        public required Dice _largeDice { get; set; }
        public required Dice _hugeDice { get; set; }
        public required Dice _gargantuanDice { get; set; }
        public int _avaHi { get; set; }
        public int _avaMid { get; set; }
        public int _avaLow { get; set; }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(ItemName), ItemName);
            info.AddValue(nameof(Value), Value);
            info.AddValue(nameof(_weight), _weight);
            info.AddValue(nameof(WeaponDamageType), WeaponDamageType);
            info.AddValue(nameof(_weaponSize), _weaponSize);
            info.AddValue(nameof(SpeedFactor), SpeedFactor);
            info.AddValue(nameof(_tinyDice), _tinyDice);
            info.AddValue(nameof(_smallDice), _smallDice);
            info.AddValue(nameof(_mediumDice), _mediumDice);
            info.AddValue(nameof(_largeDice), _largeDice);
            info.AddValue(nameof(_hugeDice), _hugeDice);
            info.AddValue(nameof(_gargantuanDice), _gargantuanDice);
            info.AddValue(nameof(_avaHi), _avaHi);
            info.AddValue(nameof(_avaMid), _avaMid);
            info.AddValue(nameof(_avaLow), _avaLow);
        }

        public int RollDice(Size size, int modifier)
        {
            switch (size)
            {
                case Size.T:
                    return ((IWeapon)this)._tinyDice.Roll(modifier);
                case Size.S:
                    return ((IWeapon)this)._smallDice.Roll(modifier);
                case Size.M:
                    return ((IWeapon)this)._mediumDice.Roll(modifier);
                case Size.L:
                    return ((IWeapon)this)._largeDice.Roll(modifier);
                case Size.H:
                    return ((IWeapon)this)._hugeDice.Roll(modifier);
                case Size.G:
                    return ((IWeapon)this)._gargantuanDice.Roll(modifier);
                default:
                    return 0;
            }
        }
    }
}
