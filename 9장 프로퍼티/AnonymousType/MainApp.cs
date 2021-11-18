using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 }; // 무명형식은 읽기전용임.
            Console.WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject : {b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}