using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public class BrownBear : Bears
    {
        public BrownBear(int adultWeight, bool sharpClaws, string nightWisionAbility, int agressionLevel, string humanFriendlynessLevel, string mentalAbilityLevel)
            : base(adultWeight, sharpClaws, nightWisionAbility, agressionLevel, humanFriendlynessLevel)
        {
            MentalAbilityLevel = mentalAbilityLevel;
        }

        public string MentalAbilityLevel { get; set; }
        public override void Display()
        {
            Console.Write("\nBrown Bear :");
            Console.WriteLine($"The weight of the adult is:|{AdultWeight}|, Ability to have a sharp claws : |{SharpClaws}|, " +
                $"Ability to operate in the dark: |{NightWisionAbility}|, and has {AgressionLevel} argression level, and especially {HumanFriendlynessLevel} Human friendlyness level. Also they have {MentalAbilityLevel} mental abilities");
        }
    }
}
