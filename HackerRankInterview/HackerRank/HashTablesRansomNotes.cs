using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class HashTablesRansomNotes
    {
        public static void Compute(string[] magazine, string[] note)
        {
            if (magazine is null)
                throw new ArgumentNullException(nameof(magazine));
            if (note is null)
                throw new ArgumentNullException(nameof(note));

            var magazineSet = new Dictionary<string, int[]>();
            foreach (var s in magazine)
            {
                if (!magazineSet.ContainsKey(s))
                {
                    magazineSet.Add(s, new int[] { 1 });
                }
                else
                {
                    magazineSet.TryGetValue(s, out var value);
                    value[0]++;
                }
            }

            foreach (var s in note)
            {
                var existsInSet = magazineSet.TryGetValue(s, out var wordCount);
                if (!existsInSet || (existsInSet && wordCount[0] == 0))
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    magazineSet.TryGetValue(s, out var value);
                    value[0]--;
                }
            }
            Console.WriteLine("Yes");
        }

        public static void Run()
        {
            Compute(new string[] { "give", "me", "one", "grand", "today", "night" },
                new string[] { "give", "one", "grand", "today", "today" });
        }
    }
}