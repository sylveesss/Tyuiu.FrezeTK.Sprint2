using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FrezeTK.Sprint2.Task2.V21.Lib;

namespace Tyuiu.FrezeTK.Sprint2.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операторы ветвления                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X, Y в заштрихованной     *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X (от 1 до 15): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y (от 1 до 15): ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool isInArea = DataService.CheckDotInShadedArea(x, y);

            if (isInArea)
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НАХОДИТСЯ в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}
