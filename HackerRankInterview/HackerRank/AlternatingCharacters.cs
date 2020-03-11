using System;
using System.Linq;

namespace HackerRank
{
    public static class AlternatingCharacters
    {
        public static int Compute(string s)
        {
            var arr = s.ToArray();
            var deleteCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var current = arr[i];
                if (current == arr[i + 1])
                    deleteCount += 1;
            }
            return deleteCount;
        }

        public static void Run()
        {
            Console.WriteLine(Compute("ABABABABAB"));
        }
    }
}