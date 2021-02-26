using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public class Elephant : Herbivores
    {
        public Elephant(int adultWeight, bool sharpClaws, string nightWisionAbility, string herbalFoodType, bool senceOFHumor)
            : base(adultWeight, sharpClaws,  nightWisionAbility, herbalFoodType)
        {
            SenceOFHumor = senceOFHumor;
        }

        public bool SenceOFHumor { get; set; }
        public override void Display()
        {
            Console.Write("\nElephant :");
            Console.WriteLine($"The weight of the adult is:|{AdultWeight}|, Ability to have a sharp claws : " +
                $"|{SharpClaws}|, Ability to operate in the dark: |{NightWisionAbility}|. They need {HerbalFoodType} food type and their sence of humour are {SenceOFHumor}");
        }
    }
}
