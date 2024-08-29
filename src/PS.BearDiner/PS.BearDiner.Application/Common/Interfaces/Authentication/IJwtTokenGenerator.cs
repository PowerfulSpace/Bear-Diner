namespace PS.BearDiner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid id, string firstName, string lastName);
    }
}
