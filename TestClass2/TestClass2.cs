using TestInterface;

namespace TestClass2
{
    public class TestClass2 : 숨김인터페이스
    {
        string 숨김인터페이스.HideProperty { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        string 숨김인터페이스.HideMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}
