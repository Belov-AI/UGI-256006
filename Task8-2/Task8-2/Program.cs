using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            var amount = int.Parse(Console.ReadLine());

            var sum = 0;
            var product = 1;

            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine("Введите число");
                var number = int.Parse(Console.ReadLine());

                sum += number;
                product *= sum;
            }

            Console.WriteLine($"Произведение частичных сумм равно {product}");
        }
    }
}
