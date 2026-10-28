using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой пешки");
            var whitePawnPosition = Console.ReadLine();

            int whiteH, whiteV;
            DecodePosition(whitePawnPosition, out whiteH, out whiteV);

            if (whiteH < 2 || whiteH > 7)
            {
                Console.WriteLine("Неверная позиция белой пешки");
                return;
            }

            Console.WriteLine("Введите позицию черной пешки");
            var blackPawnPosition = Console.ReadLine();

            int blackH, blackV;
            DecodePosition(blackPawnPosition, out blackH, out blackV);
            
            if (blackH < 2 || blackH > 7)
            {
                Console.WriteLine("Неверная позиция черной пешки");
                return;
            }

            if (blackPawnPosition == whitePawnPosition)
            {
                Console.WriteLine("Пешки не могут занимать одну клетку");
                return;
            }

            if (IsWhitePawnSrike(whitePawnPosition, blackPawnPosition) ||
                IsBlackPawnSrike(blackPawnPosition, whitePawnPosition))
                Console.WriteLine("Пешки находятся под боем друг друга");
            else
                Console.WriteLine("Пешки не находятся под боем друг друга");
        }

        static void DecodePosition(string position, out int horizontal, out int vertical)
        {
            horizontal = int.Parse(position.Substring(1));
            vertical = (int)position[0] - 0x60;
        }

        static bool IsWhitePawnSrike(string whitePawnPosition, string position)
        {
            int whiteH, whiteV;
            DecodePosition(whitePawnPosition,out whiteH, out whiteV);

            int pH, pV;
            DecodePosition(position, out pH, out pV);

            return pH == whiteH + 1 && Math.Abs(pV - whiteV) == 1;
        }

        static bool IsBlackPawnSrike(string blackPawnPosition, string position)
        {
            int blackH, blackV;
            DecodePosition(blackPawnPosition, out blackH, out blackV);

            int pH, pV;
            DecodePosition(position, out pH, out pV);

            return pH == blackH - 1 && Math.Abs(pV - blackV) == 1;
        }
    }
}
