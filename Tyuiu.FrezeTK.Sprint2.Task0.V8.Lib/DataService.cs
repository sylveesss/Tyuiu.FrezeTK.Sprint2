using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint2.Task0.V8.Lib
{
    public class DataService
    {
        public static bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 66 == y; // == -> True
            res[1] = x + 66 != y; // != -> False
            res[2] = x < y;       // <  -> True
            res[3] = x > y;       // >  -> False
            res[4] = x <= y;      // <= -> True
            res[5] = x >= y;      // >= -> False

            return res;
        }
    }
}
