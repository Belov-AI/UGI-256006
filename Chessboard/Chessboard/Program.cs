using System;


namespace Chessboard
{
    class Program
    {
        static void Main()
        {
            int boardSize;

            //Здесь ввод размера доски.
            //оформите его в виде бесконечного цикла с проверкой,
            //что 1<= boardSize <= 26
            //и предложением повторного ввода, если условие не выполняется
            //Предусмотрите отказ от ввода (с последующим завершением программы).

            while (true)
            {
                Console.WriteLine("Введите размер доски от 1 до 26. Enter - отказ от ввода");
                
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;
                else
                {
                    boardSize = int.Parse(input);

                    if (boardSize < 1 || boardSize > 26)
                    {
                        Console.WriteLine("Неверный размер.");
                        continue;
                    }
                    else break;
                }
            }
            
            PrintBoard(boardSize);           
        }

         

        static void PrintBoard(int size)
        {
            //написать метод печати шахматной доски размера (size x size)

            var lightColor = ConsoleColor.White;
            var darkColor = ConsoleColor.DarkBlue;

            for(int i = 0; i < size; i++)
            {
                ConsoleColor color;

                if (i % 2 == 0)
                    color = lightColor;
                else
                    color = darkColor;

                for (int j = 0; j < size; j++)
                {
                    PrintSquare(color);

                    if (color == lightColor)
                        color = darkColor;
                    else
                        color = lightColor;
;                }

                Console.WriteLine();
            }

        }

        /// <summary>
        /// Печать квадрата нужного цвета
        /// </summary>
        /// <param name="color">Цвет квадрата</param>
        static void PrintSquare(ConsoleColor color)
        {
            const char square = (char)0x2588;

            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ForegroundColor = defaultColor;
        }
    }
}
