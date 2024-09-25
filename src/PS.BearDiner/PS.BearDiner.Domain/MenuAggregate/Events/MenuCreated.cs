using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.MenuAggregate.Events
{
    public record MenuCreated(Menu menu) : IDomainEvent;
}
