using System;
//using Xunit;
using NUnit.Framework;
using ChapterOneExamples.Utilities;

namespace ChapterOne.UnitTests
{
    [TestFixture]
    public class UtilitiesTests
    {
        
        [Test]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldBeCaseSensitive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.AreEqual(expectedResult, actualResult);            
        }

        [Test]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurrences(stringToCheck,stringToFind);

            Assert.AreEqual(expectedResult, actualResult);            
        }
        
        [TestCase("mysterious","y",1)]
        [TestCase("mysterious","s",2)]
        [TestCase("mySterious","s",2)]
        [TestCase(null,"y",-1)]
        public void runAllTests(string stringToCheck, string stringToFind, int expectedResult)
        {
            var actualResult = new StringUtilities().CountOccurrences(stringToCheck,stringToFind);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
