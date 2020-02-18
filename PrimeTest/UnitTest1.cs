using System;
using Xunit;
using Lab_4._3_UnitTest;

namespace PrimeTest
{
    public class UnitTest1
    {
        [Fact]
        public void One()
        {
            int result = PrimeSequence.GetPrime(1);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Two()
        {
            int result = PrimeSequence.GetPrime(2);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Three()
        {
            int result = PrimeSequence.GetPrime(3);
            Assert.Equal(5, result);
        }
        [Fact]
        public void Four()
        {
            int result = PrimeSequence.GetPrime(4);
            Assert.Equal(7, result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(8, 19)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        public void All(int a, int expected)
        {
            int result = PrimeSequence.GetPrime(a);
            Assert.Equal(expected, result);
        }
    }
}
