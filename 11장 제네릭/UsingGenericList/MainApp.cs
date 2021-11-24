using System;
using System.Collections.Generic;

namespace UsingGenericList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); // 입력한 형식 외에는 값을 넣을 수 없음
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (int element in list)
                Console.Write($"{element} ");
        }
    }
}