using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Semi
{
    class Program
    {
        public static object NumberDecimalalSeparator { get; private set; }

        static void Main()
        {
            Console.Title = "Анкета";

            // Задание №1.Анкетирование

            Console.Write("Введите вашу фамилию: ");
            String Family = Console.ReadLine();

            Console.Write("Введите ваше имя: ");
            String Name = Console.ReadLine();

            Console.Write("Введите ваше отчество: ");
            String Patronymic = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            String InputAge = Console.ReadLine();
            int Age = int.Parse(InputAge);

            Console.Write("Введите ваш рост в метрах: ");
            String InputHeight = Console.ReadLine();

            NumberFormatInfo NumberFormatInfo = new NumberFormatInfo();
            {
                NumberDecimalalSeparator = ".";
            }
            double Height = double.Parse(InputHeight, NumberFormatInfo);

            Console.Write("Введите ваш вес килограммах: ");
            String InputWeight = Console.ReadLine();
            double Weight = double.Parse(InputWeight, NumberFormatInfo);

            Console.WriteLine();

            Console.WriteLine(Family + " " + Name + " " + Patronymic + " " + Age + " " + Height + " " + Weight);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", Family, Name, Patronymic, Age, Height, Weight);
            Console.WriteLine();
            Console.WriteLine($"{Family} {Name} {Patronymic} {Age} {Height} {Weight}");

            Console.WriteLine();

            // Задание №2. Рассчет индекса массы тела

            double H = Height * Height;
            double Imt = Weight / H;

            Console.WriteLine("Ваш индекс массы тела составляет: {0:0.00}", Imt);


            Console.ReadLine();

            Console.Clear();


            // Задание №3. Рассчет расстояния между точками

            Console.WriteLine("Введите координаты точек");

            Console.Write("Координата Х1 - ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Координата Y1 - ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("\nКоордината X2 - ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Координата Y2 - ");
            int y2 = int.Parse(Console.ReadLine());

            Console.Clear();

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние - {0:F2}", result);

            Console.ReadKey();

            // Помощь преподавателя!!

            // По задаче 4, это очень важная задача (очень часто ее задают на собеседовании), я вам продемонстрирую решение, обратите внимание
            // на ход решения именно подзадачи б, тут от нас требуется математический подход к решению, представьте себе что эту задачу вы должны решить на листке бумаги:

            Console.Write("Укажите значение переменной a: ");

            int aInput = int.Parse(Console.ReadLine());
            Console.Write("Укажите значение переменной b: ");
            int bInput = int.Parse(Console.ReadLine());

            // Через 3 перменные
            int a = aInput;
            int b = bInput;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"\n(3 переменные) Значение переменной a = {a},  значение переменной b = {b}");

            // Без испрользования 3-ей перменной

            a = aInput;
            b = bInput;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"(2 переменные) Значение переменной a = {a},  значение переменной b = {b}");
        }
        // Последняя подзадача повышенной сложности. Конечно, мы пока не проходили проектирование классов, этим мы займемся на 3 уроке,
        // и тем не менее, я вам продемонстрирую пример простого класса, содержащего вспомогательные статические методы,
        // которые можно вызывать напрямую из любого метода (например main) вашего основного класса:

        /// <summary>
        /// Вспомогательный класс
        /// </summary>
        public class OutputHelpers
        {
            public static void PrintInCenter(string text)
            {
                Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
                Console.WriteLine(text);
            }

            public static void Pause()
            {
                Console.ReadKey();


                // И вызов из метода, например из метода main:

                #region Task5

                Console.Clear();
                OutputHelpers.PrintInCenter($"Иванов Иван Иванович, г. Москва");
                OutputHelpers.Pause();

                #endregion
            }
        }
    }
}



