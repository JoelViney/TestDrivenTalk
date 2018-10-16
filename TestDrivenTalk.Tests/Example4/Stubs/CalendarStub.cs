using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenTalk.Example4.Stubs
{
    internal class CalendarStub : ICalendar
    {
        private DateTime? _dateTimeNow;

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
