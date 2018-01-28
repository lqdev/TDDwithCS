using NUnit.Framework;

namespace HandMocking.Mocks
{
    public class MockDependency : IDependency
    {
        private int _callMeTwiceCalled;
        private bool _callMeLastCalled;
        private bool _callMeFirstCalled;

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

        public void CallMeFirst()
        {
            if((_callMeTwiceCalled > 0) || _callMeLastCalled)
            {
                throw new AssertionException("CallMeFirst not first method called");
            }
            _callMeFirstCalled = true;
        }

        public int CallMeTwice(string s)
        {
            if(!_callMeFirstCalled)
            {
                throw new AssertionException("CallMeTwice called before CallMeFirst");
            }
            if(_callMeLastCalled)
            {
                throw new AssertionException("CallMeTwice called after CallMeLast");
            }
            if(_callMeTwiceCalled >= 2)
            {
                throw new AssertionException("CallMeTwice called more than twice");
            }
            _callMeTwiceCalled++;
            return GetValue(s);
        }

        public void CallMeLast()
        {
            if(!_callMeFirstCalled)
            {
                throw new AssertionException("CallMeLast called before CallMeFirst");
            }
            if(_callMeTwiceCalled != 2)
            {
                throw new AssertionException(string.Format("CallMeTwice called {0} times",_callMeTwiceCalled));
            }
            _callMeLastCalled = true;
        }
    }
}