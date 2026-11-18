using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число (не больше 2 млрд.)");
            var number = int.Parse(Console.ReadLine());

            var n = number;
            var digit = -1;
            var positionFromRightToLeft = -1;
            var counter = 0;

            while (n > 0) 
            {
                var d = n % 10;

                if (d > digit)
                {
                    digit = d;
                    positionFromRightToLeft = counter;
                }
                    
                n /= 10;
                counter++;
            }

            Console.WriteLine($"В числе {number} последняя самая большая цифра {digit} {counter-positionFromRightToLeft}-я слева");
        }
    }
}
