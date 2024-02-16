namespace PlayerCharacters.Abilities
{
    public abstract class AbilityScore
    {
        internal int Ability;
        internal int AbilityFractional;
        internal int AbilityMax;
        internal int AbilityMin;
        public void AddFractional(int Fractional)
        {
            // Butting against the racial max allowed
            if ((Ability + (Fractional + AbilityFractional) / 100) > AbilityMax)
            {
                Ability++;
                AbilityFractional = 99;
            }
            else
            {
                // Increase the stat point
                int value = Fractional + AbilityFractional;
                if (value > 100)
                {
                    Ability++;
                    AbilityFractional = (value - 100);
                }
                // Normal increase
                else
                {
                    AbilityFractional = value;
                }
            }
        }

    }
}
