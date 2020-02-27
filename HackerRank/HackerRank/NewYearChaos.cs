using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public static class NewYearChaos
    {
        private const string CHAOTIC = "Too chaotic";

        public static void Compute(int[] q)
        {
            if (q is null)
                throw new ArgumentNullException(nameof(q));

            var result = 0;
            var compare = new int[q.Length];
            for (var i = 0; i < compare.Length; i++)
            {
                compare[i] = i + 1;
            }               

            for (var i = 0; i < q.Length; i++)
            {
                if (q[i] != compare[i])
                {
                    var n = 1;
                    while (q[i] != compare[n + i])
                    {
                        if (++n == q.Length - 1)
                            break;
                    }
                    if (n > 2)
                    {
                        Console.WriteLine(CHAOTIC);
                        return;
                    }

                    while (n > 0)
                    {
                        Swap(compare, i + n);
                        n -= 1;
                        result += 1;
                    }
                }
            }

            Console.WriteLine(result);
        }

        private static void Swap(int[] q, int i)
        {
            var tmp = q[i - 1];
            q[i - 1] = q[i];
            q[i] = tmp;
        }

        public static void Run()
        {
            var q = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            Compute(q);
        }
    }
}
