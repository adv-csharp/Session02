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

        public static string GetJalaliSeasonName(DateTime date)
        {
            var pc = new PersianCalendar(); // System.Globalization
            var month = pc.GetMonth(date);

            //switch (month)
            //{
            //    case 1:
            //    case 2:
            //    case 3: return "بهار";
            //}

            //return month switch
            //{
            //    1 => "بهار",
            //    2 => "بهار",
            //    3 => "بهار",
            //    4 => "تابستان",
            //    5 => "تابستان",
            //    6 => "تابستان",
            //    7 => "پاییز",
            //    8 => "پاییز",
            //    9 => "پاییز",
            //    10 => "زمستان",
            //    11 => "زمستان",
            //    12 => "زمستان",
            //    _ => "nadarim", // default case
            //};

            return month switch
            {
                var m when m <= 3 => "بهار",
                var m when m <= 6 => "تابستان",
                var m when m <= 9 => "پاییز",
                var m when m <= 12 => "زمستان",
                _ => "nadarim", // default case
            };
        }


        public static DateTime JalaliToMiladi(string jalaiDate)
        {
            //1401/3/2
            var parts = jalaiDate.Split("/");
            var year = Convert.ToInt32(parts[0]);
            var month = Convert.ToInt32(parts[1]);
            var day = Convert.ToInt32(parts[2]);

            return new DateTime(year, month, day, new PersianCalendar());
        }
    }
}
