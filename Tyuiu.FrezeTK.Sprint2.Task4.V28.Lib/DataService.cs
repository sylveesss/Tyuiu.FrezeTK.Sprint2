using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint2.Task4.V28.Lib
{
    public class DataService
    {
        public static double Calculate(double x, double y)
        {
            // Вычисление с использованием тернарного оператора
            double z = (x < y * 2 - 10)
                ? Math.Pow(1 + (y + 2) / Math.Pow(x, 2), x)
                : (2 * Math.Pow(x, 2) - Math.Pow(Math.Cos(y), 2) + 12) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) + 9);

            return Math.Round(z, 3);
        }
    }
}
