using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                    
                    //**************************************Questions 1 ***************************************************************
                    
                    //body
                    int first = 7, oldfirst = first, second = 1, third = 5, fourth = 1, fifth = 1;
                    for (int i = 1; i <= 7; i++)
                    {

                        for (int a = oldfirst - first; a >= 1; a--)
                        {
                            Console.Write(" ");
                        }
                        for (int b = first; b >= 1; b--)
                        {

                            Console.Write("*");

                        }

                        first--;


                        for (int c = 6; c >= second; c--)
                        {
                            Console.Write(" ");
                        }
                        second++;

                        for (int d = 1; (d <= third) && (third <= 17); d++)
                        {
                            Console.Write("+");
                        }
                        third = third + 2;

                        for (int e = 18; (e >= fourth) && (fourth <= 18); e--)
                        {
                            Console.Write(" ");
                        }
                        fourth = fourth + 3;

                        for (int f = 1; f <= fifth; f++)
                        {
                            Console.Write("+");
                        }
                        fifth = fifth + 4;

                        Console.WriteLine();
                    }
                    //body END

                    //leg
                    first = 6;
                    second = 43;

                    for (int i = 1; i <= 5; i++)
                    {


                        for (int a = first; a >= 1; a--)
                        {
                            Console.Write(" ");
                        }
                        first--;

                        for (int b = second; b >= 1; b--)
                        {
                            Console.Write("*");
                        }
                        second = second + 3;


                        Console.WriteLine();

                    }
                    //leg END
                    //**************************************Questions 1  END***************************************************************
                    
                    Console.WriteLine("Press enter for second solution..");
                    Console.ReadLine();
                   
                    //**************************************Questions 2 ***************************************************************

                    int firstNum = 2, secondNum = 4, thirdNum = 4, firstDen = 1, secondDen = 3, tempNum, tempNum2, tempDen, result = 0;
                    
                    for (int i = 1; i <= 12; i++)
                    {
                        tempNum = firstNum * secondNum;
                        tempNum2 = thirdNum;

                        for (int j = 1; j <= i; j++)
                        {
                            if (j <= 2)
                            {
                                tempNum *= thirdNum;
                            }
                            
                            if (j >= 3)
                            {
                                tempNum2 -= 2;
                                tempNum *= tempNum2;
                            }
                        }

                        tempDen = firstDen * secondDen;
                        for (int k = 2; k <= i; k++)
                        {
                            tempDen *= (secondDen + k);
                        }

                        firstDen += 2;
                        secondDen += 2;
                        thirdNum += 2;
                        result += tempNum  / tempDen;
                    }
                    Console.WriteLine("Result = " + result);
                   
                    
                    //**************************************Questions 2 END ***************************************************************

                    Console.WriteLine("Press enter for third solution..");
                    Console.ReadLine();

                    //**************************************Questions 3 END ***************************************************************
                    string check = "";

                    Console.Write("Please enter the month : ");
                    int month;
                    while (true)
                    {
                        check = Console.ReadLine();
                        if ((check.All(char.IsDigit)) & (check != ""))
                        {
                            month = Convert.ToInt32(check);
                            if ((month >= 1) & (month <= 12))
                            {
                                break;
                            }
                            
                        }
                        Console.Write("Please enter only among 1-12 integer :  ");
                    }
                    

                    Console.Write("Please enter the year : ");
                    while (true)
                    {
                        check = Console.ReadLine();
                        if ((check.All(char.IsDigit)) & (check != ""))
                        {
                            break;
                        }
                        Console.Write("Please enter only integer");
                    }
                    int year = Convert.ToInt32(check);

                    Console.Write("Please enter first day : ");
                    while (true)
                    {
                        check = Console.ReadLine();
                        if ((check == "monday") | (check == "tuesday") | (check == "wednesday") | (check == "thursday") | (check == "friday") | (check == "saturday") | (check == "sunday"))
                        {
                            break;
                        }
                        Console.Write("Please enter the day true :  ");
                    }
                    string day = check;
                   
                    int count = 1;
                    int dayNum=0;
                    day = day.ToLower();
                    switch (day)
                    {
                        case "monday":
                            dayNum = 1;
                            break;
                        case "tuesday":
                            dayNum = 2;
                            break;
                        case "wednesday":
                            dayNum = 3;
                            break;
                        case "thursday":
                            dayNum = 4;
                            break;
                        case "friday":
                            dayNum = 5;
                            break;
                        case "saturday":
                            dayNum = 6;
                            break;
                        case "sunday":
                            dayNum = 7;
                            break;
                        default:
                            Console.WriteLine("Somtings are wrong!");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }

                    int monthCount = 1;
                    if (month == 1)
                    {
                        Console.WriteLine("January " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }
                        

                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }

                            
                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }
                                    
                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                  else  if (month == 2)
                    {
                        Console.WriteLine("February " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum == 1)
                        {
                            count = 3;
                        }
                        else
                        {
                            count = 4;
                        }
                        


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 28)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                   else if (month == 3)
                    {
                        Console.WriteLine("March " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                   else if (month == 4)
                    {
                        Console.WriteLine("April " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 7)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 30)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                   else if (month == 5)
                    {
                        Console.WriteLine("May " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                   else if (month == 6)
                    {
                        Console.WriteLine("June " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 7)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 30)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                  else  if (month == 7)
                    {
                        Console.WriteLine("July " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                  else  if (month == 8)
                    {
                        Console.WriteLine("August " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                   else if (month == 9)
                    {
                        Console.WriteLine("September " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 7)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 30)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                   else if (month == 10)
                    {
                        Console.WriteLine("October " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                  else  if (month == 11)
                    {
                        Console.WriteLine("November " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 7)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 30)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                  else  if (month == 12)
                    {
                        Console.WriteLine("December " + year);
                        Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
                        if (dayNum >= 6)
                        {
                            count = 5;
                        }
                        else
                        {
                            count = 4;
                        }


                        for (int i = 1; i <= 7; i++)
                        {
                            if (i >= dayNum)
                            {
                                Console.Write(monthCount + "   ");
                                monthCount++;
                            }
                            else
                            {
                                Console.Write("    ");
                            }


                        }
                        Console.WriteLine();
                        for (int j = 1; j <= count; j++)
                        {
                            for (int k = 1; k <= 7; k++)
                            {
                                if (monthCount <= 31)
                                {
                                    if (monthCount % 10 == monthCount)
                                    {
                                        Console.Write(monthCount + "   ");
                                    }
                                    else
                                    {
                                        Console.Write(monthCount + "  ");
                                    }

                                    monthCount++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Somethings are wrong!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    
            
        
                    //**************************************Questions 3 END ***************************************************************





                    Console.WriteLine("Please enter for exit.");
                    Console.ReadLine();

        }
    }
}
