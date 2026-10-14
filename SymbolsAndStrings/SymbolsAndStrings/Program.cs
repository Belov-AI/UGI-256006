using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            var str = "параход";
            var strN = "ход";
            Console.WriteLine(str.IndexOf(strN));

            var strNN = "парад";
            Console.WriteLine(str.IndexOf(strNN));

            Console.WriteLine(str);
            Console.WriteLine(str.Substring(3,2));

            str = str.ToUpper();
            Console.WriteLine(str);

            str = "я помню чудное мгновенье";
            var words = str.Split();

            str = "\tроман Л. Н. Толстого \n\"Война и мир\"\a";
            Console.WriteLine(str);
            Console.WriteLine("\x42F");

            str = @"C:\Users\БеловАлександрИльич\source\repos\UGI-256006 ""наш репозиторий""";
            Console.WriteLine(str);

            var x = Math.PI / 2;
            var y = Math.Sin(x);

            str = string.Format("sin({0:F3}) = {1}", x, y);
            Console.WriteLine(str);

            Console.WriteLine("Сейчас {0: HH:mm dd.MM.yy}", DateTime.Now);

            str = string.Format($"sin({x:F3}) = {y}");
            Console.WriteLine(str);
            Console.WriteLine($"{CultureInfo.CurrentCulture} { DateTime.Now.ToLongDateString()}");

            var oldCulture = CultureInfo.CurrentCulture;

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            str = string.Format($"sin({x:F3}) = {y}");
            Console.WriteLine(str);
            Console.WriteLine($"{CultureInfo.CurrentCulture} {DateTime.Now.ToLongDateString()}");

            CultureInfo.CurrentCulture = oldCulture;
            Console.WriteLine(CultureInfo.CurrentCulture);
        }
    }
}
