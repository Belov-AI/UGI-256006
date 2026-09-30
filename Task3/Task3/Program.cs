using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            var number = int.Parse(Console.ReadLine());

            var tens = number / 10;
            var units = number % 10;

            var result = tens * 1001 + units * 110;

            Console.WriteLine("Вот что получилось " + result);
        }
    }
}
