using System;
using TestInterface;

namespace TestClass
{
    public class TestClass : 숨김인터페이스
    {
        public string HideProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string HideMethod()
        {
            throw new NotImplementedException();
        }
    }
}
