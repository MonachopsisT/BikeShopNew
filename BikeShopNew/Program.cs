using System;

namespace BikeShopNew
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeShop shop1 = new BikeShop();
            shop1.PrintStock();


            BikeShop shop2 = new BikeShop();
            //shop1.PrintStock();


            Console.ReadLine();
        }
    }
}
