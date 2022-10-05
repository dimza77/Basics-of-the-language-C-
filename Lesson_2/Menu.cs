using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Menu
    {

        static void Main(string[] args)
        {
            Console.Title = "Урок №2. Домашнее задание";
            Wild.Utils.OutputHelpers.PrintInfo(2, "Дмитрий Зайцев");

            bool f = true;

            while (f)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {

                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;

                    case 1:
                        MinNumber.Task1();
                        break;
   
                    case 2:
                        CountNumber.Task2();
                        break;

                    case 3:
                        SumNumber.Task3();
                        break;

                    case 4:
                        LogPas.Task4();
                        break;

                    case 5:
                        Imt.Task5();
                        break;

                    case 6:
                        GoodNumber.Task6();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;





                }
            }
        }
    }
}
