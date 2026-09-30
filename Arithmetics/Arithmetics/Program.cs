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
            const double Phi = 1.6180339887498948482045868343656;

            int number = 2;

            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(number++ + ++number);
            Console.WriteLine(number);

            number += 3;
            Console.WriteLine(number);

            Console.WriteLine(Phi - (1 + 1 / Phi));

            //числа Фибоначчи 1, 1, 2, 3, 5, 8, 13, ...

            Console.WriteLine("Введите номер члена последовательности Фибоначчи");
            var n = int.Parse(Console.ReadLine());


            int fn = (int)((Math.Pow(Phi, n) - Math.Pow(-1, n) * Math.Pow(Phi, -n)) / Math.Sqrt(5));

            Console.WriteLine(fn);

            double x = 50;
            Console.WriteLine(x);

            var bigNumber = 123456789000000000L;

            checked
            {
                n = (int)bigNumber;
            }

            Console.WriteLine(n);
        }
    }
}
