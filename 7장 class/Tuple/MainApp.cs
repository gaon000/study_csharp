using System;

namespace Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = ("���۸�", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            var b = (Name: "�㰡��", Age: 19);
            Console.WriteLine($"{b.Name}, {b.Age}");

            var (name, age) = b; // �ʵ��� ���� ������ ������ �Ҵ� ����
            Console.WriteLine($"{name}, {age}");

            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}