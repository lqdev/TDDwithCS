namespace HandMocking.Mocks
{
    internal class DependentClass
    {
        private readonly IDependency _dependency;

        public DependentClass(IDependency dependency)
        {
            _dependency = dependency;
        }

        public void CallMeFirst()
        {
            _dependency.CallMeFirst();
        }

        public int CallMeTwice(string s)
        {
            return _dependency.CallMeTwice(s);
        }

        public void CallMeLast()
        {
            _dependency.CallMeLast();
        }
    }
}