namespace PlayerCharacters.Abilities
{
    public abstract class AbilityScore
    {
        internal int Ability;
        internal int AbilityFractional;
        internal int AbilityMax;
        internal int AbilityMin;
        public void AddFractional(int fractional)
        {
            AbilityFractional += fractional;
            if (AbilityFractional > 100) 
            {
                if (Ability + 1 > AbilityMax)
                {
                    AbilityFractional = 99;
                }
                else
                {
                    Ability++;
                    AbilityFractional -= 100;
                }
            }
        }

    }
}
