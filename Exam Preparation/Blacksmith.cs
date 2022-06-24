using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrepAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Steel = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] Carbon = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> quantitySteel = new Queue<int>(Steel);
            Stack<int> quantityCarbon = new Stack<int>(Carbon);

            SortedDictionary<string, int> Swords = new SortedDictionary<string, int>
            {
                {"Broadsword", 0 },
                {"Sabre", 0 },
                {"Katana", 0 },
                {"Shamshir", 0 },
                {"Gladius", 0 }

            };
            int TotalSwords = 0;
            while (quantitySteel.Count>0&&quantityCarbon.Count>0)
            {
                int CurrentSteel = quantitySteel.Peek();
                int CurrentCarbon = quantityCarbon.Peek();
                int Sum = CurrentSteel + CurrentCarbon;

                if (Sum == 70)
                {
                    Swords["Gladius"]++;
                    TotalSwords++;
                    quantitySteel.Dequeue();
                    quantityCarbon.Pop();
                }
                else if (Sum == 80)
                {
                    Swords["Shamshir"]++;
                    TotalSwords++;
                    quantitySteel.Dequeue();
                    quantityCarbon.Pop();
                }
                else if (Sum == 90)
                {
                    Swords["Katana"]++;
                    TotalSwords++;
                    quantitySteel.Dequeue();
                    quantityCarbon.Pop();
                }
                else if (Sum == 110)
                {
                    Swords["Sabre"]++;
                    TotalSwords++;
                    quantitySteel.Dequeue();
                    quantityCarbon.Pop();
                }
                else if (Sum == 150)
                {
                    Swords["Broadsword"]++;
                    TotalSwords++;
                    quantitySteel.Dequeue();
                    quantityCarbon.Pop();
                }
                else
                {
                    quantitySteel.Dequeue();
                    CurrentCarbon += 5;
                    quantityCarbon.Pop();
                    quantityCarbon.Push(CurrentCarbon);
                }
            }
            if (TotalSwords >= 1)
            {
                Console.WriteLine($"You have forged {TotalSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if (quantitySteel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine(string.Join(",",quantitySteel));
            }
            if (quantityCarbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine("Carbon left: " + string.Join(", ", quantityCarbon));
            }

            
            foreach (var swordItem in Swords.OrderBy(pair => pair.Key))
            {
                
                if (swordItem.Value > 0)
                {
                    Console.WriteLine($"{swordItem.Key}: {swordItem.Value}");
                }
            }
        }
    }
}
