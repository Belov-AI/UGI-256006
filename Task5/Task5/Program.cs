using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate();

            Console.WriteLine(Math.Round(x, 3));
        }

        //static double Calculate() => throw new NotImplementedException();

        static double Calculate() => F(2, 2) + F(5, 3) + F(11, 5);

        static double F(double x, double y) => Math.Sqrt((1 + Math.Sqrt(x)) / y );
    }
}
