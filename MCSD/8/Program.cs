using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
         static string number;
         static string position;
         static string total;
         static int counter;
        static string first;
        static string sceand;

        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            //char ch = myString[0];
            Console.WriteLine("length of string is: " +myString.Length);

            //int ii = (int)char.GetNumericValue( myString[0]);
          //  ii = ii + 1;
          //  Console.WriteLine("first letter is: " + (Convert.ToInt32( myString[0]) + 1));
            counter = myString.Length;
            for (int i = 0; i < myString.Length; i++)
            {
                if (counter == 4)
                {
                    number = number09((int)char.GetNumericValue(myString[i]));

                    position = positionFinder(counter);
                    //Console.WriteLine("Number is " + number);
                    total = number + " " + position;


                    Console.Write(total + " ");
                    counter--;
                }
                else  if (counter == 3)
                {
                    number = number09((int)char.GetNumericValue(myString[i]));

                    position = positionFinder(counter);
                    //Console.WriteLine("Number is " + number);
                   
                    total = number + " " + position;

                    if (number != "ZERO")
                    Console.Write(total + " ");
                    counter--;
                }

                else if (counter == 2)
                {
                     first = Convert.ToString(myString[i]);

                    counter--;
                }

                else  if (counter == 1)
                {
                   // if(Convert.ToString(myString[i]) != "0")
                    //{
                    sceand = Convert.ToString(myString[i]);
                    //}
                     string tenth = first + sceand;
                     //Console.WriteLine(tenth);
                     if (Convert.ToInt32(tenth) >= 20)
                     {
                         tenth = num20_99(Convert.ToInt32(tenth));
                     }
                     else
                     {

                         tenth = number09(Convert.ToInt32(tenth));
                     }
                    
                    if( tenth != "ZERO")
                   Console.Write(tenth);
                }
                

            }
            

        }
        public static string number09(int number1)
        {
            switch (number1)
            {
                case 0: number= "ZERO";
                    break;
                case 1: number="ONE";
                    break;
                case 2: number="TWO";
                    break;
                case 3: number="THREE";
                    break;
                case 4: number="FOUR";
                    break;
                case 5: number="FIVE";
                    break;
                case 6: number="SIX";
                    break;
                case 7: number="SEVEN";
                    break;
                case 8:number="EAITH";
                    break;
                case 9: number="NINE";
                    break;
                    
                case 10: number="TEN";
                    break;
                case 11: number="ELEVEN";
                    break;
                case 12: number="TWIVE";
                    break;
                case 13: number="THRTEEN";
                    break;
                case 14: number="FOURTEEN";
                    break;
                case 15: number="FINTEEN";
                    break;
                case 16: number="SIXTEEN";
                    break;
                case 17: number="SEVENTEEN";
                    break;
                case 18: number="EIGHTEEN";
                    break;
                case 19: number="NINETEEN";
                    break;
                    /*
                case 20:
                    {
                        switch (number1)

                    }
                    break;
                */
                default: number = "";
                    break;
                    
            }

            return number;
        }

        public static string num20_99(int num2)
        {
            /*
            String ss = Convert.ToString(num2);
            string ses;
            if (ss[0] == 2)
            {
                return "tewwn" + 
            }
            */
            string s1 = "";
            string s2 = "";//  , s2, to;
            if (num2 / 10 == 2)
            {
                 s1 = "tewwn";
                 if ((num2 % 10) > 0)
                 {
                     s2 = number09(num2 % 10);
                     // return s1 + s2;
                 }
            }
            else  if (num2 / 10 == 3)
            {
                 s1 = "thrity";
                 s2 = number09(num2 % 10);
               // return s1 + s2;

            }
            else  if (num2 / 10 == 4)
            {
                s1 = "fourty";
                s2 = number09(num2 % 10);
               // return s1 + s2;

            }
            else if (num2 / 10 == 5)
            {
                 s1 = "fifity";
                 s2 = number09(num2 % 10);
               // return s1 + s2;

            }
            else if (num2 / 10 == 6)
            {
                 s1 = "sisty";
                 s2 = number09(num2 % 10);
               // return s1 + s2;

            }
            else if (num2 / 10 == 7)
            {
                 s1 = "seneventy";
                 s2 = number09(num2 % 10);
                //return s1 + s2;

            }
            else  if (num2 / 10 == 8)
            {
                 s1 = "eight";
                 s2 = number09(num2 % 10);
               // return s1 + s2;

            }
           else  if (num2 / 10 == 9)
            {
                 s1 = "ninty";
                 s2 = number09(num2 % 10);

                //return s1 + s2;

            }
           // to = s1 + s2;
            return s1+s2;
        }
    

    

        public static string positionFinder(int position1)
        {
            switch (position1)
            {
                case 3: position = "HUNDREAD";
                    break;
                case 4: position = "Thousand";
                    break;
            }
            return position;
        }
    }
}
