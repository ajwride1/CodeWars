using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            int total = 0;

            while (value != 0)
            {
                value--;

                if (IsDivisible(value, 3))
                {
                    total += value;
                    continue;
                }

                if (IsDivisible(value, 5))
                {
                    total += value;
                    continue;
                }
            }

            return total;
        }

        public static int AlternateSolution(int value)
        {
            return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }

        private static bool IsDivisible(int value, int divisableBy)
        {
            return (value % divisableBy == 0);
        }
    }
}
