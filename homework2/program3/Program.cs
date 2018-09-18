using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a number:");
            string s = "";
            int n = 0;
            s = Console.ReadLine();
            n = Int32.Parse(s);
            for (int i = 2; i <= n; i++)
            {
                while (n != i)
                {
                    if (n % i == 0)
                    {
                        Console.Write(i + "*");
                        n = n / i;
                    }
                    else
                        break;
                }
            }
            Console.Write(n + "\n");

        }
    }
}



