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
            var pc = new PersianCalendar();
            
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
    }
}
