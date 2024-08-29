using PS.BearDiner.Application.Common.Interfaces.Services;

namespace PS.BearDiner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
