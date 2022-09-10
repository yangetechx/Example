using System;

namespace ExtensionExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8.11;

            byte[] bytearray = a.ToConverInt32().ToString().PadLeft(5, '0').ToEncodingDefaultByte();

            Console.ReadKey();
        }

        static string ToRocDateString_A(DateTime date, char separator)
        {
            int year = (date.Year - 1911);
            return year.ToString() + separator + date.Month + separator + date.Day;
        }
    }

    public static class Covert
    {
        public static byte[] ToEncodingDefaultByte(this string str)
        {
            return System.Text.Encoding.Default.GetBytes(str);
        }

        public static int ToConverInt32(this double a)
        {
            return Convert.ToInt32(a);
        }

        public static int ToConverInt32(this decimal a)
        {
            return Convert.ToInt32(a);
        }
    }
}
