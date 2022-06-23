using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            string Expression = Console.ReadLine();
            Stack<char> Parantheses = new Stack<char>();
            bool IsBalanced = false;
            foreach (char item in Expression)
            {
                if (item == '('||item=='['||item=='{')
                {
                    Parantheses.Push(item);
                }
                else if (item == ')'||item == ']'||item == '}')
                {
                    string Both = Parantheses.Peek().ToString() + item;
                    if ((Both != "{}") && (Both!="[]") && (Both!="()"))
                    {
                        IsBalanced = true;
                        Parantheses.Pop();
                    }
                }
            }
            if (IsBalanced)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
        }
        
    }
    
}
