using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введит вещественное число > 1");
            var a = double.Parse(Console.ReadLine());

            int n = 0;

            double sum = 0;

            do
            {
                n++;
                sum += Math.Pow(n, -2.0/3);
            } while (sum <= a);

            Console.WriteLine($"Сумма {sum:F3} достигнута при n = {n}");
        }
    }
}
