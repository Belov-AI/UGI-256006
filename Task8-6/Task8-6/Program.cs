using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = InputNumber("Левую границу промежутка");
            int b = InputNumber("Правую границу промежутка");

            for (int n = a; n <= b; n++)
            { 
                var sum = 0;

                var d = 2;

                var sqrt = Math.Sqrt(n)

                while (d <= sqrt)
                {
                    if (n % d == 0)
                        if (d * d == n)
                            sum += 1;
                        else
                            sum += 2;
                }

                Console.WriteLine(sum);
            }


        }

        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }


}
