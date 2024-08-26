namespace PS.BearDiner.Contracts.Authentication
{
    public record LoginRequest(
        string Email,
        string Password
        );
}
