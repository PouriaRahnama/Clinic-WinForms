using System.Globalization;

namespace Epsilon.Core.Extensions
{
    public static class PersianDateExtension
    {
        public static string ToPersianDate(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(date).ToString() + "/" + pc.GetMonth(date).ToString() + "/" +
                   pc.GetDayOfMonth(date).ToString();
        }
    }
}
