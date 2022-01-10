using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    class Program
    {
        static void Main()
        {

            Cart cart = new Cart();
            PerishableProducts apples = new PerishableProducts { Name = "apple", Brand = "BrandA", Price = 1.50, ExpirationDate = new DateTime(2021,6,14) };
            PerishableProducts milk = new PerishableProducts { Name = "milk", Brand = "BrandM", Price = 0.99, ExpirationDate=new DateTime(2022, 2, 2) };
            Clothes tshirt = new Clothes { Name = "T-Shirt", Brand = "BrandT", Price = 15.99, Color = "Violet", Size = Size.M };
            Appliances laptop = new Appliances { Name = "laptop", Brand = "BrandL", Price = 2345, Model = "ModelL", ProductionDate = new DateTime(2021, 3, 3), Weight = 1.125 };


            cart.AddProduct(apples,2.45);
            cart.AddProduct(milk, 3);
            cart.AddProduct(tshirt, 2);
            cart.AddProduct(laptop, 1);

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(cart.cart, new DateTime(2021, 6, 14,12,34,56));

        }
    }
}
