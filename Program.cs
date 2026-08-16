using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_Git_In_VS
{
    internal class Program
    {
        // add feature : print element of any int arrray. => commit it 
        public static void PrintList(IEnumerable<int> arr)
        {
            Console.WriteLine($"list of arr is:\n{string.Join(" ", arr)}");
        }

        public static void SortArr(IEnumerable<int> arr)
        {
            Console.WriteLine($"list of arr is:\n{arr.OrderBy(x => x)}");
        }

        // feature to git only even nums
        public static void EvenNums(IEnumerable<int> arr)
        {
            Console.WriteLine($"even nums in array is?:\n{string.Join(" ", arr.Where(n => n % 2 == 0))}");
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 6, 3, 4, 9, 2, 7, 8, 10, 5 };
            //Console.WriteLine($"list of arr is:\n{string.Join(" ", arr)}" + "\n" +
            //    $"\nafter sorted asc is:\n{string.Join(" ", arr.OrderBy(x => x))}");

            PrintList(arr);
            Console.WriteLine();

            SortArr(arr);
            Console.WriteLine();

            EvenNums(arr);

        }
    }
}
