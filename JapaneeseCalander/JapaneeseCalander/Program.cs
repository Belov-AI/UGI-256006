using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneeseCalander
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год н. э.");
            var year = int.Parse(Console.ReadLine());

            var message = $"{year} - год {GetColor(year)}{GetAnimal(year)}";
            Console.WriteLine(message);
        }

        static string GetColor(int year)
        {
            int yearInCycle = GetYearNumberInCycle(year);

            var colorNumber = yearInCycle / 12;

            switch (colorNumber)
            {
                case 0:
                    return "зелен";
                case 1:
                    return "красн";
                case 2:
                    return "желт";
                case 3:
                    return "бел";
                default:
                    return "черн";
            }
        }

        static string GetAnimal(int year)
        {
            var yearInCycle = GetYearNumberInCycle(year);

            var animalNumber = yearInCycle % 12;

            if (animalNumber == 0)
                return "ой крысы";
            else if (animalNumber == 1)
                return "ой коровы";
            else if (animalNumber == 2)
                return "ого тигра";
            else if (animalNumber == 3)
                return "ого кролика";
            else if (animalNumber == 4)
                return "ого дракона";
            else if (animalNumber == 5)
                return "ой змеи";
            else if (animalNumber == 6)
                return "ой лошади";
            else if (animalNumber == 7)
                return "ой овцы";
            else if (animalNumber == 8)
                return "ой обезьяны";
            else if (animalNumber == 9)
                return "ого петуха";
            else if (animalNumber == 10)
                return "ой собаки";
            else
                return "ой свиньи";
        }

        private static int GetYearNumberInCycle(int year)
        {
            var yearInCycle = (year - 1984) % 60;

            if (yearInCycle < 0) yearInCycle += 60;
            
            return yearInCycle;
        }

        
    }
}
