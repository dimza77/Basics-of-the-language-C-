using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class MinNumber
    {
        public static void Task1()
            
        {
            double firstNumber, secondNumber, thirdNumber;

            Console.WriteLine("Введите первое число");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            thirdNumber = double.Parse(Console.ReadLine());

            double minimal = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine("Минимальное число = " + minimal);

            Console.ReadLine();
        }
    }

}
