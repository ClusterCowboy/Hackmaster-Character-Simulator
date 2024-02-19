using Armor;
using PlayerCharacters.Abilities;
using PlayerCharacters.CharacterGeneration;
using PlayerCharacters.PlayerCharacterRaces;
using System.Reflection;
using Universals;
using Weapons;
using static GenericEnums.GenericEnums;
using static PlayerCharacters.PCStatics;

namespace PlayerCharacters
{
    [Serializable]
    public class PlayerCharacter
    {
        
        public required string Name { get; set; }
        public required IRace Race { get; set; }
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
        private WeightStatus CurrentWeightStatus { get; set; } = WeightStatus.Unencumbered;
        private double CurrentWeightCarried { get; set; } = 0;

        #region Gear
        public void EquipArmor(Armor.Armor armor)
        {
            if (armor == null)
                CurrentlyWornArmor = new Armor.Armor();
            CurrentlyWornArmor = armor;
            UpdateWeightStatus();
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
            UpdateWeightStatus();
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

            // TODO: Implement inventory 

            return weight;
        }
        public double GetCurrentWeightAllowance() =>
            CharacterStats.Strength.GetWeightAllowance();
        public double GetMaxWeightCarried() =>
            CharacterStats.Strength.GetMaxCarryWeight();

        /// <summary>
        /// This function should be called every time the character's inventory
        /// is modified
        /// </summary>
        private void UpdateWeightStatus()
        {
            CurrentWeightCarried = GetCurrentWeightCarried();
            if (CharacterStats.Strength.GetWeightAllowance() >= CurrentWeightCarried)
            {
                CurrentWeightStatus = WeightStatus.Unencumbered;
            }
            else if (CharacterStats.Strength.GetLightEncumbrance() >= CurrentWeightCarried)
            {
                CurrentWeightStatus = WeightStatus.Light;
            }
            else if (CharacterStats.Strength.GetWeightModerate() >= CurrentWeightCarried)
            {
                CurrentWeightStatus = WeightStatus.Moderate;
            }
            else if (CharacterStats.Strength.GetWeightHeavyLaden() >= CurrentWeightCarried)
            {
                CurrentWeightStatus = WeightStatus.HeavyLaden;
            }
            else if (CharacterStats.Strength.GetMaxCarryWeight() >= CurrentWeightCarried)
            {
                CurrentWeightStatus = WeightStatus.Severe;
            }
            else
            {
                CurrentWeightStatus = WeightStatus.Overloaded;
            }

        }

        public WeightStatus GetCurrentWeightStatus() => CurrentWeightStatus;
        #endregion

        #region Character Generation
        public Family? CharactersFamily { get; private set; }



        #endregion

        #region First Level
        /// <summary>
        /// TODO: Ensure character can only be generated once
        /// </summary>
        public void InitialGeneration_AutoGenerate()
        {
            // First, choose Race because the Min/Max number matter
            // TODO: Number of races updated as we go up
            switch (Random.Shared.Next(0, 3))
            {
                case 0:
                    Race = new Elf(); break;
                case 1:
                    Race = new HalfElf(); break;
                case 2:
                    Race = new Dwarf(); break;
                default:
                    Race = new Human(); break;
            }

            // Now, generate the stats based on the race
            CharacterStats = new CharacterStatBlock()
            {
                Strength = new Strength(Race.StrMax, Race.StrMin),
                Dexterity = new Dexterity(Race.DexMax, Race.DexMin),
                Constitution = new Constitution(Race.ConMax, Race.ConMin),
                Intelligence = new Intelligence(Race.IntMax, Race.IntMin),
                Wisdom = new Wisdom(Race.WisMax, Race.WisMin),
                Charisma = new Charisma(Race.ChaMax, Race.ChaMin),
                Comeliness = new Comeliness(Race.ComMax, Race.ComMin),
                // Honor defaults to zero
                Honor = 0,
                TempHonor = 0
            };

            // Generate the Class, one for now but options for more as time goes on
            Class = CharacterClasses.Fighter;

        }
        #endregion


        #region Level Up
        public void LevelUp()
        {


            UpdateWeightStatus();
        }
        #endregion  
    }
}
