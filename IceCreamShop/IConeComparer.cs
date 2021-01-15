using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class IConeComparer: IComparer<Cone> {
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost > y.Cost) 
            {
                return 1;
            } else if (y.Cost > x.Cost) 
            {
                return -1;
            } else 
            { 
                return 0; 
            }
        }

        public int Compare(Cone x, Cone y)
        {
            if (x.Cost > y.Cost)
            {
                return 1;
            }
            else if (y.Cost > x.Cost)
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
