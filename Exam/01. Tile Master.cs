using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    internal class Program
    {
        static void Main()
        {
            var WhiteTiles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var GreyTiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var Location = new Dictionary<string, int>()
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0 },
                {"Wall", 0},
                {"Floor", 0 }
            };

            while (WhiteTiles.Count > 0 && GreyTiles.Count > 0)
            {
                int currentWhiteTile = WhiteTiles.Peek();
                int currentGreyTile = GreyTiles.Peek();

                if (currentGreyTile == currentWhiteTile)
                {
                    int newLargerTile = currentGreyTile + currentWhiteTile;

                    GreyTiles.Dequeue();
                    WhiteTiles.Pop();

                    switch (newLargerTile)
                    {
                        case 40:
                            Location["Sink"]++;
                            break;
                        case 50:
                            Location["Oven"]++;
                            break;
                        case 60:
                            Location["Countertop"]++;
                            break;
                        case 70:
                            Location["Wall"]++;
                            break;
                        default:
                            Location["Floor"]++;
                            break;
                    }
                }
                else
                {
                    WhiteTiles.Pop();
                    WhiteTiles.Push(currentWhiteTile / 2);

                    GreyTiles.Dequeue();
                    GreyTiles.Enqueue(currentGreyTile);
                }

            }
            if (WhiteTiles.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", WhiteTiles)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (GreyTiles.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", GreyTiles)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            var orderedLocations = Location.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in orderedLocations)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
