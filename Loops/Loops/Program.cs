using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество чисел");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            int step = int.Parse(Console.ReadLine());

            Console.WriteLine();
        
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"({numb})^2 = {numb * numb}");
                numb += step;
            }

            Console.WriteLine();

            int sum = 0;
            int counter = 0;

            string input;

            while(sum < 100)
            {
                while (true)
                {
                    Console.WriteLine("Введите положительное целое число. Enter - отказ от вввода");

                    input = Console.ReadLine();

                    if (input == string.Empty)
                        break;

                    int n = int.Parse(input);

                    if(n > 0)
                    {
                        sum += n;
                        counter++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Число не положительное. Попробуйте еще раз");
                        continue;
                    }
                }

                if (input == string.Empty)
                    break;
            }

            Console.WriteLine($"Введено {counter} чисел с общей суммой {sum}");
                


        }
    }
}
