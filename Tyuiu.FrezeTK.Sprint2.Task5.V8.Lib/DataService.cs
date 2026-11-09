using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint2.Task5.V8.Lib
{
    public class DataService
    {
        public static string FindPreviousDate(int m, int n)
        {
            if (n > 1)
            {
                return $"{n - 1:D2}.{m:D2}";
            }

            int prevMonth = m - 1;
            int prevDay = 0;

            switch (prevMonth)
            {
                case 1:  
                case 3:  
                case 5:  
                case 7:  
                case 8:  
                case 10: 
                case 12: 
                    prevDay = 31;
                    break;

                case 4: 
                case 6:  
                case 9:  
                case 11: 
                    prevDay = 30;
                    break;

                case 2: 
                    prevDay = 28;
                    break;

                default:
                    throw new ArgumentException("Неверный номер месяца.");
            }

            return $"{prevDay:D2}.{prevMonth:D2}";
        }
    }
}
