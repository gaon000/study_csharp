using System;

class Global
{
    public static int Count = 0; // static으로 한정한 필드는 클래스에 소속됨
}

class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}

class ClassB
{
    public classB()
    {
        Global.Count++;
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Global.Count : {Global.Count}"); // 0
        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();
        Console.WriteLine($"Global.Count : {Global.Count}"); // 4
    }
}
