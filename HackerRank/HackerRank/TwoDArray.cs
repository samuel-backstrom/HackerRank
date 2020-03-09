using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public static class TwoDArray
    {
        public static int Compute(int[,] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            var hourGlasses = new int[16];
            var current = 0;
            for (var vIndex = 0; vIndex < 4; vIndex++)
            {
                for (var hIndex = 0; hIndex < 4; hIndex++)
                {
                    hourGlasses[current] += arr[vIndex, hIndex];
                    hourGlasses[current] += arr[vIndex, hIndex + 1];
                    hourGlasses[current] += arr[vIndex, hIndex + 2];

                    hourGlasses[current] += arr[vIndex + 1, hIndex + 1];

                    hourGlasses[current] += arr[vIndex + 2, hIndex];
                    hourGlasses[current] += arr[vIndex + 2, hIndex + 1];
                    hourGlasses[current] += arr[vIndex + 2, hIndex + 2];

                    current += 1;
                }
            }

            var list = hourGlasses.ToList();
            list.Sort();
            return list[0];
        }

        public static void Run()
        {
            var arr = new[,]
            {
                { 1, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0, 0 },
                { 0, 0, 2, 4, 4, 0 },
                { 0, 0, 0, 2, 0, 0 },
                { 0, 0, 1, 2, 4, 0 }
            };
            Compute(arr);
        }
    }
}
