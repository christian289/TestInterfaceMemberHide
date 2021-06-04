using System;
using TestInterface;

namespace TestClass3
{
    public class TestClass3 : 숨김인터페이스
    {
        internal string HideProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal string HideMethod()
        {
            throw new NotImplementedException();
        }
    }
}
