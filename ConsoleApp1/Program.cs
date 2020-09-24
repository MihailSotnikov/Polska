using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Введите выражение: "); 
                Console.WriteLine(RPN.Calculate(Console.ReadLine())); 
            }
        }
    }
}
