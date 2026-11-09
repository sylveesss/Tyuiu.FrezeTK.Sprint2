using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FrezeTK.Sprint2.Task5.V8.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным n (число) и m (номер месяца) определить дату                *");
            Console.WriteLine("* предыдущего дня с использованием оператора switch.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите порядковый номер месяца m (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число n (1-31): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (m == 1 && n == 1)
            {
                Console.WriteLine("По условию задачи дата не должна характеризовать 1 января.");
            }
            else if (m < 1 || m > 12 || n < 1 || n > 31)
            {
                Console.WriteLine("Ошибка! Введены некорректные значения даты.");
            }
            else
            {
                string previousDate = DataService.FindPreviousDate(m, n);
                Console.WriteLine("Дата предыдущего дня: " + previousDate);
            }

            Console.ReadKey();
        }
    }
}
