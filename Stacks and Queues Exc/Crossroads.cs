using System;
using System.Collections.Generic;
using System.Linq;

namespace Crosswords
{
    class Program
    {
        static void Main(string[] args)
        {
            int GreenLight = int.Parse(Console.ReadLine());
            int FreeWindowDuration = int.Parse(Console.ReadLine());
            string Command = Console.ReadLine();
            Queue<string> Cars = new Queue<string>();
            int Counter = 0;
            while (Command!="END")
            {
                int GreenLightLeft = GreenLight;
                int FreeWindowLeft = FreeWindowDuration;
                switch (Command)
                {
                    case "green":
                        while (GreenLightLeft>0&&Cars.Any())
                        {
                            string Car = Cars.Dequeue();
                            GreenLightLeft -= Car.Length;
                            if (GreenLightLeft>=0)
                            {
                                Counter++;
                            }
                            else
                            {
                                FreeWindowLeft += GreenLightLeft;
                                if (FreeWindowLeft<0)
                                {
                                    Console.WriteLine($"Crash happened!{Environment.NewLine}{Car} was hit at {Car[Car.Length + FreeWindowLeft]}");
                                    return;
                                }
                                Counter++;
                            }
                        }
                        break;
                    default:
                        Cars.Enqueue(Command);
                        break;
                }
                Command = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.{Environment.NewLine}{Counter} total cars passed the crossroads.");
        }
    }
}
