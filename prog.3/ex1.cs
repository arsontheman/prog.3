using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog._3
{
    public class ex1
    {
        public int[] Numbers { get; set; }

        public ex1(int[] numbers)
        {
            Numbers = numbers;
        }

        public int CountMultiplesOf27()
        {
            int count = 0;
            foreach (int num in Numbers)
            {
                if (num % 27 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
