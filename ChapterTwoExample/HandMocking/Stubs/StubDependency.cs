namespace HandMocking.Stubs
{
    public class StubDependency : IDependency
    {
        public int GetValue(string s)
        {
            if(s == "abc")
            {
                return 1;
            }
            if(s == "xyz")
            {
                return 2;
            }
            return 0;
        }
    }
}