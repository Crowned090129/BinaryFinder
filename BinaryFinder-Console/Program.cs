using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFinder_Console
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 5, 989, 14, 6454, 458, 1, 8, 9, 21, 47 };
            int[] order = BubbleSortAlgorithm_Library.BubbleSort.SortIntegers(array);
            (bool finded, int position) = BinarySearch.Library.BinarySearch.Find(order, 458);
            Console.WriteLine(finded + " in position: " + position);
        }
    }
}
