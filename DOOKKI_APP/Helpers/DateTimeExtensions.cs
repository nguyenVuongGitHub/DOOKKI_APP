using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime date, DayOfWeek startDayOfWeek)
        {
            int diff = (7 + (date.DayOfWeek - startDayOfWeek)) % 7;
            return date.AddDays(-1 * diff).Date;
        }
    }
}
