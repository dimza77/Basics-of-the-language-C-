using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    public class SumNumber
    {
        public static void Task3()
        {
            int sum = 0;
            int num = 0;

            do
            {
                Console.WriteLine("Введите целое число");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Сумма нечетных чисел составляет: " + sum);
            Console.ReadKey();


        }
    }
}
