using System;
namespace BikeShopNew
{
    public class BikeShop
    {
        public int[,] myBikes;
        public Product[] myProducts;

        public BikeShop()
        {
            //bikeNumber,Price, Number of bikes of that type
            Random rand = new Random();
            
            myProducts = new Product[rand.Next(1, 500)];

            for (int i = 0; i < myProducts.Length; i++)
            {
                myProducts[i] = new Product(rand.Next(1,4), rand.Next(1,3));
            }

           // myBikes = new int[6, 3];
           // for (int i = 0; i < 6; i++)
           // {
           //     myBikes[i, 0] = rand.Next(1, 4000000);
            //    myBikes[i, 1] = ;
            //    myBikes[i,2] = 


        }
        public void PrintStock()
        {
            for (int j = 0; j < myProducts.Length; j++)
            {
                myProducts[j].PrintDetails();
            }
            
        }
    }
}
