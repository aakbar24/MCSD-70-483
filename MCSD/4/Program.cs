using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, temp;
            num1 = 2;
            num2 = 1;
            num3 = 3;

            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num2 < num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;

            }

            Console.WriteLine("sorted: {0} , {1} , {2}", num1, num2, num3);
            
            
        }
    }
}
