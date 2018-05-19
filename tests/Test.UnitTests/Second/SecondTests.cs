using System;
using Xunit;
using Test.Second;

namespace Test.UnitTests.Second
{
    public class SecondTests
    {
        private LargestTwo largestTwo;

        public SecondTests()
        {
            largestTwo = new LargestTwo();
        }

        [Fact]
        public void ShouldThrowArgumentException()
        {
            var arr = new int[1];
            Action action = () => largestTwo.Largest(arr);

            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 8, 7 })]
        [InlineData(new int[] { 5, 1, 8, 20, 6, 13, 2, 9 }, new int[] { 20, 13 })]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, new int[] { -1, -2 })]
        [InlineData(new int[] { -1, 0, -2, -3, -4, -5, -6, -7 }, new int[] { 0, -1 })]
        public void ShouldFindLargestTwoValues(int[] arr, int[] expected)
        {
            var result = largestTwo.Largest(arr);

            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }
    }
}
