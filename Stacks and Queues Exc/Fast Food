using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int Quantity = int.Parse(Console.ReadLine());
            Queue<int> Orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int BiggestOrder = Orders.Max();
            int Counter = Orders.Count();
            for (int i = 0; i < Counter; i++)
            {
                if (Quantity>=Orders.Peek())
                {
                    Quantity -= Orders.Dequeue();
                }
            }
            Console.WriteLine(BiggestOrder);
            Console.WriteLine(Orders.Count<=0?"Orders complete" : $"Orders left: {string.Join(" ",Orders)}");
        }
        
    }
}
