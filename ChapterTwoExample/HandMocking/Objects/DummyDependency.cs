namespace HandMocking.Objects
{
    public class DummyDependency : IDependency
    {
        public int GetValue(string s)
        {
            return 1;
        }
    }
}