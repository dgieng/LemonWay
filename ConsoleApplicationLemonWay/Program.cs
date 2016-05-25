using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationLemonWay
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WSLemonWay.Service ws = new WSLemonWay.Service())
            {
                int result = ws.Fibonacci(10);
                Console.WriteLine("Le résultat de Fibonnaci(10) est " + result);
                Console.ReadLine();
            }
        }
    }
}
