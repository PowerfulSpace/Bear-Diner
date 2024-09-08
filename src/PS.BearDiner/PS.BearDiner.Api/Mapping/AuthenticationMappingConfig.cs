using Mapster;
using PS.BearDiner.Application.Authentication.Common;
using PS.BearDiner.Contracts.Authentication;

namespace PS.BearDiner.Api.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                .Map(dest => dest.Token, src => src.Token)
                .Map(dest => dest, src => src.User);
        }
    }
}
