using System;
using System.Collections;
using static System.Console;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator // foreach 구문은 IEnumerable, IEnumerator를 상속하는 형식만 지원한다.
    {
        private int[] array;
        int position = 0;
        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public object Current
        {
            get
            {
                return array[position];
            }
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

        public IEnumerator GetEnumerator()
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
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                WriteLine(e);
        }

    }
}