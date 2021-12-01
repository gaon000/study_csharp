using System;

namespace Finally
{
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() start");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() error");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() end");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");
                String temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    dividend, divisor, Divide(dividend, divisor));
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");

            }
        }
    }
}