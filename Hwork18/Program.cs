using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "([]{ })[]";
            Stack<char> scoba = new Stack<char>();
            foreach (var i in str)
            {
                if (i == '(' || i == '[' || i == '{')
                {
                    scoba.Push(i);
                }
                if (i == ')')
                {
                    if (scoba.Contains('('))
                    {
                        scoba.Pop();
                    }
                }
                if (i == ']')
                {
                    if (scoba.Contains('['))
                    {
                        scoba.Pop();
                    }
                }
                if (i == '}')
                {
                    if (scoba.Contains('{'))
                    {
                        scoba.Pop();
                    }
                }
            }

            if (scoba.Count == 0)
            {
                Console.WriteLine("Скобки расставлены верно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не верно");
            }
            Console.ReadKey();
        }
    }
}
