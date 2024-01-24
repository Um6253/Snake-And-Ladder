using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 4, 2, 44, 5, 1, 3, 4, 6, 3 };
            List<int> k = new List<int>();

            foreach (int i in num)
            {
                if (i > 1)
                {
                    k.Add(i);
                    Console.WriteLine(i + "=" + CountOccurrences(num, i));
                    Console.ReadLine();

                }
            }
        }
                   

        private static int CountOccurrences(int[] array, int number)
        {
            int count = 0;

            foreach (int element in array)
            {
                if (element == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}