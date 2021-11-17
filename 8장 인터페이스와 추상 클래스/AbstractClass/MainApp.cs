using System;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void ProtectedMethodA() // 추상 클래스는 인터페이스와 달리 구현이 가능
        {
            Console.WriteLine("AbstractBase.ProtectedMethodA");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA(); //추상 메소드
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            ProtectedMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}