using System;
using TestInterface;

namespace TestClass4
{
    public class TestClass4 : 숨김인터페이스
    {
        private string HideProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string HideMethod()
        {
            throw new NotImplementedException();
        }
    }
}
