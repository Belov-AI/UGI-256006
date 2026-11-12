using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;

            while (true)
            {
                Console.WriteLine("Введите ненулевое целое число");
                b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("Число равно 0");
                    continue;
                }
                else
                    break;
            }

            var sum = 0;

            for (int number = -b * b; number <= b; number++) 
                sum += number * number * number;

            Console.WriteLine($"Сумма кубов чисел от {-b * b} до {b} равна {sum}");
        }
    }
}
