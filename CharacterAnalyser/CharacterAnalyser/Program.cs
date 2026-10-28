using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            var input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Символ не введен");
                return;
            }
            else if (input.Length > 1)
            {
                Console.WriteLine("Ведено несколько символов");
                return;
            }
            else
            {
                var ch = input[0];
                Console.WriteLine(Analyse(ch));
            }
        }

        static string Analyse(char ch)
        {
            if (char.IsUpper(ch))
                return $"{ch} - заглавная буква";
            else if (char.IsLower(ch))
                return $"{ch} - строчная буква";
            else if(char.IsDigit(ch))
                return $"{ch} - цифра";
            else if(char.IsWhiteSpace(ch))
                return $"{ch} - пробел";
            else if (char.IsPunctuation(ch))
                return $"{ch} - знак пунктуации";
            else
                return $"{ch} - специальный символ";
        }
    }
}
