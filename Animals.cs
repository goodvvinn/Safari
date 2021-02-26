using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public abstract class Animals
    {
        public Animals(int adultWeight, bool sharpClaws, string nightWisionAbility)
        {
            AdultWeight = adultWeight;
            SharpClaws = sharpClaws;
            NightWisionAbility = nightWisionAbility;
        }

        public int AdultWeight { get; set; }
        public bool SharpClaws { get; set; }

        public string NightWisionAbility { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"\nThe weight of the adult is:|{AdultWeight}|, Ability to have a sharp claws : |{SharpClaws}|, Ability to operate in the dark: |{NightWisionAbility}|");
        }
    }
}
