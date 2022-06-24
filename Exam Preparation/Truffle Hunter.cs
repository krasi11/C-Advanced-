using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrepAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[Size, Size];
            for (int Row = 0; Row <= Size-1; Row++)
            {
                char[] CurrentRowElements = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int Col = 0; Col < CurrentRowElements.Length; Col++)
                {
                    matrix[Row, Col] = CurrentRowElements[Col];
                }
            }
            int CountBlack = 0;
            int CountWhite = 0;
            int CountSummer = 0;
            int Eaten = 0;

            string Command = Console.ReadLine();

            while (Command!="Stop the hunt")
            {
                string CommandName = Command.Split()[0];
                int Row = int.Parse(Command.Split()[1]);
                int Col = int.Parse(Command.Split()[2]);
                if (CommandName == "Collect")
                {
                    char Truffel = matrix[Row, Col];
                    matrix[Row, Col] = '-';
                    if (Truffel == 'B')
                    {
                        CountBlack++;
                    }
                    else if (Truffel == 'W')
                    {
                        CountWhite++;
                    }
                    else if (Truffel == 'S')
                    {
                        CountSummer++;
                    }
                }
                else if (CommandName == "Wild_Boar")
                {
                    string Directions = Command.Split()[3];
                    switch (Directions)
                    {
                        case "up":
                            while (IsValid(Row,Size))
                            {
                                if (EatBoar(Row,Col,matrix))
                                {
                                    Eaten++;
                                }
                                Row -= 2;
                            }

                            break;
                        case "down":
                            while (IsValid(Row,Size))
                            {
                                if (EatBoar(Row,Col,matrix))
                                {
                                    Eaten++;
                                }
                                Row += 2;
                            }
                            break;
                        case "left":
                            while (IsValidCol(Col,Size))
                            {
                                if (EatBoar(Row,Col,matrix))
                                {
                                    Eaten++;
                                }
                                Col -= 2;
                            }
                            break;
                        case "right":
                            while (IsValidCol(Col,Size))
                            {
                                if (EatBoar(Row,Col,matrix))
                                {
                                    Eaten++;
                                }
                                Col += 2;
                            }
                            break;
                    }
                }
                Command = Console.ReadLine();
            }
            Console.WriteLine($"Peter manages to harvest {CountBlack} black, {CountSummer} summer, and {CountWhite} white truffles.");
            Console.WriteLine($"The wild boar has eaten {Eaten} truffles.");
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                for (int Col = 0; Col < matrix.GetLength(0); Col++)
                {
                    Console.Write(matrix[Row, Col] + " ");
                }
                Console.WriteLine();
            }
        }
        private static bool EatBoar(int Row,int Col,char[,] matrix)
        {
            char CurrSymbol = matrix[Row, Col];
            if (CurrSymbol == 'S'|| CurrSymbol == 'B'|| CurrSymbol == 'W')
            {
                matrix[Row, Col] = '-';
                return true;
            }
            return false;
        }
        public static bool IsValid(int Row,int Size)
        {
            return Row >= 0 && Row < Size;
        }
        public static bool IsValidCol(int Col,int Size)
        {
            return Col >= 0 && Col < Size;
        }
    }
    
}
