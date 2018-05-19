using System;
using Xunit;
using Test.Third;

namespace Test.UnitTests.Third
{
    public class ThirdTests
    {
        private Duplicates duplicates;

        public ThirdTests()
        {
            duplicates = new Duplicates();
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new int[] { 1, 2, 3, 1, 4, 5, 6, 7, 8 })]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5, 6, 7, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 4, 7, 8 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 4, 8, 8 })]
        public void ShouldHaveDuplicates(int[] arr)
        {
            var result = duplicates.HasDuplicates(arr);

            Assert.True(result);
        }

        [Fact]
        public void ShouldNotHaveDuplicates()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = duplicates.HasDuplicates(arr);

            Assert.False(result);
        }
    }
}
