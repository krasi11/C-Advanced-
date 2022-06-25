using System;

namespace WallDestroyer
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] Wall = new char[n, n];
            int vRow = -1;
            int vCol = -1;
            int HCounter = 1;
            int RCounter = 0;

            for (int r = 0; r < n; r++)
            {
                char[] inputLine = Console.ReadLine().ToCharArray();

                for (int c = 0; c < n; c++)
                {
                    Wall[r, c] = inputLine[c];
                    if (Wall[r, c] == 'V')
                    {
                        vRow = r;
                        vCol = c;
                    }
                }
            }

            bool isElectrocuted = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (command.Equals("End"))
                {
                    break;
                }
                if (command.Equals("up"))
                {

                    if (IsInsideTheWallArea(vRow - 1, vCol))
                    {
                        MoveVanko(vRow - 1, vCol);
                    }
                }
                else if (command.Equals("down"))
                {
                    if (IsInsideTheWallArea(vRow + 1, vCol))
                    {
                        MoveVanko(vRow + 1, vCol);
                    }
                }
                else if (command.Equals("left"))
                {
                    if (IsInsideTheWallArea(vRow, vCol - 1))
                    {
                        MoveVanko(vRow, vCol - 1);
                    }
                }
                else if (command.Equals("right"))
                {
                    if (IsInsideTheWallArea(vRow, vCol + 1))
                    {
                        MoveVanko(vRow, vCol + 1);
                    }
                }
                if (isElectrocuted)
                {
                    break;
                }
            }

            if (isElectrocuted == false)
            {
                Console.WriteLine($"Vanko managed to make {HCounter} hole(s) and he hit only {RCounter} rod(s).");
            }
            else
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {HCounter} hole(s).");
            }

            PrintWall();


            void MoveVanko(int newVrow, int newVcol)
            {
                if (Wall[newVrow, newVcol] == '-')
                {
                    HCounter++;
                    Wall[vRow, vCol] = '*'; 
                    Wall[newVrow, newVcol] = 'V'; 
                    vRow = newVrow;
                    vCol = newVcol;
                }
                else if (Wall[newVrow, newVcol] == 'R') 
                {
                    RCounter++;
                    Console.WriteLine("Vanko hit a rod!");
                }
                else if (Wall[newVrow, newVcol] == 'C') 
                {
                    isElectrocuted = true;
                    Wall[vRow, vCol] = '*'; 
                    Wall[newVrow, newVcol] = 'E'; 
                    vRow = newVrow;
                    vCol = newVcol;
                    HCounter++;
                }
                else if (Wall[newVrow, newVcol] == '*') 
                {
                    Console.WriteLine($"The wall is already destroyed at position [{newVrow}, {newVcol}]!");
                    Wall[vRow, vCol] = '*'; 
                    Wall[newVrow, newVcol] = 'V'; 
                    vRow = newVrow;
                    vCol = newVcol;
                }
            }

            bool IsInsideTheWallArea(int row, int col)
            {
                if (row >= 0 && row < Wall.GetLength(0) && col >= 0 && col < Wall.GetLength(1))
                {
                    return true;
                }
                return false;
            }

            void PrintWall()
            {
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        Console.Write($"{Wall[r, c]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
