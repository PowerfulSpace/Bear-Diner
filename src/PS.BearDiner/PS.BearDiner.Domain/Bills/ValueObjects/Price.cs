﻿using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Bills.ValueObjects
{
    public sealed class Price : ValueObject
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        private Price(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Price Create(decimal amount, string currency)
        {
            return new Price(amount, currency);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
