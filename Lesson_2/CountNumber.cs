using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class CountNumber
    {
        public static void Task2()
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);

            Console.ReadKey();

        }
    }
}
