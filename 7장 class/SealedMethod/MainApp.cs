using System;

class Base
{
    public virtual void SealMe()
    {
    }
}

class Derived : Base
{
    public sealed override void SealMe() // sealed로 오버라이딩을 봉인
    {
    }
}

class WantToOverride : Derived
{
    public override void SealMe() // 에러 발생.
    {
    }
}


class MainApp
{
    static void Main(string[] args)
    {
    }
}