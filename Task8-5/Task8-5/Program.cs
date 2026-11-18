using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = InputNumber("Введите коэффициент при x^2");
            var b = InputNumber("Введите коэффициент при x");
            var c = InputNumber("Введите свободный член");

            var epsilon = InputNumber("Введите точность вычислений");

            double leftBound = 0;

            while(F(leftBound,a,b,c) <= -epsilon)
                leftBound--;

            var rightBound = 0.0;

            while (rightBound >= epsilon)
                rightBound++;

            double x = 0;

            while(rightBound - leftBound > 2 * epsilon)
            {
                x = (leftBound + rightBound) / 2;

                var f = F(x,a,b,c);

                if (f <= -epsilon)
                    rightBound = x;
                else if (f >= epsilon)
                    leftBound = x;
                else
                    break;
            }

            Console.WriteLine($"Корень уравнения f(x) = 0: {x}");               
        }

        static double F(double x, double a, double b, double c) => 
            a * x * x + b * x + c - Math.Exp(x);

        static double InputNumber(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }
    }
}
