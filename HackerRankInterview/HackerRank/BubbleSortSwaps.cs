using System;

namespace HackerRank
{
    public static class BubbleSortSwaps
    {
        private static int[] a;

        public static int[] GetA()
        {
            return a;
        }

        public static void SetA(int[] value)
        {
            a = value;
        }

        public static void Compute()
        {
            var swapCount = 0;
            var n = GetA().Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (GetA()[j] > GetA()[j + 1])
                    {
                        Swap(j, j + 1);
                        swapCount += 1;
                    }
                }
            }
            Console.WriteLine($"Array is sorted in {swapCount} swaps.");
            Console.WriteLine($"First Element: {GetA()[0]}");
            Console.WriteLine($"Last Element: {GetA()[n - 1]}");
        }

        private static void Swap(int p1, int p2)
        {
            var tmp = GetA()[p1];
            GetA()[p1] = GetA()[p2];
            GetA()[p2] = tmp;
        }

        public static void Run()
        {
            SetA(new int[] { 6, 4, 1 });
            Compute();
        }
    }
}