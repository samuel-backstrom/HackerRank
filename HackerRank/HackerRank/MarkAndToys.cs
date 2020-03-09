using System;
using System.Linq;
namespace HackerRank
{
    public static class MarkAndToys
    {
        public static int Compute(int[] prices, int spendingMoney)
        {
            var priceList = prices.ToList();
            priceList.Sort();

            var toyCount = 0;
            while (toyCount < priceList.Count)
            {
                spendingMoney -= priceList[toyCount];
                if (spendingMoney <= 0)
                    break;
                toyCount += 1;
            }

            return toyCount;
        }

        public static void Run()
        {
            Console.WriteLine(Compute(new int[] { 1, 12, 5, 111, 200, 1000, 10 }, 2));
        }
    }
}