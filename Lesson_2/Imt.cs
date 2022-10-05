using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lesson_2
{
    internal class Imt
    {
        public static object NumberDecimalalSeparator { get; private set; }

        public static void Task5()
        {
            Console.Write("Введите ваш рост в метрах: ");
            String InputHeight = Console.ReadLine();

            NumberFormatInfo NumberFormatInfo = new NumberFormatInfo();
            {
                NumberDecimalalSeparator = ".";
            }

            Console.Write("Введите ваш вес килограммах: ");
            String InputWeight = Console.ReadLine();

            double double_height = double.Parse(InputHeight, NumberFormatInfo);
            double double_weight = double.Parse(InputWeight, NumberFormatInfo);

            double H = double_height * double_height;
            double BodyMassIndex = double_weight / H;

            Console.WriteLine("Ваш индекс массы тела составляет: {0:0.00}", BodyMassIndex);


  //          double BodyMassIndex = double_weight / Math.Pow((double_height / 100), 2);
            double NormalWeightDown = Math.Round(18 * Math.Pow((double_height / 100), 2), 1);
            double NormalWeightUp = Math.Round(25 * Math.Pow((double_height / 100), 2), 1);
            double NormalWeigh;

            Console.WriteLine($"\nВаш индекс массы тела равен {Math.Round(BodyMassIndex, 1)}.\n");

            if (BodyMassIndex < 16)
            {
                Console.WriteLine("У вас выраженный дефицит массы.");
                NormalWeigh = NormalWeightDown - double_weight;
                Console.WriteLine($"Вам нужно поправиться на {NormalWeigh} килограмм.");
            }
            else if (BodyMassIndex >= 16 && BodyMassIndex < 18)
            {
                Console.WriteLine("У вас недостаточная масса тела.");
                NormalWeigh = NormalWeightDown - double_weight;
                Console.WriteLine($"Вам нужно поправиться на {NormalWeigh} килограмм.");
            }
            else if (BodyMassIndex >= 18 && BodyMassIndex < 25)
            {
                Console.WriteLine("У вас нормальный вес.");
            }
            else if (BodyMassIndex >= 25 && BodyMassIndex < 30)
            {
                Console.WriteLine("У вас избыточная масса тела.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
            }
            else if (BodyMassIndex >= 30 && BodyMassIndex < 35)
            {
                Console.WriteLine("У вас ожирение 1 степени.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
            }
            else if (BodyMassIndex >= 35 && BodyMassIndex < 40)
            {
                Console.WriteLine("У вас ожирение 2 степени.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");
            }
            else if (BodyMassIndex >= 40)
            {
                Console.WriteLine("У вас ожирение 3 степени.");
                NormalWeigh = double_weight - NormalWeightUp;
                Console.WriteLine($"Вам нужно похудеть на {NormalWeigh} килограмм.");


                Console.WriteLine();
            }
        }

    }
}
