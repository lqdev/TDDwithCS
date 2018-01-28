using NUnit.Framework;

namespace HandMocking.Stubs
{
    [TestFixture]
    public class StubTestClass
    {
        [Test]
        public void TestWithAStub()
        {
            var dependency = new StubDependency();
            var dependentClass = new DependentClass(dependency);

            const string param1 = "abc";
            const string param2 = "xyz";

            var expectedResultOne = 1;
            var expectedResultTwo = 2;

            var resultOne = dependentClass.GetValue(param1);
            var resultTwo = dependentClass.GetValue(param2);

            Assert.AreEqual(expectedResultOne,resultOne);
            Assert.AreEqual(expectedResultTwo,resultTwo);
        }
    }
}