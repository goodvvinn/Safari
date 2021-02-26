using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safati
{
    public class Zoo : IComparer<Lynx>
    {
        public Zoo()
        {
            Animal = new Animals[]
                    {
                        new Lynx(HairLengh.NoHair, 40, 80, true, "full", ToothLengh.Big, "white"),
                        new Elephant(2000, false, "poor", "different", true),
                        new BrownBear(800, true, "strong", 5, "medium", "good"),
                        new Lynx(HairLengh.Long, 30, 60, true, "strong", ToothLengh.Big, "Light brown"),
                        new Lynx(HairLengh.Short, 4, 40, true, "strong", ToothLengh.Big, "light orange"),
                        new Elephant(3000, false, "lack of", "bushes", true),
                        new BrownBear(600, true, "medinm", 8, "low", "high"),
                    };
        }

        public Animals[] Animal { get; set; }

        public int Compare(Lynx x, Lynx y)
        {
            if (x.AdultWeight < y.AdultWeight)
            {
                return 1;
            }
            else if (x.AdultWeight > y.AdultWeight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public void Display()
        {
            foreach (var item in Animal)
            {
                item.Display();
            }
        }

        public void Display(Animals[] sorted)
        {
            foreach (var item in sorted)
            {
                item.Display();
            }
        }

        public void Sort()
        {
            int num = Animal.Length;
            Animals[] sorted = Animal;
            Animals temp;
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (sorted[j].AdultWeight < sorted[j + 1].AdultWeight)
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            Display(sorted);
         }
    }
}
