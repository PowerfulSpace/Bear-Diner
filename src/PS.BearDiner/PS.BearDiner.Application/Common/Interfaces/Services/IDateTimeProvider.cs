namespace PS.BearDiner.Application.Common.Interfaces.Services
{
    public interface IDateTimeProvider
    {
        DateTime utcNow { get; }
    }
}