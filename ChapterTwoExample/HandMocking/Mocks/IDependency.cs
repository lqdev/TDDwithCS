namespace HandMocking.Mocks
{
    internal interface IDependency
    {
        int GetValue(string s);
        void CallMeFirst();
        int CallMeTwice(string s);
        void CallMeLast();
    }
}