using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWFA
{
    abstract class  Methods
    {
       public static long add(long x, long y)
        {
            y += x; 
            return y;

        }

        public static long equalsto(long x)
        {
            return x;
        }
    }
}
