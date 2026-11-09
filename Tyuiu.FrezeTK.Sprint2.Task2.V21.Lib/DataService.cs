using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FrezeTK.Sprint2.Task2.V21.Lib
{
    public class DataService: ISprint2Task2V21
    {
        public static bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (y == 3 || y == 4)
            {
                if (x == 3 || (x >= 9 && x <= 12)) res = true;
            }
            else if (y == 5)
            {
                if (x == 3 || (x >= 6 && x <= 12)) res = true;
            }
            else if (y == 6 || y == 7)
            {
                if (x >= 3 && x <= 13) res = true;
            }
            else if (y == 8)
            {
                if (x >= 6 && x <= 13) res = true;
            }
            else if (y == 9 || y == 10)
            {
                if ((x >= 3 && x <= 5) || (x >= 9 && x <= 12)) res = true;
            }
            else if (y == 11)
            {
                if (x >= 9 && x <= 12) res = true;
            }
            else if (y == 12)
            {
                if (x == 9 || x == 10) res = true;
            }

            return res;
        }
    }
}
