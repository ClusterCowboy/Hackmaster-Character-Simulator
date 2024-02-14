using Armor;
using PlayerCharacters.Abilities;
using System.Reflection;
using Universals;
using Weapons;
using static GenericEnums.GenericEnums;

namespace PlayerCharacters
{
    [Serializable]
    public class PlayerCharacter
    {
        
        public required string Name { get; set; }
        public List<IWeapon>? Weapons { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public CharacterClasses Class { get; set; }
        public int AC
        {
            get => ((CurrentlyWornArmor == null) ? 10 : CurrentlyWornArmor.CurrentAC)
                + ((CurrentlyWornShield == null) ? 0 : CurrentlyWornShield.CurrentAC)
                + CharacterStats.Dexterity.GetDefenseAdjustment();
        }
        public Armor.Armor? CurrentlyWornArmor { get; set; }
        public Shield? CurrentlyWornShield { get; set; }
        public Helmet? CurrentlyWornHelmet { get; set; }
        public required CharacterStatBlock CharacterStats {  get; set; }

        #region Gear
        public void EquipArmor(Armor.Armor armor)
        {
            if (armor == null)
                CurrentlyWornArmor = new Armor.Armor();
            CurrentlyWornArmor = armor;
        }

        public void EquipWeapon(IWeapon weapon) 
        { 
            if (Weapons == null)
            {
                Weapons = new List<IWeapon> { weapon };
            }
            else
            {
                Weapons.Add(weapon);
            }
        }
        #endregion

        #region Combat
        public int GetMeleeAttackBonus() { return CharacterStats.Strength.GetMeleeHitProb(); }
        public int GetMeleeDamageBonus() { return CharacterStats.Strength.GetMeleeDamageAdj(); }
        public int GetRangedAttackBonus() { return CharacterStats.Dexterity.GetMissileAdjustment(); }
        #endregion

        #region Feats Of Strength
        public bool AttemptOpenDoor() =>
            Dice.Instance.D20CheckUnderPass(CharacterStats.Strength.GetOpenDoor());
        public bool AttemptOpenLockedBarredMagicalDoor() =>
            Dice.Instance.D20CheckUnderPass(CharacterStats.Strength.GetOpenLockedBarredMagicallyHeldDoor());
        public bool AttemptBendBarsLiftGates() =>
            Dice.Instance.D20CheckUnderPass(CharacterStats.Strength.GetBendBarsLiftGates());
        #endregion

        #region Weight Amounts
        public double GetCurrentWeightCarried()
        {
            double weight = 0;

            var weightProperties = GetType().GetProperties()
            .Where(prop => prop.PropertyType.GetInterfaces().Contains(typeof(IWeight)))
            .ToList();

            // This will get every object which implements the IWeight interface.
            // All of them save those which are in containers like dictionaries or 
            // Lists. Those MUST be gotten separately.
            foreach (var property in weightProperties)
            {
                var weightObject = property.GetValue(this) as IWeight;
                if (weightObject != null)
                {
                    Console.WriteLine(property.Name + " " + weightObject.Weight);
                    weight += weightObject.Weight;
                }
            }

            if (null != Weapons)
            {
                foreach (IWeapon weapon in Weapons)
                {
                    weight += weapon.Weight;
                }
            }

            return weight;
            //double totalCarried = (CurrentlyWornArmor == null) ? 0 : CurrentlyWornArmor.Weight;
            //totalCarried += (CurrentlyWornShield == null) ? 0 : CurrentlyWornShield.Weight;
            //totalCarried += (CurrentlyWornHelmet == null) ? 0 : CurrentlyWornHelmet.Weight;
            //if (Weapons != null)
            //{
            //    totalCarried += Weapons.Sum(x => x.Weight);
            //}

            //return totalCarried;
        }
        public int GetCurrentWeightAllowance() =>
            CharacterStats.Strength.GetWeightAllowance();
        #endregion
    }
}
