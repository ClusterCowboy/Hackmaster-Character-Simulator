using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universals;

namespace PlayerCharacters.CharacterGeneration
{
    public class Family
    {
        #region Birth
        public bool BirthWasLegitimate { get; private set; }
        public bool AbandonedAtBirth { get; private set; } = false;
        public bool ResultOfRape { get; private set; } = false;
        public bool MotherWasProstitute { get; private set; } = false;
        public bool ResultOfAdulterousAffair { get; private set; } = false;
        public bool ArrangedThroughSurrogateMother { get; private set; } = false;
        public bool IsOrphan { get; private set; } = false;
        #endregion

        #region Mother And Father
        public bool MotherIsKnown {  get; private set; } = false;
        public bool MotherIsAlive { get; private set; } = false;
        public bool MotherIsCelebrity { get; private set; } = false; // TODO: Fame
        public bool FatherIsKnown { get; private set; } = false;
        public bool FatherIsAlive { get; private set; } = false;
        public bool FatherIsCelebrity { get; private set; } = false; // TODO: Fame
        #endregion


        public void DetermineCircumstancesOfBirth(int RacialModifierLegit, int RacialModifierIllegit)
        {
            DetermineIfCircumstancesOfBirthWereLegit(RacialModifierLegit);
            if (!BirthWasLegitimate)
            {
                DetermineCircumstancesOfIllegitimateBirth(RacialModifierIllegit);
            }
            else
            {
                MotherIsKnown = true;
                FatherIsKnown = true;
            }

            // Parent Status
            int MotherAlive = Di.ce.RollPercentile();
            if (MotherAlive == 1)
            {
                MotherIsAlive = true;
                MotherIsCelebrity = true;
            }
            else if (MotherAlive <= 80)
            {
                MotherIsAlive = true;
            }
            else if (MotherAlive > 90)
            {
                MotherIsAlive = true;
                IsOrphan = true;
            }

            if (!IsOrphan)
            {
                int FatherAlive = Di.ce.RollPercentile();
                if (FatherAlive == 1)
                {
                    FatherIsAlive = true;
                    MotherIsCelebrity = true;
                }
                else if (FatherAlive <= 80)
                {
                    FatherIsAlive = true;
                }
                else if (FatherAlive > 90)
                {
                    FatherIsAlive = true;
                }
            }


        }

        private void DetermineIfCircumstancesOfBirthWereLegit(int RacialModifierLegit)
        {
            BirthWasLegitimate = Di.ce.PercentileCheckUnderPass(90 - RacialModifierLegit);
        }

        public void DetermineCircumstancesOfIllegitimateBirth(int RacialModifierIllegit)
        {
            int number = Di.ce.Roll(1, 100, RacialModifierIllegit);

            if (number <= 5) 
            { 
                AbandonedAtBirth = true;
            }
            else if (number <= 30) 
            {
                ResultOfRape = true;
                MotherIsKnown = true;
            }
            else if (number <= 60)
            {
                MotherWasProstitute = true;
                MotherIsKnown = true;
            }
            else if (number <= 90)
            {
                ResultOfAdulterousAffair = true;
                MotherIsKnown = true;
                FatherIsKnown = Di.ce.PercentileCheckUnderPass(75);
            }
            else
            {
                ArrangedThroughSurrogateMother = true;
                MotherIsKnown = Di.ce.PercentileCheckUnderPass(25);
                FatherIsKnown = true;
            }
        }
    }
}
