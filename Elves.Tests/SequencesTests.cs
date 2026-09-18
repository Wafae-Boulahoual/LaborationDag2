using System;
using System.Collections.Generic;
using System.Text;

namespace Elves.Tests
{

    // 1113222113
    public class SequencesTest
    {
        [Fact]
        public void CountSameNumbers_ShouldReturnNumberOfsameChifre()
        {
            // Arrange
            var sut = new Sequences();
           // var expected = "3113322113";

            //act
            var actual = sut.CountSameChifres(new int[] { 1, 1, 1, 3, 2, 2, 2, 1, 1, 3 });
            //assert
            Assert.Equal("3113322113", actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1, 1, 1, 1 }, "11121341")]
        [InlineData(new int[] { 1, 2, 0, 0, 0, 0, 0, 2 }, "11125012")]
        [InlineData(new int[] { 2, 2, 2, 2, 2, 2 }, "62")]
        public void CountCorrectNumber(int[] number, string expected)
        {
            // arrange
            var sut = new Sequences();

            //act
            var actual = sut.CountSameChifres(number);
            //act & assert
            Assert.Equal(expected, actual);
        }

    }
}