using System;

namespace Throw
{
    class MainApp
    {
        static void DoSomeThing(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }

        static void Main(string[] args)
        {
            try
            {
                DoSomeThing(1);
                DoSomeThing(2);
                DoSomeThing(3);
                DoSomeThing(9);
                DoSomeThing(10);
                DoSomeThing(13);
            }
            catch (Exception e) // 모든 예외는 system.Exception을 상속받음
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}