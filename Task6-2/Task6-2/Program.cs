using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = "клавесин";

            var result1 = word.Substring(3, 3) + word.Remove(0,7) + word.Substring(2,1);
            var result2 = word.Substring(5, 1) + word.Substring(3, 2) + word.Remove(3);

            Console.WriteLine($"В начале было слово \"{word}\".");
            Console.WriteLine($"Мы получили слова \"{result1}\" и \"{result2}\".");
        }
    }
}
