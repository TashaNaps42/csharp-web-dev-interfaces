using IceCreamShop;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IceCreamShop
{
    public class ConeCostComparerAscending : IComparer<Cone>
    {
        public ConeCostComparerAscending()
        {
        }
        public int Compare(Cone x, Cone y)
        {
            double comparison = x.Cost - y.Cost;
            if (comparison > 0)
            {
                return 1;
            }
            else if (comparison == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}

public class ConeCostComparerDescending : IComparer<Cone>
{
    public int Compare(Cone x, Cone y)
    {
        if (x.Cost > y.Cost)
        {
            return 1;
        }
        else if (x.Cost < y.Cost)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}