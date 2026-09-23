using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(number++ + ++number);
            Console.WriteLine(number);

            number += 3;
            Console.WriteLine(number);
        }
    }
}
