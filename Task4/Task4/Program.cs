using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var x = double.Parse(Console.ReadLine());

            var y = Calculate(x);

            Console.WriteLine("f(x) = " + y);
        }

        static double Calculate(double x) => Math.Sqrt((1 + Math.Cos(x))/ (1 + x * x));

    }
}
