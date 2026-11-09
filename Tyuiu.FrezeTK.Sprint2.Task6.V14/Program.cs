using System;
using Tyuiu.FrezeTK.Sprint2.Task6.V14.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма switch                                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить, каким днем недели является k-й день не високосного года,    *");
            Console.WriteLine("* в котором 1 января - d-й день недели.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите d (день недели 1 января, 1-7): ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите k (день года, 1-365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (d < 1 || d > 7 || k < 1 || k > 365)
            {
                Console.WriteLine("Ошибка! Некорректные исходные данные.");
            }
            else
            {
                string res = DataService.FindDayOfWeek(d, k);
                Console.WriteLine("Этот день недели: " + res);
            }

            Console.ReadKey();
        }
    }
}
