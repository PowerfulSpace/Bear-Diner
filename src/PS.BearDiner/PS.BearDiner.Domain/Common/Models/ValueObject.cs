namespace PS.BearDiner.Domain.Common.Models
{
    public abstract class ValueObject
    {
        public abstract IEnumerable<object> GetEqualityComponents();
    }
}
