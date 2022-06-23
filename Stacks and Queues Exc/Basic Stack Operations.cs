using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> SNX = new Stack<int>(integers);

            int NumGoPop = input[1];
            int NumToFind = input[2];
            for (int i = 0; i < NumGoPop; i++)
            {
                SNX.Pop();
            }
            if (SNX.Contains(NumToFind))
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
                    Console.WriteLine(SNX.Count);
                }
            }
        }
        
    }
}
