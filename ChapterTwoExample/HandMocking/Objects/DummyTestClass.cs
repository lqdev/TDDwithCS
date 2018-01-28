using NUnit.Framework;

namespace HandMocking.Objects
{
    [TestFixture]
    public class DummyTestClass
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWithADummy()
        {
            var dependency = new DummyDependency();
            var dependentClass = new DependentClass(dependency);
            const string param = "abc";
            const int expectedResultOne = 1;

            var resultOne = dependentClass.GetValue(param);
            Assert.AreEqual(expectedResultOne,resultOne);
        }
    }
}