using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                for (int k = 2; k <= i; k++)
                {
                    if (i % k == 0 && i != k)
                    {
                        break;
                    }
                    if (i % k == 0 && i == k)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }
    }

}
