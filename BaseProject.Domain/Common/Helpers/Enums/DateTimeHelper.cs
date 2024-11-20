using AAITHelper;
using Humanizer;

namespace BaseProject.Domain.Common.Helpers.Enums
{
    public static class DateTimeHelper
    {
        public static string GetTimeSpan(DateTime dateTime)
        {
            var now = HelperDate.GetCurrentDate();
            var culture = Thread.CurrentThread.CurrentCulture;
            return dateTime.Humanize(true, now, culture);
        }
    }
}
