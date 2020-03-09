using System;

namespace HackerRank
{
    public static class BubbleSortSwaps
    {
        public static int[] A { get; set; }

        public static void Compute()
        {
            var swapCount = 0;
            var n = A.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        Swap(j, j + 1);
                        swapCount += 1;
                    }
                }
            }
            Console.WriteLine($"Array is sorted in {swapCount} swaps.");
            Console.WriteLine($"First Element: {A[0]}");
            Console.WriteLine($"Last Element: {A[n - 1]}");
        }

        private static void Swap(int p1, int p2)
        {
            var tmp = A[p1];
            A[p1] = A[p2];
            A[p2] = tmp;
        }

        public static void Run()
        {
            A = new int[] { 6, 4, 1 };
            Compute();
        }
    }
}