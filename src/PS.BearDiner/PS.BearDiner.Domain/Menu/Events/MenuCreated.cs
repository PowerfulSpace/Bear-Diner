using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Menu.Events
{
    public record MenuCreated(Menu menu) : IDomainEvent;
}
