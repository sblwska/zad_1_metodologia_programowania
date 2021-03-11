using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Niezbednik
    {
        public double Wieksza(double a, double b)
        {
            if (a > b)
            {
                return a;
            }

            else return b;
        }

        public void Zamien(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public Int32 Silnia(Int32 a)
        {
            Int32 res = 1;
            for (int i = 1; i <= a; i++)
            {
                res *= i;
                if(a != 0 && res <= 0)
                {
                    return -1;
                }
            }

            return res;
        }

        public Int32 RekurencyjnaSilnia(Int32 a)
        {
            if (a == 1) return 1;
            return a * RekurencyjnaSilnia(a - 1);
        }
  
    }







}
