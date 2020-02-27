using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace HackerRank
{
    public static class SockMerchant
    {
        // Complete the sockMerchant function below.
        private static int Compute(int n, int[] ar)
        {
            Array.Sort(ar);
            var numberOfPairs = 0;
            for (var i = 0; i < ar.Length;)
            {
                if (n - i == 1)
                    break;
                if (ar[i] == ar[i + 1])
                {
                    numberOfPairs += 1;
                    i += 2;
                }
                else
                {
                    i += 1;
                }
                    
            }
            return numberOfPairs;
        }

        public static void Run()
        {
            var result = Compute(20, new[] {4, 5, 5, 5, 6, 6, 4, 
                1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5
            });
            Console.WriteLine(result);
        }
    }

}
