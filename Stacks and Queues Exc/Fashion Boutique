using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> CapClothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int RackCapacity = int.Parse(Console.ReadLine());
            int CurrentRackCapacity = 0;
            int RackCounter = 1;
            while (CapClothes.Count>0)
            {
                if (CurrentRackCapacity+CapClothes.Peek()>RackCapacity)
                {
                    CurrentRackCapacity = 0;
                    RackCounter++;
                }
                CurrentRackCapacity += CapClothes.Pop();
            }
            Console.WriteLine(RackCounter);
        }
        
    }
}
