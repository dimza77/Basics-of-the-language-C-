using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class GoodNumber
    {
        public static void Task6()
        {
            Console.Clear();
            Console.WriteLine("Внимание! На подсчет в диапозоне от 1 до 1000000000 в среднем уходит 30 минут");
            Console.WriteLine("\nНажмите Enter чтобы вернуться в меню или иную клавишу для продолжения");
            if (Console.ReadKey().Key == ConsoleKey.Enter) goto End;


            var DateBefore = DateTime.Now;
            int count = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                int number = i;
                int sumNumbers = 0;
                while (number > 0)
                {
                    var digit = number % 10;
                    number /= 10;
                    sumNumbers = sumNumbers + digit;
                }
                if (i % sumNumbers == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }

            }
            Console.WriteLine($"\nВсего в заданном диапазоне {count} 'хороших' чисел");

            TimeSpan timeSpan = DateTime.Now - DateBefore;

            Console.WriteLine($"\nНа подсчет 'хороших' чисел затрачено {timeSpan} времени");
        End:;


        }
    }
}
