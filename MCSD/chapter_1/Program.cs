using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1
{
    class Program
    {
        static int[] intArr = new int[10];
        static void Main(string[] args)
        {
           // int[] intArr = { 1, 2, 3 };
            

            for (int i = 1; i < 10; i++)
            {
                intArr[i] = i + 1;
            }

            foreach (int num in intArr
            {
                
                //Console.WriteLine("index is : {0} ", num);

                if (num % 2 == 0)
                {
                    Console.WriteLine("this is prie number {0}", num);
                }
                String dd = num % 2 == 0 ? "even":"odd";
                Console.WriteLine(dd);
                
            }
        }
    }
}
