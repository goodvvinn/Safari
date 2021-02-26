using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public class Herbivores : Animals
    {
        public Herbivores(int adultWeight, bool sharpClaws, string nightWisionAbility, string herbalFoodType)
            : base(adultWeight, sharpClaws, nightWisionAbility)
        {
            HerbalFoodType = herbalFoodType;
        }

        public string HerbalFoodType { get; set; }
        public override void Display()
        {
            Console.WriteLine($"\nThe weight of the adult is:|{AdultWeight}|, Ability to have a sharp claws : " +
                $"|{SharpClaws}|, Ability to operate in the dark: |{NightWisionAbility}|. They need {HerbalFoodType} food type");
        }
    }
}
