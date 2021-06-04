# TestInterfaceMemberHide
인터페이스의 맴버를 숨기는 방법

인터페이스의 숨김 속성 및 메서드를 확인한다.
솔루션 파일 하나에서 프로젝트를 여러개 링크시키면 프로젝트 참조 시 메타데이터가 아닌 소스코드를 참조하게 되므로, __반드시 프로젝트마다 솔루션파일을 따로 분리한다.__

1. TestInferface로 프로퍼티 1개, 메서드 1개를 정의한다.
2. TestClass프로젝트에 TestInterface DLL(__프로젝트가 아닌 어셈블리__)을 참조하고 TestInterface를 상속한다.
인터페이스에 빨간줄이 뜨면 Alt + Enter 또는 Ctrl + . 을 눌러서 '__인터페이스 구현__' 선택
3. TestClass2프로젝트에 TestInterface DLL(__프로젝트가 아닌 어셈블리__)을 참조하고 TestInterface를 상속한다.
인터페이스에 빨간줄이 뜨면 Alt + Enter 또는 Ctrl + . 을 눌러서 '__모든 맴버를 명시적으로 구현__' 선택
4. TestProcess에서 TestClass와 TestClass2의 의 __프로젝트가 아닌 어셈블리__를 참조한 다음 TestClass와 TestClass2를 생성자로 할당한다.
이후 F12를 눌러 __TestClass와 TestClass2의 메타데이터를 확인__ 한다.
5. TestClass3, TestClass4 는 인터페이스에서 상속받은 맴버를 internal과 private으로 지정했을 경우를 테스트한 것인데 인터페이스의 맴버는 internal과 private으로 지정할 수 없다.
따라서 어셈블리에서 인터페이스의 맴버를 숨기고 싶다면 '__모든 맴버를 명시적으로 구현__' 형태로 사용해야 한다.
