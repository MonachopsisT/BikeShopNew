using System;
namespace BikeShopNew
{
    public class Product
    {
        public string productType;
        public int productTypeNum;//1-Off Road, 2-Racers, 3- Kids Carrier

        public int productSystem; //1-electic, 2-mechanical
        public string productSystemName; //1-electic, 2-mechanical

        public double price;

        Random rand = new Random();

        public Product( int prodType, int prodSystem)
        {
            switch(prodType)
            {
                case 1:
                    {
                        productType = "OffRoad";
                        price = 2.5;
                    }
                    break;
                case 2:
                    {
                        productType = "Racer";
                        price = 1.8;
                    }
                    break;
                case 3:
                    {
                        productType = "KidsCarrier";
                        price = 3;
                    }
                    break;
                default:
                    {
                        productType = "Null";
                        price = 0;  //price is zero if there is no such bike
                        Console.WriteLine("Invalid input");
                    }
                    break;

            }

            if (prodSystem == 1)
            {
                productSystem = 1;
                productSystemName = "Electric";
                price += 1; //if it is electric add one to the price
            }
            else
            {
                productSystem = 2;
                productSystemName = "Mechanical";
            }

        }
       
        public void PrintDetails()
        {
            Console.WriteLine("I am a: {0} and I am of type: {1} and my price is: {2}", productType, productSystemName, price);
        }
    }
}
