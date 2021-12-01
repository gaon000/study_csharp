using System;

namespace TryCatch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]); // indexoutofrange �߻�
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"���� �߻� : {e.Message}");
            }

            Console.WriteLine("����");
        }
    }
}