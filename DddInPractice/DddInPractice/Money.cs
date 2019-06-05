
namespace DddInPractice
{
    public sealed class Money : ValueObject<Money>
    {
        public int OneCentCount { get; set; }
        public int TenCentCount { get; set; }
        public int QuartersCount { get; set; }
        public int OneDollarCount { get; set; }
        public int FiveDollarsCount { get; set; }
        public int TwentyDollarsCount { get; set; }

        public Money(
            int oneCentCount,
            int tenCentCount,
            int quartersCount,
            int oneDollarCount,
            int fiveDollarsCount,
            int twentyDollarsCount)
        {
            OneCentCount = oneCentCount;
            TenCentCount = tenCentCount;
            QuartersCount = quartersCount;
            OneDollarCount = oneDollarCount;
            FiveDollarsCount = fiveDollarsCount;
            TwentyDollarsCount = twentyDollarsCount;
        }

        public static Money operator +(Money money1, Money money2)
        {
            var sum = new Money(
                money1.OneCentCount + money2.OneCentCount,
                money1.TenCentCount + money2.TenCentCount,
                money1.QuartersCount + money2.QuartersCount,
                money1.OneDollarCount + money2.OneDollarCount,
                money1.FiveDollarsCount + money2.FiveDollarsCount,
                money1.TwentyDollarsCount + money2.TwentyDollarsCount);

            return sum;
        }

        protected override bool EqualsCore(Money other)
        {
            return OneCentCount == other.OneCentCount
                   && TenCentCount == other.TenCentCount
                   && QuartersCount == other.QuartersCount
                   && OneDollarCount == other.OneDollarCount
                   && FiveDollarsCount == other.FiveDollarsCount
                   && TwentyDollarsCount == other.TwentyDollarsCount;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                var hashCode = OneCentCount;
                hashCode = (hashCode * 397) ^ TenCentCount;
                hashCode = (hashCode * 397) ^ QuartersCount;
                hashCode = (hashCode * 397) ^ OneDollarCount;
                hashCode = (hashCode * 397) ^ FiveDollarsCount;
                hashCode = (hashCode * 397) ^ TwentyDollarsCount;

                return hashCode;
            }
        }
    }
}
