using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop


{
    public class FlavorAllergenComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            int comparison = x.Allergens.Count - y.Allergens.Count;

            if (comparison > 0)
            {
                return 1;
            }
            else if (comparison < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
