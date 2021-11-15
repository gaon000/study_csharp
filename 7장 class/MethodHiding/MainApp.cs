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
        public new void MyMethod() // �������� new�ʹ� �ٸ�
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

            Base baseOrDerived = new Derived(); // Base.MyMethod()�� ���´�. ������ �������� ǥ������ ���ϴ� �Ѱ谡 �ִ�
            baseOrDerived.MyMethod();
        }
    }
}