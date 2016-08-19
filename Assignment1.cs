using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************************Questions 1 ***********************************************************
            Console.WriteLine("A program that converts Turkish shoes numbers to ABD or UK shoes numbers.   ");
            Console.WriteLine("Enter Turkish shoes numbers(36-40)..:");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which country?(ABD or UK)");
            string country = Console.ReadLine();
            if (numbers == 36)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("6");
                }
                else if (country == "UK")
	                {
                        Console.WriteLine("3.5");
	                }
            }
            else if (numbers == 37)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("6.5");
                }
                else if (country == "UK")
                {
                    Console.WriteLine("4");
                }
            }
            else if (numbers == 37.5)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("7");
                }
                else if (country == "UK")
                {
                    Console.WriteLine("4.5");
                }
            }
            else if (numbers == 38)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("7.5");
                }
                else if (country == "UK")
                {
                    Console.WriteLine("5");
                }
            }
            else if (numbers == 39)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("8");
                }
                else if (country == "UK")
                {
                    Console.WriteLine("5.5");
                }
            }
            else if (numbers == 39.5)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("8.5");
                }
                else if (country == "UK")
                {
                    Console.WriteLine("6");
                }
            }
            else if (numbers == 40)
            {
                if (country == "ABD")
                {
                    Console.WriteLine("9");
                }
                else if (country == "UK")
                {
                    Console.WriteLine("6.5");
                }


            }
            else
            {
                Console.WriteLine("Somethings are wrong");
            }
            Console.WriteLine("Press enter and go next question");
            Console.ReadLine();

            //******************************Questions 1 END********************************************************
            //******************************Questions 2 ***********************************************************
            Console.WriteLine("A program that converts kitchen metrics (WaterGlass (WG), TeaCup, CoffeeCup, TableSpoon) to gram");
            Console.Write("How much?");
            int metric = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which metric?");
            string amount = Console.ReadLine();
            Console.Write("What kind of?");
            string kind = Console.ReadLine();

            if (kind == "Walnut")
            {
                if (amount == "WG")
                {
                    Console.WriteLine(metric*100 + " gram");
                }
                else if (amount == "TC")
                {
                    Console.WriteLine(metric*40 + " gram");
                }
                else if (amount == "CC")
                {
                    Console.WriteLine(metric*25 + " gram");
                }
                else if (amount == "TS")
                {
                    Console.WriteLine(metric*18 + " gram");
                }
                else
                {
                    Console.WriteLine("Somthings are wrong");
                }
            }

            else if (kind == "Milk")
            {
                if (amount == "WG")
                {
                    Console.WriteLine(metric * 200 + " gram");
                }
                else if (amount == "TC")
                {
                    Console.WriteLine(metric * 120 + " gram");
                }
                else if (amount == "CC")
                {
                    Console.WriteLine(metric * 75 + " gram");
                }
                else if (amount == "TS")
                {
                    Console.WriteLine(metric * 15 + " gram");
                }
                else
                {
                    Console.WriteLine("Somthings are wrong");
                }
            }


            else if (kind == "Wheat")
            {
                if (amount == "WG")
                {
                    Console.WriteLine(metric * 135 + " gram");
                }
                else if (amount == "TC")
                {
                    Console.WriteLine(metric * 65 + " gram");
                }
                else if (amount == "CC")
                {
                    Console.WriteLine(metric * 50 + " gram");
                }
                else if (amount == "TS")
                {
                    Console.WriteLine(metric * 20 + " gram");
                }
                else
                {
                    Console.WriteLine("Somthings are wrong");
                }
            }


            else if (kind == "Cocoa")
            {
                if (amount == "WG")
                {
                    Console.WriteLine(metric * 100 + " gram");
                }
                else if (amount == "TC")
                {
                    Console.WriteLine(metric * 40 + " gram");
                }
                else if (amount == "CC")
                {
                    Console.WriteLine(metric * 30 + " gram");
                }
                else if (amount == "TS")
                {
                    Console.WriteLine(metric * 8 + " gram");
                }
                else
                {
                    Console.WriteLine("Somthings are wrong");
                }
            }
            else
            {
                Console.WriteLine("Somthings are wrong");
            }
            Console.WriteLine("Press enter and go next question");
            Console.ReadLine();
            //******************************Questions 2 END********************************************************
            //******************************Questions 3 ***********************************************************
            Console.WriteLine("A program that takes the current date and time in Turkey from the user and prints the date and time in Japon");
            Console.Write("day = ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("month= ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("year= ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("hour= ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("minute= ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("PM or AM ?");
            string pmam = Console.ReadLine();

            if (pmam == "PM")
            {

               if ((hour > 6) & (hour < 12))
                {
                    if (month == 1 | month == 3 | month == 5 | month == 7 | month == 8 | month == 10 | month == 12)
                    {
                        if (day == 31)
                        {
                            if (month == 12)
                            {
                                Console.WriteLine("1" + "/" + "1" + "/" + (year + 1) + "  " + (hour - 6) + ":" + minute + " AM");
                            }
                            else
                            {
                                Console.WriteLine("1"s + "/" + (month + 1) + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                            }
                        }
                        else 
                        {
                            Console.WriteLine((day + 1) + "/" + month + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                        }
                        
                    }
                    else if (month == 2)
                    {
                        if (day == 28)
                        {
                            if ((month % 4) == 0)
                            {
                                Console.WriteLine("29" + "/" + "3" + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                            }
                            else
                            {
                                Console.WriteLine("1" + "/" + "3" + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                            }

                        }
                        else if ((0 < day) & (day < 28))
                        {
                            Console.WriteLine((day + 1) + "/" + month + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                        }
                        else
                        {
                            Console.WriteLine("Somthings are wrong");
                        }
                    }
                    else if (month == 4 | mont == 6 | mont == 9 | month == 11)
                    {
                         if (day == 31)
                        {
                              Console.WriteLine("1" + "/" + (month + 1) + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                    }
                   
                   
                   
                   
                   
                   Console.WriteLine(day + "/" + month + "/" + year + "  " + (hour - 6) + ":" + minute + " AM");
                }
                else if ((hour > 0) & (hour < 7))
                {

                    Console.WriteLine(day + "/" + month + "/" + year + "  " + (hour+6) + ":" + minute + " PM");
                }
                else
               {
                   Console.WriteLine("Somthings are wrong");
               }
            }

            else if (pmam == "AM")
            {

                if (hour == 12)
                {
                    Console.WriteLine(day + "/" + month + "/" + year + "  " + "06" + ":" + minute + " PM");
                }
                else if ((hour > 0) & (hour < 7))
                {
                    Console.WriteLine(day + "/" + month + "/" + year + "  " + (hour + 6) + ":" + minute + " AM");
                }
                else if ((hour > 6) & (hour < 12))
                {
                    Console.WriteLine(day + "/" + month + "/" + year + "  " + (hour - 6) + ":" + minute + " PM");
                }
            }
            else
            {
                Console.WriteLine("Somthings are wrong");
            }
            Console.WriteLine("Press enter and exit");
            Console.ReadLine();
            //******************************Questions 3 END********************************************************







        }
    }
}
