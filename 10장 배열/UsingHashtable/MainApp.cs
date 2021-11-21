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
            ht["하나"] = "one"; // 어떤 형식이든 키로 사용 가능
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht[123] = "five";

            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht[123]);

        }

    }
}