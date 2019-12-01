using System.Collections.Generic;

namespace Warehouse
{
    public class TransformInput
    {
        public static void ListOfItems(List<string> lines)
        {
            int sumA = 0, sumB = 0, sumC = 0;
            SortedDictionary<string, int> listA = new SortedDictionary<string, int>();
            SortedDictionary<string, int> listB = new SortedDictionary<string, int>();
            SortedDictionary<string, int> listC = new SortedDictionary<string, int>();
            foreach (var line in lines)
            {
                if (line.Contains("WH-A"))
                {
                    sumA = CalculateItems.Calculation(listA, line, sumA, "WH-A");
                }
                if (line.Contains("WH-B"))
                {
                    sumB = CalculateItems.Calculation(listB, line, sumB, "WH-B");
                }
                if (line.Contains("WH-C"))
                {
                    sumC = CalculateItems.Calculation(listC, line, sumC, "WH-C");
                }
            }

            CollectResults(sumA, sumB, sumC, listA, listB, listC);

        }

        private static void CollectResults(int sumA, int sumB, int sumC, SortedDictionary<string, int> listA, SortedDictionary<string, int> listB, SortedDictionary<string, int> listC)
        {
            var listOfWH = new List<SortedDictionary<string, int>> { listA, listB, listC };
            var sum = new List<int>() { sumA, sumB, sumC };
            Display.Show(listOfWH, sum);

        }        
    }
}



