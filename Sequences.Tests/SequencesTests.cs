using System;
using System.Collections.Generic;
using System.Text;

namespace Elves.Tests
{
    // 1113222113
    public class SequencesTest
    {
        [Fact]
        public void Step_ShouldReturnNumberOfSameChifre()
        {
            // Arrange
            var sut = new Sequences();
            var expected = "3113322113";

            // Act
            var actual = sut.Step(new int[] { 1, 1, 1, 3, 2, 2, 2, 1, 1, 3 });

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1, 1, 1, 1 }, "11121341")]
        [InlineData(new int[] { 1, 2, 0, 0, 0, 0, 0, 2 }, "11125012")]
        [InlineData(new int[] { 2, 2, 2, 2, 2, 2 }, "62")]
        public void Step_CountCorrectNumber(int[] number, string expected)
        {
            // Arrange
            var sut = new Sequences();

            // Act
            var actual = sut.Step(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}