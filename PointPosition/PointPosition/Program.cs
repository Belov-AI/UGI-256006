using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = InputCoordinate("Введите 1-ю координату точки");
            var y = InputCoordinate("Введите 2-ю координату точки");

            Console.WriteLine(GetPosition(x, y));
        }

        static double InputCoordinate(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }

        static string GetPosition(double x, double y) 
        {
            if (x != 0 && y != 0)
                if (x > 0)
                    if (y > 0)
                        return "Точка лежит в I квадранте";
                    else
                        return "Точка лежит в IV квадранте";
                else
                    if( y > 0)
                        return "Точка лежит во II квадранте";
                    else
                        return "Точка лежит в III квадранте";
            else
                if(x == 0)
                    if(y == 0)
                        return "Точка совпадает с началом координат";
                    else
                        return "Точка лежит на оси Oy";
                else
                    return "Точка лежит на оси Ox";
        }        
    }
}
