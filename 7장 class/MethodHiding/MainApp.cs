using System;

namespace MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        public new void MyMethod() // 생성자의 new와는 다름
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived(); // Derived.MyMethod()
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived(); // Base.MyMethod()로 나온다. 완전한 다형성을 표현하지 못하는 한계가 있다
            baseOrDerived.MyMethod();
        }
    }
}