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

           
        }
        
    }   
}


