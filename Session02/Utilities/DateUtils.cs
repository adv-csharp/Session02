using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Utilities
{
    public static class DateUtils
    {
        public static string MiladiToJalali(DateTime date) {
            var pc = new PersianCalendar(); // System.Globalization

            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            //String Concat
            var result = year + "/" + month + "/" + day;


            result = String.Format("{0}/{1}/{2}", year, month, day);
            //String interpolation
            result = $"{year}/{month}/{day}";
            //result = $"{pc.GetYear(date)}/{ pc.GetMonth(date)}/{day}";


            //String Builder
            var sb = new StringBuilder();
            sb.Append(year);
            sb.Append("/");
            sb.Append(month);
            sb.Append("/");
            sb.Append(day);
            result = sb.ToString();

            return result;
        }

        public static string GetJalaliMonthName(DateTime date)
        {
            string[] monthNames =
            {
                "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
            };
            var pc = new PersianCalendar(); // System.Globalization
            var month = pc.GetMonth(date);

            //if (month == 1)
            //    return "فروردین";


            return monthNames[month - 1];
        }


        public static string GetJalaliMonthNamePattrenMatching(DateTime date)
        {
            var pc = new PersianCalendar(); // System.Globalization
            var month = pc.GetMonth(date);

            return month switch
            {
                1 => "فروردین",
                2 => "اردیبهشت",
                3 => "خرداد",
                4 => "تیر",
                5 => "مرداد",
                6 => "شهریور",
                7 => "مهر",
                8 => "آبان",
                9 => "آذر",
                10 => "دی",
                11 => "بهمن",
                12 => "اسفند",
                _ => "nadarim", // default case
            };
        }

        public static string GetJalaliSeasong(DateTime date)
        {
            return "بهار";
        }
    }
}
