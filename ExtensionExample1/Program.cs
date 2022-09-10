using System;

namespace ExtensionExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToRocDateString_A(DateTime.Now, '_'));

            Console.WriteLine(DateTime.Now.ToRocDateString_B('-'));

            Console.ReadKey();
        }

        static string ToRocDateString_A(DateTime date, char separator)
        {
            int year = (date.Year - 1911);
            return year.ToString() + separator + date.Month + separator + date.Day;
        }
    }

    public static class DateTimeExt
    {
        // 將 DateTime 物件格式化成中華民國年份的日期字串.
        public static string ToRocDateString_B(this DateTime date, char separator)
        {
            int year = (date.Year - 1911);
            return year.ToString() + separator + date.Month + separator + date.Day;
        }
    }
}
