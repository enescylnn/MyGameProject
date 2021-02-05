using System;

namespace MyGame
{
    class OrderManager : IOrderService
    {
        public void MakeSale(Products products)
        {
            Console.WriteLine("The sale transaction has been completed successfully");
            Console.WriteLine("Sold Product Name : " + products.ProductName);
            Console.WriteLine("Price : " + products.UnitPrice);
            Console.WriteLine("Remaining Stock : " + ((products.Stock)-1));
        }
    }
}