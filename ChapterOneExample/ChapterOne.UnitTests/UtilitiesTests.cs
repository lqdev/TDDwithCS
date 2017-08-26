using System;
using Xunit;
using ChapterOneExamples.Utilities;

namespace ChapterOne.UnitTests
{
    public class UtilitiesTests
    {
        
        [Fact]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldBeCaseSensitive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.Equal(expectedResult, actualResult);            
        }

        [Fact]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.Equal(expectedResult, actualResult);            
        }
        

        [Theory]
        [InlineData("mysterious","y",1)]
        [InlineData("mysterious","s",2)]
        [InlineData("mySterious","s",2)]
        [InlineData(null,"y",-1)]
        public void runAllTests(string stringToCheck, string stringToFind, int expectedResult)
        {
            var actualResult = new StringUtilities().CountOccurrences(stringToCheck,stringToFind);
            Assert.Equal(expectedResult,actualResult);
        }
    }
}
