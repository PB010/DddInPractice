using FluentAssertions;
using Xunit;

namespace DddInPractice.Test
{
    public class MoneySpecs
    {
        [Fact]
        public void Sum_of_two_moneys_produce_correct_result()
        {
            //Arrange 
            var money1 = new Money(1,2,3,4,5,6);
            var money2 = new Money(1,2,3,4,5,6);

            //Act 
            var sum = money1 + money2;

            //Assert

            //Assert.Equal(2, sum.OneCentCount); - we will use FluentAssertions instead
            sum.OneCentCount.Should().Be(2);
            sum.TenCentCount.Should().Be(4);
            sum.QuartersCount.Should().Be(6);
            sum.OneDollarCount.Should().Be(8);
            sum.FiveDollarsCount.Should().Be(10);
            sum.TwentyDollarsCount.Should().Be(12);
        }

        [Fact]
        public void Two_money_instances_equal_if_they_contain_the_same_amount()
        {

        }
    }
}
