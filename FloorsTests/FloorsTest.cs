using System;
using System.Collections.Generic;
using System.Text;
namespace Floors.Tests
{
    public class FloorsTests
    {
        [Theory]
        [InlineData("(())", 0)]
        [InlineData("()()", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("))(((((", 3)]
        [InlineData("())", -1)]
        [InlineData("))(", -1)]
        [InlineData(")))", -3)]
        [InlineData(")())())", -3)]
        public void FindFloor_ShouldReturnCorrectFloor(string input, int expected)
        {
            var sut = new FloorsFinder();

            var actual = sut.FindFloor(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        public void FindBasementPosition_ShouldReturnCorrectPosition(string input, int expected)
        {
            var sut = new FloorsFinder();

            var actual = sut.FindBasementPosition(input);

            Assert.Equal(expected, actual);
        }
    }
}
