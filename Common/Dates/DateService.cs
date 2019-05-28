using System;

namespace CleanArchitecture.Common.Dates
{
    public class DateService : IDateService
    {
        public DateTime GetDate()
        {
            return DateTime.Now.Date;
        }

        public DateTime GetNow()
        {
            return DateTime.Now;
        }

        public DateTime GetUtcNow()
        {
            return DateTime.UtcNow;
        }
    }
}