using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public abstract class BigCats : Cats
    {
        public BigCats(HairLengh hairL, int meelsForDay, int adultWeight, bool sharpClaws, string nightWisionAbility, ToothLengh toothLengh)
            : base(hairL, meelsForDay,  adultWeight,  sharpClaws, nightWisionAbility)
        {
            ToothLengh = toothLengh;
        }

        public ToothLengh ToothLengh { get; set; }
        public override void Display()
        {
            Console.WriteLine($"\nThe weight of the adult is:|{AdultWeight}|, " +
                $"Ability to have a sharp claws : |{SharpClaws}|, Ability to operate in the dark: |{NightWisionAbility}|, " +
                $"for one day it needs {MeelsForDay} kg of the fresh meet, it has |{HairL}| hair, and {ToothLengh} tooth");
        }
    }
}
