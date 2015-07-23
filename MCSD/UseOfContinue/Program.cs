using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int rang = int.Parse(Console.ReadLine());

            for (int i = 1; i < rang; i++)
            {
                if (i % 2 != 0 && i/7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
             * this is test for github
        
             */
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}
