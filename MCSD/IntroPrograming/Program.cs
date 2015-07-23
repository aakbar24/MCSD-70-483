using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 100;
            int secand = 50;

            if (first > secand)
            {
               // Console.WriteLine("After exchange:");
                int tem = first;
                first = secand;
                secand = tem;

                Console.WriteLine("After exchange: ");
                Console.WriteLine("first : {0}", first);
                Console.WriteLine("secand : {0}", secand);


            }
            else
            {
                Console.WriteLine("first : {0}", first);
                Console.WriteLine("secand : {0}", secand);
            }
        }
    }
}
