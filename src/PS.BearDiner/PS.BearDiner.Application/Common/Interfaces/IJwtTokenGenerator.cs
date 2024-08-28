namespace PS.BearDiner.Application.Common.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid id, string firstName, string lastName);
    }
}
