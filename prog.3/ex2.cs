using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog._3
{
    public class ex2
    {
        public int A { get; set; }
        public int B { get; set; }
        public bool HasError { get; private set; }

        public ex2(int a, int b)
        {
            A = a;
            B = b;
            HasError = false;
        }

        public int SumOfMultiplesOf17AndDivisibleBy4Mod2()
        {
            int sum = 0;

            if (A > B)
            {
                HasError = true;
                return -1;
            }

            for (int i = A; i <= B; i++)
            {
                if (i % 17 == 0 && i % 4 == 2)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
