using System;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension //static으로 선언
    {

        public static int Square(this int myInt) // static으로 선언, 첫 번째 매개변수는 this 확장대상형식 식별자 이여야 한다.
        {
            return myInt * myInt;
        }
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }

            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");

        }
    }
}