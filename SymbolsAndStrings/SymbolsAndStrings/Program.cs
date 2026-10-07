using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolsAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letter = 'z';
            Console.WriteLine(letter);

            letter = (char)0x42F;
            Console.WriteLine(letter);

            var lowerCaseLetter = char.ToLower(letter);
            Console.WriteLine();
            Console.WriteLine(letter);
            Console.WriteLine(lowerCaseLetter);
        }
    }
}
