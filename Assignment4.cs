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
            //********************************************** QUESTİON 1************************************************************
            Random random = new Random();
            int[] player1 = new int[6];
            int[] player2 = new int[6];
            int temp= 0;
            int count = 0;
            int count2 = 0;
            bool chinko = true;
            bool flag = false;
            //generate random array
            for (int i = 0; i < 6; i++)
            {
                //for player1 random numbers
                
                do
                {
                    flag = false;
                    temp = random.Next(1, 21);

                   
                    for (int j = 0; j < i; j++)
                    {
                        if (player1[j] == temp)
                        {
                            flag = true;
                        }
                    }
                } while (flag);
                player1[i] = temp;

                //for player1 random numbers
                
                do
                {
                    flag = false;
                    temp = random.Next(1, 21);


                    for (int j = 0; j < i; j++)
                    {
                        if (player2[j] == temp)
                        {
                            flag = true;
                        }
                    }
                } while (flag);
                player2[i] = temp;
            }
            //generate random array END

            while (true)
            {
                //write array
                Console.WriteLine("");
                Console.Write("Array 1 :");
                for (int i = 0; i < 6; i++)
                {
                    if (player1[i] == 0)
                    {
                        continue;
                    }
                    Console.Write(" " + player1[i]);
                }
                Console.WriteLine("");
                Console.Write("Array 2 :");
                for (int i = 0; i < 6; i++)
                {
                    if (player2[i] == 0)
                    {
                        continue;
                    }
                    Console.Write(" " + player2[i]);
                }
                Console.WriteLine("");
                //write array END

                //_______Check Numbers____________________________
                temp = random.Next(1, 21);
                Console.WriteLine("Selected number : " + temp);

                for (int i = 0; i < 6; i++)
                {
                    if (player1[i] == temp)
                    {
                        player1[i] = 0;
                        count++;
                    }
                    if (player2[i] == temp)
                    {
                        player2[i] = 0;
                        count2++;
                    }
                }
               
                //Çinko ??
                while (chinko)
                {
                    if (count == 3)
                    {
                        Console.WriteLine("First chinko - Player1 wins the smallest prize ");//İngilizcede Ç harfi yoktur. O yüzden ch koydum :))
                        chinko = false;
                    }
                    if (count2 == 3)
                    {
                        Console.WriteLine("First chinko - Player2 wins the smallest prize ");
                        chinko = false;
                    }
                    break;
                }
                //Çinko ?? END

                if (count == 6)
                {
                    Console.WriteLine("Tombala - Player1 wins the grand prize ");
                    break;
                }
                if (count2 == 6)
                {
                    Console.WriteLine("Tombala - Player2 wins the grand prize ");
                    break;
                }
                //______________Check Numbers END____________________________________________

                Console.WriteLine("\nPress enter for next step..");
                Console.ReadLine();
            }
           


            

            //********************************************** QUESTİON 1 END************************************************************

            Console.WriteLine("\n\nPlease enter for next question..");
            Console.ReadLine();
            //********************************************** QUESTİON 2************************************************************
            int[] p1 = new int[8];
            int[] p2 = new int[8];
            int[] p3 = new int[8];
            
            while (true)
            {
                count = 0;
                flag = true; // satırı seçerken satırın dolu olup olmadığını kontrol için kullanılacak.
                while (flag)//satır doluluk kontrolü için sonsuz bir döngü.
                {
                    temp = random.Next(1, 4);//choose row
                    for (int i = 0; i < 8; i++)//her satırda 8 stun olduğu için..
                    {
                        if (temp == 1)
                        {
                            if (p1[i] == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        else if (temp == 2)
                        {
                            if (p2[i] == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        else
                        {
                            if (p3[i] == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (!(p1[i] == 0))
                        {
                            count++;
                        }
                        if (!(p2[i] == 0))
                        {
                            count++;
                        }
                        if (!(p3[i] == 0))
                        {
                            count++;
                        }
                    }
                    if (count == 24)//count 24 ise tüm satırlar doldu demektir ve beraberlik durumu olur..
                    {
                        Console.WriteLine("\n\nTie");
                        Console.WriteLine("Press enter for exit..");
                        Console.ReadLine();
                    }
                }
                //For white, 1 is white
                switch (temp)
                {
                    case 1:
                        {
                            while (true)
                            {
                                temp = random.Next(0, 8);//choose column
                                if (p1[temp] == 0)
                                {
                                    p1[temp] = 1;//assign 1 for white
                                    break;
                                }
                            }

                            break;
                        }
                    case 2:
                        {
                            while (true)
                            {
                                temp = random.Next(0, 8);//choose column
                                if (p2[temp] == 0)
                                {
                                    p2[temp] = 1;//assign 1 for white
                                    break;
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            while (true)
                            {
                                temp = random.Next(0, 8);//choose column
                                if (p3[temp] == 0)
                                {
                                    p3[temp] = 1;//assign 1 for white
                                    break;
                                }
                            }

                            break;
                        }
                    default:
                        break;
                }

                //For green, 2 is green
                flag = true; // satırı seçerken satırın dolu olup olmadığını kontrol için kullanılacak.
                while (flag)//satır doluluk kontrolü
                {
                    temp = random.Next(1, 4);//choose row
                    for (int i = 0; i < 8; i++)
                    {
                        if (temp == 1)
                        {
                            if (p1[i] == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        else if (temp == 2)
                        {
                            if (p2[i] == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        else
                        {
                            if (p3[i] == 0)
                            {
                                flag = false;
                                break;
                            }
                        }                        
                    }
                }
                switch (temp)
                {
                    case 1:
                        {
                            
                            while (true)
                            {
                                temp = random.Next(0, 8);//choose column
                                if (p1[temp] == 0)
                                {
                                    p1[temp] = 2; //assign 2 for green
                                    break;
                                }
                            }

                            break;
                        }
                    case 2:
                        {
                            while (true)
                            {
                                temp = random.Next(0, 8);//choose column
                                if (p2[temp] == 0)
                                {
                                    p2[temp] = 2; //assign 2 for green
                                    break;
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            while (true)
                            {
                                temp = random.Next(0, 8);//choose column
                                if (p3[temp] == 0)
                                {
                                    p3[temp] = 2; //assign 2 for green
                                    break;
                                }
                            }

                            break;
                        }
                    default:
                        break;
                }
                Console.Write("    -------------------------------- \nP1 |");//row 1
                for (int i = 0; i < 8; i++)
                {
                    if (p1[i] == 1)
                    {
                        Console.Write(" W |");

                    }
                    else if (p1[i] == 2)
                    {
                        Console.Write(" ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("G");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.Write("\n    --------------------------------\n");//row 1 END

                Console.Write("    -------------------------------- \nP2 |");//row 2
                for (int i = 0; i < 8; i++)
                {
                    if (p2[i] == 1)
                    {
                        Console.Write(" W |");
                    }
                    else if (p2[i] == 2)
                    {
                        Console.Write(" ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("G");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.Write("\n    --------------------------------\n");//row 2 END

                Console.Write("    -------------------------------- \nP3 |");//row 3
                for (int i = 0; i < 8; i++)
                {
                    if (p3[i] == 1)
                    {
                        Console.Write(" W |");
                    }
                    else if (p3[i] == 2)
                    {
                        Console.Write(" ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("G");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.Write("\n    --------------------------------\n");//row 3 END
                Console.WriteLine("\n**********************************************************\n");

                //Check result

                

                for (int i = 0; i < 8; i++)
                {
                    if (p1[i] == 1 & p2[i] == 1 & p3[i] == 1)
                    {
                        Console.WriteLine("\n\n winner: White");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if ((p1[i] == 2 & p2[i] == 2 & p3[i] == 2))
                    {
                        Console.WriteLine("\n\n winner: Green");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    //check row 1
                    if (p1[i] == 1 & p1[i+1] == 1 & p1[i+2] == 1)
                    {
                        Console.WriteLine("\n\n winner: White");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if (p1[i] == 2 & p1[i + 1] == 2 & p1[i + 2] == 2)
                    {
                        Console.WriteLine("\n\n winner: Green");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    //check row 1 END
                    //check row 2
                    if (p2[i] == 1 & p2[i + 1] == 1 & p2[i + 2] == 1)
                    {
                        Console.WriteLine("\n\n winner: White");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if (p2[i] == 2 & p2[i + 1] == 2 & p2[i + 2] == 2)
                    {
                        Console.WriteLine("\n\n winner: Green");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    //check row 2 END

                    //check row 3
                    if (p3[i] == 1 & p3[i + 1] == 1 & p3[i + 2] == 1)
                    {
                        Console.WriteLine("\n\n winner: White");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if (p3[i] == 2 & p3[i + 1] == 2 & p3[i + 2] == 2)
                    {
                        Console.WriteLine("\n\n winner: Green");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    //check row 3 END

                    //Çapraz kontroller
                    if (p1[i] == 1 & p2[i+1] == 1 & p3[i+2] == 1)
                    {
                        Console.WriteLine("\n\n winner: White");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if ((p1[i] == 2 & p2[i+1] == 2 & p3[i+2] == 2))
                    {
                        Console.WriteLine("\n\n winner: Green");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if (p1[i+2] == 1 & p2[i + 1] == 1 & p3[i] == 1)
                    {
                        Console.WriteLine("\n\n winner: White");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if ((p1[i+2] == 2 & p2[i + 1] == 2 & p3[i] == 2))
                    {
                        Console.WriteLine("\n\n winner: Green");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    //Çapraz kontroller Bitti.
                }

                Console.WriteLine("Press enter for next step");
                Console.ReadLine();
            }




            //********************************************** QUESTİON 2 END************************************************************
           
        }
    }
}
