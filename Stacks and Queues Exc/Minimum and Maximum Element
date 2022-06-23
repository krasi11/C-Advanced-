using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueue = int.Parse(Console.ReadLine());
            Stack<int> integers = new Stack<int>();
            for (int i = 0; i < numberOfQueue; i++)
            {
                string[] Command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (Command[0])
                {
                    case "1":
                        integers.Push(int.Parse(Command[1]));
                        break;
                    case "2":
                        if (integers.Any())
                        {
                            integers.Pop();
                        }
                        break;
                    case "3":
                        if (integers.Count>0)
                        {
                            Console.WriteLine(integers.Max()); 
                        }
                        break;
                    case "4":
                        if (integers.Count>0)
                        {
                            Console.WriteLine(integers.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", " , integers));
        }
        
    }
}
