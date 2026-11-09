using System;

namespace Tyuiu.FrezeTK.Sprint2.Task6.V14.Lib
{
    public class DataService
    {
        public static string FindDayOfWeek(int d, int k)
        {
            int dayIndex = (k + d - 2) % 7 + 1;

            return dayIndex switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
