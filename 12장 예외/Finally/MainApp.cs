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
                Console.Write("������ �Է��ϼ��� : ");
                String temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("�������� �Է��ϼ��� : ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    dividend, divisor, Divide(dividend, divisor));
            }
            catch (FormatException e)
            {
                Console.WriteLine("���� : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("���� : " + e.Message);
            }
            finally
            {
                Console.WriteLine("���α׷� ����");

            }
        }
    }
}