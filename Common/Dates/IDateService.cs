using System;

namespace CleanArchitecture.Common.Dates
{
    public interface IDateService
    {
        DateTime GetDate();
        DateTime GetNow();
        DateTime GetUtcNow();
    }
}