using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Floors;

namespace Floors.Tests
{
    public class RightFloorTests
    {
        [Fact]
        public void TestRightFloor()
        {
            // Arrange
            var sut = new RightFloor();
            var expected = 2;
            // Act
            var actual = sut.GetFloorNumber("(()(");
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("(()(())((()))(", 2)]
        [InlineData("()(((((())))))))(((()", 1)]
        [InlineData("((())))", -1)]
        public void TestRightFloorWithDifferentInputs(string input, int expected)
        {
            // Arrange
            var sut = new RightFloor();
            // Act
            var actual = sut.GetFloorNumber(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
