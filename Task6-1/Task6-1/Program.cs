using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке");
            var text = Console.ReadLine();

            var result = Translate(text);
            Console.WriteLine(result);
        }

        static string Translate(string s)
        {
            var result = s.ToUpper()
                .Replace("А", ".- ")
                .Replace("Б", "-... "); //и . д.

            return result;
        }
    }
}
