using System;

namespace _7장
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat(); // class는 복합데이터 형식으로 참조형식임. 따라서 new와 생성자를 이용해 힙에 객체 생성 
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

        }
    }

    class Cat
    {
        public Cat() // 명시적으로 생성자를 구현하지 않아도 자동으로 컴파일러가 만들어줌
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color) // 다른 메서드와 마찬가지로 오버로딩 가능
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat() // 종료자, 가비지 컬렉터가 객체가 소멸되는 시점에 종료자를 호출함, 하지만 가비지컬렉터가 언제 작동할지 예측 불가
        {
            Console.WriteLine($"{Name} : 잘가");
        }
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야용");
        }
    }
}
