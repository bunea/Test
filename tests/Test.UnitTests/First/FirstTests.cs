using System;
using Xunit;
using Test.First;

namespace Test.UnitTests.First
{
    public class FirstTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 12)]
        [InlineData(new int[] { 1, 3, 5, 7, 9, 11 }, 0)]
        public void ShouldSumEvens(int[] arr, int expected)
        {
            var sumEvens = new SumEvens();
            var result = sumEvens.Sum(arr);

            Assert.Equal(expected, result);
        }
    }
}
