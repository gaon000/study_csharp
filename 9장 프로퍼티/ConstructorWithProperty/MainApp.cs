using System;

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } // �ʱ�ȭ
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
                Name = "����", // ������Ƽ ������
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}