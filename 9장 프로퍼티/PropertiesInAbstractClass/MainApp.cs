using System;

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialId // 구현을 가진 프로퍼티
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate // 구현이 없는 추상 프로퍼티
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2021, 11, 18)
            };

            Console.WriteLine("Product:{0}, Product Date : {1}", product_1.SerialId, product_1.ProductDate);

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2021, 1, 11)
            };

            Console.WriteLine("Product : {0}, Product Date : {1}", product_2.SerialId, product_2.ProductDate);
        }
    }
}