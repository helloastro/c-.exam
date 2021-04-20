using System;

namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine(price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_price = ref carrot.GetPrice();
            int price = carrot.GetPrice();

            carrot.PrintPrice(); // 객체 변수출력
            Console.WriteLine($"ref_price: {ref_price }");
            Console.WriteLine($"price: {price }");

            ref_price = 200;
            carrot.PrintPrice(); // 객체 변수출력
            Console.WriteLine($"ref_price: {ref_price }");
            Console.WriteLine($"price: {price }");

        }
    }
}
