using System;
using System.Collections.Generic;
using System.Linq;
namespace HackerRank
{
    public static class MakingAnagrams
    {
        public static int Compute(string s1, string s2)
        {
            var letters = new int[26];
            s1.ToList().ForEach(c => letters[c - 'a']++);
            s2.ToList().ForEach(c => letters[c - 'a']--);
            return letters.ToList().Select(c => Math.Abs(c)).Sum();
        }

        public static void Run()
        {
            Console.WriteLine(Compute("cde", "abcc"));
        }
    }
}