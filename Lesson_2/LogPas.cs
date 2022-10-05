using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class LogPas
    {
        public static void Task4()
        {
           // bool access;
            int counter = 0;

            do
            {
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();
                counter++;
                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Доступ разрешен.\nДобро пожаловать!\n");
             //       access = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\nПара логин/пароль не верны.");

                    if (counter < 3)
                    {
                        if (3 - counter == 2) Console.WriteLine($"У вас осталось {3 - counter} попытки");
                        if (3 - counter == 1) Console.WriteLine($"У вас осталось {3 - counter} попытка");
                        Console.WriteLine("Повторите попытку.\n");
                    }
                    else
                    {
              //          access = false;
                        Console.WriteLine("Вы превысили количество попыток.\nДоступ запрещен!!!\n");
                    }
                }

            }
            while (counter != 3);

        }


    }
}
