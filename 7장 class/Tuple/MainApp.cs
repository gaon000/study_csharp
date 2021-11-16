using System;

namespace Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            var b = (Name: "허가온", Age: 19);
            Console.WriteLine($"{b.Name}, {b.Age}");

            var (name, age) = b; // 필드의 수와 형식이 같으면 할당 가능
            Console.WriteLine($"{name}, {age}");

            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}