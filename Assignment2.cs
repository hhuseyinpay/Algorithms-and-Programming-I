using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014510058_Hasan_Hüseyin_PAY_33
{
    class Program
    {
        static void Main(string[] args)
        {

            //define variable
            string check = ""; 
            int number = 0;
            int counter = 0;            
            int first = 0, second = 0;
            bool pent = false, hept = false;
            int temp = 0;
            int x, a;
            //define variable END

            //Questions  1 **************************************************************************
            Console.WriteLine("A program that takes a number n (between 1 and 999) from the you and finds “how many times the digits 4 and 9 occurs from 1 to n”.");
            Console.Write("Enter number : ");
            //Exception handlig
            while (true)
            {
               check = Console.ReadLine();
               if ((check.All(char.IsDigit)) & (check != ""))
               {
                   number = Convert.ToInt32(check);
                   if ((number >= 1) & (number <= 999))
                   {
                       break;
                   }
                   
               }
               Console.Write("Please enter only integer between 1 and 999 : ");
            }
            //Exception handlig END

            //calculete
            for (int i = 1; i < number; i++)
            {
                second = i % 10;
                first = (i - second) / 10;
                if (second == 4)
                {
                    counter++;
                }
                if (second == 9)
                {
                    counter++;
                }
                if (first == 4)
                {
                    counter++;
                }
                if (first == 9)
                {
                    counter++;
                }
                
            }
            //calculete END

            Console.WriteLine("{0} times the digits 4 and 9 occurs from 1 to {1}", counter, number);
            //Questions  1 END **************************************************************************
            Console.WriteLine("Press enter for next questions");
            Console.ReadLine();
            //Questions  2 **************************************************************************

            Console.WriteLine(@"A program that takes a number from the you and prints one of the followings:
- Pentagonal and heptagonal
- Not pentagonal but  heptagonal
- Pentagonal but not heptagonal
- Neither pentagonal nor heptagonal
");
            Console.Write("Enter a number : ");
            //Exception handlig
            while (true)
            {
                check = Console.ReadLine();
                if ((check.All(char.IsDigit)) & (check != ""))
                {
                    break;
                }
                Console.Write("Please enter only integer");
            }
            number = Convert.ToInt32(check);
            //Exception handlig END

            
            counter = 1;
            //calculate
            while (true)
            {
                temp = ((counter * (3 * counter - 1)) / 2);
                if (temp == number)
                {
                    pent = true;
                    break;
                }
                if (temp > number)
                {
                    break;
                }
                counter++;

            }

            counter = 1;
            temp = 0;
            while (true)
            {
                temp = (counter * (5 * counter - 3)) / 2;
                if ( temp == number)
                {
                    hept = true;
                    break;
                }
                if (temp > number)
                {
                    break;
                }
                counter++;
                
            }
            //calculate END

            if (pent & hept)
            {
                Console.WriteLine("Pentagonal and heptagonal");
            }

             else if (pent & (!hept))
             {
                 Console.WriteLine("Pentagonal but not heptagonal");
             }

             else if ((!pent) & hept)
             {
                 Console.WriteLine("Not pentagonal but  heptagonal");
             }

             else
             {
                 Console.WriteLine("Neither pentagonal nor heptagonal");
             }
                        
            
            


            //Questions  2 END **************************************************************************
            Console.WriteLine("Press enter for next questions");
            Console.ReadLine();
            //Questions  3 **************************************************************************

            Console.WriteLine("A program which that takes the values of x and a from the user and calculates the result..");
            Console.Write("Enter a number x : ");
            //Exception handlig
            while (true)
            {
                check = Console.ReadLine();
                if ((check.All(char.IsDigit)) & (check != ""))
                {
                    break;
                }
                Console.Write("Please enter only integer");
            }
            x = Convert.ToInt32(check);

            Console.Write("Enter a number a : ");
            while (true)
            {
                check = Console.ReadLine();
                if ((check.All(char.IsDigit)) & (check != ""))
                {
                    break;
                }
                Console.Write("Please enter only integer");
            }
            a = Convert.ToInt32(check);
            //Exception handlig

            //calculate
            Console.WriteLine("Formulle alakalı her hangi bir bilgi bulamadığım için bu sorunun cevabı yok !");
            //calculate

            //Questions  3 END **************************************************************************
            Console.WriteLine("Press enter for exit program");
            Console.ReadLine();
        }
    }
}
