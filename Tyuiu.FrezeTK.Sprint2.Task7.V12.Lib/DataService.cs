
using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FrezeTK.Sprint2.Task7.V12.Lib
{
    public class DataService: ISprint2Task7V12
    {
        public static bool CheckDotInShadedArea(double x, double y)
        { 
            if (x >= 0 && y >= 0 && y <= x * x && y <= 2 - x)
            {
                return true;
            }
            return false;
        }
    }
}


