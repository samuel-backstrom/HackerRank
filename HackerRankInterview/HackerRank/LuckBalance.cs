
using System;
using System.Linq;
namespace HackerRank
{
    public static class LuckBalance
    {
        public static int Compute(int k, int[][] contests)
        {
            var luckBalance = 0;
            var importantContestCount = 0;
            var sorted = contests.ToList().OrderByDescending(a => a[0]).ToList();
            foreach (var a in sorted)
            {
                if (a[1] == 1)
                    importantContestCount += 1;
                luckBalance += a[0];
            }

            for (int i = sorted.Count - 1, j = 0; j < (importantContestCount - k); i--)
            {
                if (sorted[i][1] == 1)
                {
                    luckBalance -= sorted[i][0] * 2;
                    j += 1;
                }
            }

            return luckBalance;
        }

        public static void Run()
        {
            var k = 3;
            var n = 6;
            var contests = new int[n][];
            contests[0] = new int[] { 5, 1 };
            contests[1] = new int[] { 2, 1 };
            contests[2] = new int[] { 1, 1 };
            contests[3] = new int[] { 8, 1 };
            contests[4] = new int[] { 10, 0 };
            contests[5] = new int[] { 5, 0 };
            Console.WriteLine(Compute(k, contests));
        }
    }
}