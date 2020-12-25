using BugTracker.Service.Contract;
using System;

namespace BugTracker.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}