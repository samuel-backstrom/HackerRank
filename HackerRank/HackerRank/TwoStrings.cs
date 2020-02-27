using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class TwoStrings
    {
        public static string Compute(string s1, string s2)
        {
            if (s1 is null)
                throw new ArgumentNullException(nameof(s1));
            if (s2 is null)
                throw new ArgumentNullException(nameof(s2));

            var s1chars = new HashSet<char>();
            foreach (var c in s1.ToArray())
                s1chars.Add(c);

            foreach (var c in s2.ToArray())
            {
                if (s1chars.Contains(c))
                {
                    return "YES";
                }
            }

            return "NO";
        }

        public static void Run()
        {
            var result = Compute("hello", "world");
            Console.WriteLine(result);
        }
    }
}