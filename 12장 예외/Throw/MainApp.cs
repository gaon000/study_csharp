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
                throw new Exception("arg�� 10���� Ů�ϴ�.");
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
            catch (Exception e) // ��� ���ܴ� system.Exception�� ��ӹ���
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}