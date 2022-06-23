using System;
using System.Collections.Generic;
using System.Linq;

namespace SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> Songs = new Queue<string>(InputSongs);
            List<string> ToBePrinted = new List<string>();
            while (Songs.Any())
            {
                string Command = Console.ReadLine();
                if (Command.Contains("Play"))
                {
                    Songs.Dequeue();
                }
                else if (Command.Contains("Add"))
                {
                    string Song = Command.Substring(4);
                    if (Songs.Contains(Song))
                    {
                        ToBePrinted.Add($"{Song} is already contained!");
                    }
                    else
                    {
                        Songs.Enqueue(Song);
                    }
                }
                else if (Command.Contains("Show"))
                {
                    ToBePrinted.Add(string.Join(", ", Songs));
                }
            }
            ToBePrinted.Add("No more songs!");
            foreach (var item in ToBePrinted)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
