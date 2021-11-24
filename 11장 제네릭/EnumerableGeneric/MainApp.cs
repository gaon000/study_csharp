using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;

namespace EnumerableGeneric
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T> // foreach 구문은 IEnumerable, IEnumerator를 상속하는 형식만 지원한다.
    {
        private T[] array;
        int position = -1;
        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public T Current
        {
            get
            {
                return array[position];
            }
        }

        Object IEnumerator.Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list[0] = "abc";
            list[1] = "def";
            list[2] = "ghi";
            list[3] = "jkl";

            foreach (string e in list)
                WriteLine(e);
            WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;

            foreach (int no in int_list)
                WriteLine(no);
        }

    }
}