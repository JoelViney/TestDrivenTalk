using System;

namespace TestDrivenTalk.Example4
{
    public interface ICalendar
    {
        DateTime GetDateTimeNow();
    }

    public class Calendar : ICalendar
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}
