using System;

namespace TestDrivenTalk.Example4.Stubs
{
    internal class CalendarStub : ICalendar
    {
        private readonly DateTime _dateTimeNow;

        public CalendarStub(DateTime? dateTimeNow = null)
        {
            if (dateTimeNow == null)
                _dateTimeNow = new DateTime();
            else
                _dateTimeNow = dateTimeNow.Value;
        }

        public DateTime GetDateTimeNow()
        {
            return _dateTimeNow;
        }
    }
}
