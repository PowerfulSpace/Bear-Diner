using Mapster;
using PS.BearDiner.Application.Authentication.Commands.Register;
using PS.BearDiner.Application.Authentication.Common;
using PS.BearDiner.Application.Authentication.Queries.Login;
using PS.BearDiner.Contracts.Authentication;

namespace PS.BearDiner.Api.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterRequest, RegisterCommand>();
            config.NewConfig<LoginRequest, LoginQuery>();

            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                .Map(dest => dest, src => src.User);
        }
    }
}
