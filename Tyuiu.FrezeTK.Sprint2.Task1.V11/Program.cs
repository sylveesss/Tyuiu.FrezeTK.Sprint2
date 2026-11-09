using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FrezeTK.Sprint2.Task1.V11.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций          *");
            Console.WriteLine("* (|, &, ||, &&, !, ^), которая вернет логическую последовательность      *");
            Console.WriteLine("* (False, False, True, False, True, False),                               *");
            Console.WriteLine("* при a = 145, b = 156, c = 142, d = 117.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = DataService.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Элемент массива #{i}: " + res[i]);
            }

            Console.ReadKey();
        }
    }
}
