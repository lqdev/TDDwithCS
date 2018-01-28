namespace HandMocking.Stubs
{
    internal class DependentClass
    {
        private readonly IDependency _dependency;

        public DependentClass(IDependency dependency)
        {
            _dependency = dependency;
        }

        public int GetValue(string s)
        {
            return _dependency.GetValue(s);
        }
    }
}