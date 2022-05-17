using System;

namespace TestDrivenTalk.Example4.Stubs
{
    internal class CalendarStub : ICalendar
    {
        private readonly DateTime? _dateTimeNow;

        public CalendarStub(DateTime? dateTimeNow = null)
        {
            _dateTimeNow = dateTimeNow;
        }

        public DateTime GetDateTimeNow()
        {
            return _dateTimeNow.Value;
        }
    }
}
