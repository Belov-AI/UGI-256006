using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = InputNumber("k");
            var m = InputNumber("m");
            var n = InputNumber("n");

            Console.WriteLine("Значение логического выражения: " + IsStatementTrue(k, m, n));
        }

        static int InputNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }

        static bool IsStatementTrue(int k, int m, int n) =>
            k % 2 == 0 && m % 2 == 0 && n % 2 == 0 && k <= m && m <= n;
    }
}
