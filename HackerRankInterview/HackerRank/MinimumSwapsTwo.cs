using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public static class MinimumSwapsTwo
    {
        public static int Compute(int[] arr)
        {
            if (arr is null)
                throw new ArgumentNullException(nameof(arr));
            return 0;
        }

        public static void Run()
        {
            var result = Compute(new int[] { 7, 3, 2, 5, 4, 6, 1 });
            Console.WriteLine(result);
            result = Compute(new int[] { 4, 3, 2, 1 });
            Console.WriteLine(result);
            result = Compute(new int[] {
                2, 31, 1, 38, 29, 5, 44, 6, 12, 18, 39, 9, 48, 49, 13, 11, 7,
                27, 14, 33, 50, 21, 46, 23, 15, 26, 8, 47, 40, 3, 32, 22,
                34, 42, 16, 41, 24, 10, 4, 28, 36, 30, 37, 35, 20, 17, 45, 43, 25, 19 });
            Console.WriteLine(result); 
        }
    }
}
