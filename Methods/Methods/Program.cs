using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int c = 5;
        static void Main(string[] args)
        {
            var x = GetCoordinate("Введите 1-ю координату вектора");
            var y = GetCoordinate("Введите 2-ю координату вектора");

            var vectorLength = Math.Sqrt(Square(x,y));

            Console.WriteLine("Длина вектора равна " + vectorLength);

            int sum = Square(1) + Square(5) + Square(7);

            //{
                var a = 0x91;
                var b = a.ToString();
                Console.WriteLine(b);
            //}

            a = 2;
            c = 0;
            Console.WriteLine(a);
        }

        /// <summary>
        /// Ввод координаты вектора с консоли
        /// </summary>
        /// <param name="message">Запрос ввода</param>
        /// <returns>координата</returns>
        static double GetCoordinate(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }

        //static double Square(double x)
        //{
        //    return x * x;
        //}

        static double Square(double x) => x * x;

        static int Square(int x) => x * x;

        static double Square(double x, double y) => Square(x) + Square(y);
    }
}
