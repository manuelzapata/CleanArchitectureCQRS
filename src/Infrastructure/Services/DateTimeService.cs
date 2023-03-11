using CleanArchitectureCQRS.Application.Common.Interfaces;

namespace CleanArchitectureCQRS.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
