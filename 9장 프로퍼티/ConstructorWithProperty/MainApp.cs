using System;

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } // 초기화
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현", // 프로퍼티 생성자
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}