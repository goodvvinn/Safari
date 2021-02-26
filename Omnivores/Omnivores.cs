using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public abstract class Omnivores : Animals
    {
        public Omnivores(int adultWeight, bool sharpClaws, string nightWisionAbility, int agressionLevel)
            : base(adultWeight,  sharpClaws,  nightWisionAbility)
        {
            AgressionLevel = agressionLevel;
        }

        public int AgressionLevel { get; set; }
        public override void Display()
        {
            Console.WriteLine($"\nThe weight of the adult is:|{AdultWeight}|, Ability to have a sharp claws : |{SharpClaws}|, Ability to operate in the dark: |{NightWisionAbility}|, and has {AgressionLevel} argression level");
        }
    }
}
