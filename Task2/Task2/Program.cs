using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите большое основание трапеции");
            double bigBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту трапеции");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите угол при основании трапеции в градусах");
            double angleInDegrees = double.Parse(Console.ReadLine());

            double angleInRadians = angleInDegrees * Math.PI / 180;

            double smallBase = bigBase-2*height/Math.Tan(angleInRadians);

            double area = height * (bigBase + smallBase) / 2;

            double leg = height / Math.Sin(angleInRadians);

            double perimeter = 2 * leg + bigBase + smallBase;

            Console.WriteLine("Площадь трапеции " + Math.Round(area,3));
            Console.WriteLine("Периметр трапеции " + Math.Round(perimeter,3));


        }
    }
}
