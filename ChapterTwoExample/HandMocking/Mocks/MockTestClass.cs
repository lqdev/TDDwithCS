using NUnit.Framework;

namespace HandMocking.Mocks
{
    [TestFixture]
    public class MockTestClass
    {
        [Test]
        public void TestWithAMock()
        {
            var dependency = new MockDependency();
            var dependentClass = new DependentClass(dependency);

            const string param1 = "abc";
            const string param2 = "xyz";

            var expectedResultOne = 1;
            var expectedResultTwo = 2;

            dependentClass.CallMeFirst();
            var resultOne = dependentClass.CallMeTwice(param1);
            var resultTwo = dependentClass.CallMeTwice(param2);
            dependentClass.CallMeLast();

            Assert.AreEqual(expectedResultOne,resultOne);
            Assert.AreEqual(expectedResultTwo,resultTwo);
        }
    }
    
}