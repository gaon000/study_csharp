using System;

namespace ThisConstructor
{
	class MyClass
	{
		int a, b, c;

		public MyClass()
		{
			this.a = 5425;
			Console.WriteLine("MyClass()");
		}

		public MyClass(int b) : this() // this()는 자기 자신의 생성자를 가르킨다. 또한 this()는 생성자에서만 사용할 수 있다.
		/*
		 * public Myclass(int b)
		 * {
		 *	this.a = 5425;
		 *	this.b = b;
		 * }
		 */
		{
			this.b = b;
			Console.WriteLine($"MyClass({b})");
		}

		public MyClass(int b, int c) : this(b)
		{
			this.c = c;
			Console.WriteLine($"MyClass({b}, {c})");
		}

		public void PrintFields()
		{
			Console.WriteLine($"a:{a}, b:{b}, c:{c}");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			MyClass a = new MyClass();
			a.PrintFields();
			Console.WriteLine();

			MyClass b = new MyClass(1);
			b.PrintFields();
			Console.WriteLine();

			MyClass c = new MyClass(10, 20);
			c.PrintFields();
		}
	}
}