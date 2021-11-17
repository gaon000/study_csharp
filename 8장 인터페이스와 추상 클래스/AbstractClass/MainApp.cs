using System;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void ProtectedMethodA() // �߻� Ŭ������ �������̽��� �޸� ������ ����
        {
            Console.WriteLine("AbstractBase.ProtectedMethodA");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA(); //�߻� �޼ҵ�
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