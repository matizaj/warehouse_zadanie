using System.Collections.Generic;
using System.Linq;

namespace Warehouse
{
    public class CalculateItems
    {
        public static int Calculation(SortedDictionary<string, int> list, string line, int sum, string category)
        {
            var input = line.Split(';');
            var keyValuePairs = input[2].Split('|').ToList();
            foreach (var kvp in keyValuePairs)
            {
                string key = kvp.Split(',')[0];
                if (key.Contains(category))
                {
                    int value = int.Parse(kvp.Split(',')[1]);
                    list.Add(input[1], value);
                    sum += value;
                }
            }
            return sum;
        }
    }
}



