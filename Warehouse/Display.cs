using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class Display
    {
        public static void Show(List<SortedDictionary<string, int>> listOfWH, List<int> sum)
        {
            var chars = new List<char>() { 'A', 'B', 'C' };

            for (int i = 0; i < listOfWH.Count; i++)
            {
                Console.WriteLine($"WH-{chars[i]} (total {sum[i]})");
                foreach (var item in listOfWH[i])
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Console.WriteLine();
            }
        }
    }
}



