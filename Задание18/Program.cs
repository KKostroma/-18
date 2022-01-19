using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            Console.WriteLine(Stroka(line));
            Console.ReadKey();
        }
        static bool Stroka(string line)
        { 
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>
            {
                {'(',')' },
                {'[',']' },
                {'{','}' },
            };
            foreach (char n in line)
            {
                if (n == '(' || n == '[' || n == '{')
                    stack.Push(dict[n]);
                if (n == ')' || n == ']' || n == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != n)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
