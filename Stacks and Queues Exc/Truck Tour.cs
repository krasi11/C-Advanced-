using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPumps = int.Parse(Console.ReadLine());
            Queue<Pump> Pumps = new Queue<Pump>();
            long AmountPetrol = 0;
            for (int i = 0; i < NumberOfPumps; i++)
            {
                long[] AmountDistance = Console.ReadLine().Split().Select(long.Parse).ToArray();
                Pump CurrentPump = new Pump(i, AmountDistance[0], AmountDistance[1]);
                Pumps.Enqueue(CurrentPump);
            }
            bool isEnough = false;
            int Counter = 0;
            while (!isEnough)
            {
                AmountPetrol += Pumps.Peek().Amount;
                if (AmountPetrol>=Pumps.Peek().Distance)
                {
                    Counter++;
                    AmountPetrol -= Pumps.Peek().Distance;
                }
                else
                {
                    AmountPetrol = 0;
                    Counter = 0;
                }
                Pumps.Enqueue(Pumps.Dequeue());
                if (Counter == NumberOfPumps)
                {
                    isEnough = true;
                }
            }
            Console.WriteLine(Pumps.Peek().Name);
        }
        
    }
    class Pump
    {
        public Pump(int name, long amount, long distance)
        {
            Name = name;
            Amount = amount;
            Distance = distance;
        }
        public int Name { get; set; }
        public long Amount { get; set; }
        public long Distance { get; set; }
    }
}
