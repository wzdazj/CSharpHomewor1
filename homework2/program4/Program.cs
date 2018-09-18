using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5 };
            int max = 0;
            int min = 0;
            max = min = arr[0];
            int sum = 0;
            int average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum = sum + arr[i];
                average = sum / arr.Length;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(average);

        }
    }
}
