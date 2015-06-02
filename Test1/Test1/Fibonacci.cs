using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Fibonacci
    {
        public static int Calcular(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;

            //if (n == 1)
            //{
            //    return 1;
            //}

            //if (n == 2)
            //{
            //    return 1;
            //}
            //return Calcular(n - 1) + Calcular(n - 2);
        }
    }
}
