using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD
{
    public class Class1
    {
        public static double mcd(double nro1,double nro2)
        {
           if(nro2==0)
            {
                return nro1;
            }else
            {
                return mcd(nro2, nro1 % nro2);
            }
        }
    }
}
