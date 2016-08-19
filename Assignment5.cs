using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //____________________________________Program 1_________________________________________________________________
            char[,] board =  

{{'2','Δ','Δ','3','1','0','1','1','1','0'},
 {'Δ','x','Δ','Δ','4','2','2','Δ','1','0'},
 {'2','5','Δ','Δ','Δ','Δ','2','2','y','1'},
 {'1','Δ','Δ','Δ','Δ','3','1','1','Δ','1'},
 {'z','2','3','3','2','1','t','1','1','1'}};


            int line = board.GetLength(0);   //   Her döngüde tek tek aynı fonksiyonu kullanmak yerine en başta bir
            int column = board.GetLength(1); //   değişkene atadım ve her seferinde aynı fonksiyonu çalıştırmaktan kurtulmuş oldum.
            int sCounter = 0;

            //How many is there string in the array??
            for (int i = 0; i < line; i++)
            {
                for (int j  = 0; j < column; j++)
                {
                    if (char.IsLetter(board[i, j]) && board[i, j] != 'Δ')//internetten bulduğum bir fonksiyon, char değişkeninin string harf olup olmadığını kontrol ediyor
                    {
                        sCounter++;
                    }
                }
            }
            //***************************************************************
            
            char[] counterChar = new char[sCounter];
            int[] dimensionsConter = new int[sCounter];
            int valueCounter = 0;

            //Assign the string to counterChar
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (char.IsLetter(board[i, j]) && board[i, j] != 'Δ')
                    {
                        counterChar[valueCounter] = board[i, j];
                        valueCounter++;
                    }
                }
            }
            //*********************************************

            //for all of the string
            for (int c = 0; c < valueCounter; c++)
            {
                //For all of the member of array
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        //if board i,j is string
                        if (board[i, j] == counterChar[c])
                        {
                            //check limit of the array
                            if (i != line - 1)
                            {
                                if (board[i + 1, j] == 'Δ')
                                {
                                    dimensionsConter[c]++; //
                                }
                            }
                            if (i != line - 1 && j != column - 1)
                            {
                                if (board[i + 1, j + 1] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                            if (j != column - 1)
                            {
                                if (board[i, j + 1] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                            if (j != 0)
                            {
                                if (board[i, j - 1] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                            if (i != 0)
                            {
                                if (board[i - 1, j] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                            if (i != 0 && j != 0)
                            {
                                if (board[i - 1, j - 1] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                            if (i != line - 1 && j != 0)
                            {
                                if (board[i + 1, j - 1] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                            if (i != 0 && j != column - 1)
                            {
                                if (board[i - 1, j + 1] == 'Δ')
                                {
                                    dimensionsConter[c]++;
                                }
                            }
                        }
                    }
                }
            }
            //****************************************************

            //write the numbers.
            for (int i = 0; i < sCounter; i++)
            {
                Console.WriteLine(counterChar[i]+" = "+ dimensionsConter[i]);
            }
            //*****************************************


            //____________________________________Program 1 END____________________________________
            Console.WriteLine("Press enter for second program");
            Console.ReadLine();
            //____________________________________Program 2    ____________________________________

            int[,] matrix = {{1, 5, 3, 3, 2, 1, 3},
                             {2, 1, 5, 3, 3, 2, 1},
                             {3, 2, 1, 5, 3, 3, 2},
                             {4, 3, 2, 1, 5, 3, 3},
                             {7, 4, 3, 2, 1, 5, 3}};


            bool check = true;
            
            for (int i = 1; 0 < board.GetLength(0); i++)//dizide taşma olmaması için 1. indexten başlıyor
            {
                for (int j = 1; j < board.GetLength(1); j++) //dizide taşma olmaması için 1.indexten başlıyor
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1])//sol üstüne bakarak tüm matrixi dolanıyor ve bir tane ters durum olursa çıkıyor.
                    {
                        check = false;
                        break;
                    }
                }
            }

            Console.WriteLine(check);
            Console.WriteLine("Please enter for exit");
            Console.ReadLine();




            //____________________________________Program 2 END____________________________________

















            /*

                  

















            char[,] board2 = {{'2','Δ','Δ','3','1','0','1','1','1','0'},
                                {'Δ','x','Δ','Δ','4','2','2','Δ','1','0'},
                                {'2','5','Δ','Δ','Δ','Δ','2','2','y','1'},
                                {'1','Δ','Δ','Δ','Δ','3','1','1','Δ','1'},
                                {'z','2','3','3','2','1','t','1','1','1'}};


            
            int countM = 0;
            int countN = 0;
            int countX = 0;
            int countY = 0;
            int countZ = 0;
            int countT = 0;

            //for first board 
            for (int i = 0; i < line; i++)         
            {
                for (int j = 0; j < column; j++)
                {
                    //counting the k
                    if (board[i, j] == 'k')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != line - 1)
                        {
                            if (board[i + 1, j] == 'Δ')
                            {
                                counterI[]++;
                            }
                        }
                        if (i != line - 1 && j != column - 1)
                        {
                            if (board[i + 1, j + 1] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                        if (j != column - 1)
                        {
                            if (board[i, j + 1] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board[i, j - 1] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board[i - 1, j] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board[i - 1, j - 1] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                        if (i != line - 1 && j != 0)
                        {
                            if (board[i + 1, j - 1] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                        if (i != 0 && j != column - 1)
                        {
                            if (board[i - 1, j + 1] == 'Δ')
                            {
                                counterI++;
                            }
                        }
                    }
                    if (board[i, j] == 'm')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != 3)
                        {
                            if (board[i + 1, j] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (i != 3 && j != 8)
                        {
                            if (board[i + 1, j + 1] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (j != 8)
                        {
                            if (board[i, j + 1] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board[i, j - 1] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board[i - 1, j] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board[i - 1, j - 1] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (i != 3 && j != 0)
                        {
                            if (board[i + 1, j - 1] == 'Δ')
                            {
                                countM++;
                            }
                        }
                        if (i != 0 && j != 8)
                        {
                            if (board[i - 1, j + 1] == 'Δ')
                            {
                                countM++;
                            }
                        }
                    }
                    if (board[i, j] == 'n')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != 3)
                        {
                            if (board[i + 1, j] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (i != 3 && j != 8)
                        {
                            if (board[i + 1, j + 1] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (j != 8)
                        {
                            if (board[i, j + 1] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board[i, j - 1] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board[i - 1, j] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board[i - 1, j - 1] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (i != 3 && j != 0)
                        {
                            if (board[i + 1, j - 1] == 'Δ')
                            {
                                countN++;
                            }
                        }
                        if (i != 0 && j != 8)
                        {
                            if (board[i - 1, j + 1] == 'Δ')
                            {
                                countN++;
                            }
                        }
                    }

                }
            }




            //for second board
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //counting the k
                    if (board2[i, j] == 'x')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != 4)
                        {
                            if (board2[i + 1, j] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (i != 4 && j != 9)
                        {
                            if (board2[i + 1, j + 1] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (j != 9)
                        {
                            if (board2[i, j + 1] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board2[i, j - 1] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board2[i - 1, j] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board2[i - 1, j - 1] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (i != 4 && j != 0)
                        {
                            if (board2[i + 1, j - 1] == 'Δ')
                            {
                                countX++;
                            }
                        }
                        if (i != 0 && j != 9)
                        {
                            if (board2[i - 1, j + 1] == 'Δ')
                            {
                                countX++;
                            }
                        }
                    }
                    if (board2[i, j] == 'y')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != 4)
                        {
                            if (board2[i + 1, j] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (i != 4 && j != 9)
                        {
                            if (board2[i + 1, j + 1] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (j != 9)
                        {
                            if (board2[i, j + 1] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board2[i, j - 1] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board2[i - 1, j] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board2[i - 1, j - 1] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (i != 4 && j != 0)
                        {
                            if (board2[i - 1, j - 1] == 'Δ')
                            {
                                countY++;
                            }
                        }
                        if (i != 0 && j != 9)
                        {
                            if (board2[i - 1, j + 1] == 'Δ')
                            {
                                countY++;
                            }
                        }
                    }
                    if (board2[i, j] == 'z')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != 4)
                        {
                            if (board2[i + 1, j] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (i != 4 && j != 9)
                        {
                            if (board2[i + 1, j + 1] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (j != 9)
                        {
                            if (board2[i, j + 1] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board2[i, j - 1] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board2[i - 1, j] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board2[i - 1, j - 1] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (i != 4 && j != 0)
                        {
                            if (board2[i + 1, j - 1] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                        if (i != 0 && j != 9)
                        {
                            if (board2[i - 1, j + 1] == 'Δ')
                            {
                                countZ++;
                            }
                        }
                    }
                    if (board2[i, j] == 't')//i. satır ve j. stundaki eleman k ise etrafında elmas varsa countu 1 arttır.
                    {

                        if (i != 4)
                        {
                            if (board2[i + 1, j] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (i != 4 && j != 9)
                        {
                            if (board2[i + 1, j + 1] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (j != 9)
                        {
                            if (board2[i, j + 1] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board2[i, j - 1] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board2[i - 1, j] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (i != 0 && j != 0)
                        {
                            if (board2[i - 1, j - 1] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (i != 4 && j != 0)
                        {
                            if (board2[i + 1, j - 1] == 'Δ')
                            {
                                countT++;
                            }
                        }
                        if (i != 0 && j != 9)
                        {
                            if (board2[i - 1, j + 1] == 'Δ')
                            {
                                countT++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine('k={0}\nm={1}\nn={2}', counterI, countM, countN);
            Console.ReadLine();
            */
        }
    }
}
