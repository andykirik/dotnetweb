using System;
using Xunit;
using Main;

namespace UnitTest
{
    public class UnitTest1
    {
        private readonly Startup _Startup;

        public UnitTest1()
        {
            _Startup = new Startup();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        public void ReturnTrueGivenEvenLessThan10(int value)
        {
            var result = _Startup.IsEven(value);

            Assert.True(result, $"{value} should be even");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(9)]
        public void ReturnFalseGivenOddLessThan10(int value)
        {
            var result = _Startup.IsEven(value);

            Assert.False(result, $"{value} should not be even");
        }

        [Fact]
        public void Test1()
        {
	    Assert.True(1==1, $"1=1");
        }
    }
}
