using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IceCreamShop
{
    public class ConeCostComparerDescending : IComparer<Cone>
    {
        public ConeCostComparerDescending()
        {

        }
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost > y.Cost)
            {
                return -1;
            }
            else if (x.Cost < y.Cost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
