using System;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize() // virtual Ű����� �����ؾ���
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize() // override�� ����
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan....");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}