using System;
using System.Collections;
using static System.Console;

namespace UsingHashtable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["�ϳ�"] = "one"; // � �����̵� Ű�� ��� ����
            ht["��"] = "two";
            ht["��"] = "three";
            ht["��"] = "four";
            ht[123] = "five";

            WriteLine(ht["�ϳ�"]);
            WriteLine(ht["��"]);
            WriteLine(ht["��"]);
            WriteLine(ht[123]);

        }

    }
}