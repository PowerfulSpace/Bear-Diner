using Mapster;
using PS.BearDiner.Application.Menus.Commands.CreateMenu;
using PS.BearDiner.Contracts.Menus;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Api.Mapping
{
    public class MenuMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<(CreateMenuRequest Request, string HostId), CreateMenuCommand>()
                .Map(dest => dest.HistId, src => src.HostId)
                .Map(dest => dest, src => src.Request);

            config.NewConfig<Menu, MenuResponse>();
        }
    }
}
