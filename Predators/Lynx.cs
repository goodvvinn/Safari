using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public class Lynx : BigCats
    {
        public Lynx(HairLengh hairL, int meelsForDay, int adultWeight, bool sharpClaws, string nightWisionAbility, ToothLengh toothLenght, string hairColor)
            : base(hairL, meelsForDay, adultWeight, sharpClaws, nightWisionAbility, toothLenght)
        {
            HairColor = HairColor;
        }

        public string HairColor { get; set; }
        public override void Display()
        {
            Console.Write("\nLynx :");
            Console.WriteLine($"The weight of the adult is:|{AdultWeight}|, " +
                $"Ability to have a sharp claws : |{SharpClaws}|, Ability to operate in the dark: |{NightWisionAbility}|, " +
                $"for one day it needs {MeelsForDay} kg of the fresh meet, it has |{HairL}|, |{HairColor}| hair, and {ToothLengh} tooth");
        }
    }
}
