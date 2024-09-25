using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Menus.Events
{
    public record MenuCreated(Menu menu) : IDomainEvent;
}
