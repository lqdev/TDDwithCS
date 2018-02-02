using System;
using System.Diagnostics;
using NUnit.Framework;
using Moq;

namespace HandMocking.Moq
{
    [TestFixture]
    public class MoqExamples 
    {
        private Mock<ILongRunningLibrary> _longRunningLibrary;

        [SetUp]
        public void SetupForTest()
        {
            //_longRunningLibrary = new LongRunningLibrary();
            _longRunningLibrary = new Mock<ILongRunningLibrary>();

            _longRunningLibrary
                .Setup(lrl => lrl.RunForALongTime(It.IsAny<int>()))
                .Returns((int s) => 
                    string.Format("This method has been mocked! The input value was {0}",s)
                );

            _longRunningLibrary
                .Setup(lrl => lrl.RunForALongTime(0))
                .Throws(new ArgumentException("0 is not a valid interval"));                
        }

        [TestCase(30)]
        [TestCase(100)]
        [TestCase(1)]
        public void TestLongRunningLibrary(int interval)
        {
            var result = _longRunningLibrary.Object.RunForALongTime(interval);
            Debug.WriteLine("Return from method was '{0}'",result);
        }
    }
}