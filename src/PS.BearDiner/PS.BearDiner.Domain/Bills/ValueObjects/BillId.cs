﻿using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Bills.ValueObjects
{
    public sealed class BillId : AggregateRootId<Guid>
    {
        public override Guid Value { get; protected set; }

        private BillId(Guid value)
        {
            Value = value;
        }

        public static BillId Create(Guid value)
        {
            return new BillId(value);
        }

        public static BillId CreateUnique()
        {
            return new BillId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
