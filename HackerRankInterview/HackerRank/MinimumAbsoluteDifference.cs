using System.Linq;
using System;
using System.Collections.Generic;

namespace HackerRank
{
    public static class MinimumAbsoluteDifference
    {
        public static int Compute(int[] a)
        {
            if (a is null)
                throw new ArgumentNullException(nameof(a));

            var list = a.ToList();
            list.Sort();

            var minDifference = int.MaxValue;
            for (int i = 0; i < a.Length - 1; i++)
            {
                var current = Math.Abs(list[i] - list[i + 1]);
                if (current < minDifference)
                    minDifference = current;
                if (minDifference == 1)
                    return 1;
            }

            return minDifference;
        }

        public static void Run()
        {
            Console.WriteLine(Compute(new int[] { 3, -7, 0 }));
        }
    }
}