using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 2;
            var y = 3;

            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x > y);
            Console.WriteLine(x != y);

            bool a = true, b = false, c;

            c = (a | b) & (!a ^ b);

            Console.WriteLine(c);

            c = (a || b) && (!a ^ b);

            Console.WriteLine(c);

            Console.WriteLine(x & y);
        }
    }
}
