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
            List<int> list = new List<int>();

            for (int i = 0; i < 5555582; i++)
            {
                list.Add(i == 0 ? i : i * 2);
            }

            int[] array = list.ToArray();

            Random rd = new Random();

            int val = rd.Next(0, array.Length);

            //int[] order = BubbleSortAlgorithm_Library.BubbleSort.SortIntegers(array);

            (bool finded, int position) = BinarySearch.Library.BinarySearch.Find(array, val);
            Console.WriteLine(finded + " in position: " + position);
        }
    }
}
