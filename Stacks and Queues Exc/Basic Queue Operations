using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> SNX = new Queue<int>(integers);

            int N = input[0];
            int S = input[1];
            int X = input[2];

            for (int i = 0; i < S; i++)
            {
                SNX.Dequeue();
            }
            if (SNX.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (SNX.Count >0)
                {
                    Console.WriteLine(SNX.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
        
    }
}
