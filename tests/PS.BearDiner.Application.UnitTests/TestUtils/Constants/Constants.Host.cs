using PS.BearDiner.Domain.Hosts.ValueObjects;

namespace PS.BearDiner.Application.UnitTests.TestUtils.Constants
{
    public static partial class Constants
    {
        public static class Host
        {
            public static readonly HostId Id = HostId.Create(Guid.Parse("856A4CE2-F0C6-4DE9-A5FC-0546E33E33A2"));
        }
    }
}
