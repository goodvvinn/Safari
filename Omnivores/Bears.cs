using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public abstract class Bears : Omnivores
    {
        public Bears(int adultWeight, bool sharpClaws, string nightWisionAbility, int agressionLevel, string humanFriendlynessLevel)
            : base(adultWeight,  sharpClaws,  nightWisionAbility, agressionLevel)
        {
            HumanFriendlynessLevel = humanFriendlynessLevel;
        }

        public string HumanFriendlynessLevel { get; set; }
        public override void Display()
        {
            Console.WriteLine($"\nThe weight of the adult is:|{AdultWeight}|, Ability to have a sharp claws : |{SharpClaws}|, " +
                $"Ability to operate in the dark: |{NightWisionAbility}|, and has {AgressionLevel} argression level, and especially {HumanFriendlynessLevel} Human friendlyness level");
        }
    }
}
