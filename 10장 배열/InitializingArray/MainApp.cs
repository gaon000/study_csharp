using System;

namespace InitializingArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "halo" };

            Console.WriteLine("Array1...");
            foreach (string greeting in array1)
                Console.WriteLine($" {greeting}");

            string[] array2 = new string[] { "안녕", "hello", "halo" };
            string[] array3 = { "안녕", "hello", "halo" }; // new, 형식, 배열의 용량 생략 가능

        }

    }
}