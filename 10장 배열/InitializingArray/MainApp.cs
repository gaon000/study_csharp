using System;

namespace InitializingArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "�ȳ�", "Hello", "halo" };

            Console.WriteLine("Array1...");
            foreach (string greeting in array1)
                Console.WriteLine($" {greeting}");

            string[] array2 = new string[] { "�ȳ�", "hello", "halo" };
            string[] array3 = { "�ȳ�", "hello", "halo" }; // new, ����, �迭�� �뷮 ���� ����

        }

    }
}