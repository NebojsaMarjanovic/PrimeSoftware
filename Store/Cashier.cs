using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier
    {

        Purchase purchase = new Purchase();
        double totalPrice = 0;
        double totalDiscount = 0;

        
        public  void PrintReceipt(List<Product> cart,DateTime PurchasedDate)
        {
            Console.WriteLine($"Date: {PurchasedDate.ToString("yyy-MM-dd HH:mm:ss")}");
            Console.WriteLine("---Products---\n");
            foreach(Product product in cart) 
            {
                switch (product)
                {
                    case PerishableProducts:
                        PerishableProducts perishableProducts = (PerishableProducts)product;
                        Console.WriteLine($"{perishableProducts.Name} - {perishableProducts.Brand} ");
                        break;
                    case Clothes:
                        Clothes clothes = (Clothes)product;
                        Console.WriteLine($"{clothes.Name} - {clothes.Brand} {clothes.Size} {clothes.Color}");
                        break;
                    case Appliances:
                        Appliances appliances = (Appliances)product;
                        Console.WriteLine($"{appliances.Name} - {appliances.Brand} {appliances.Model} ");
                        break;

                }


                double priceWithoutDiscount = Math.Round(product.Quantity * product.Price,2);
                Console.WriteLine($"{product.Quantity} x ${product.Price} = ${priceWithoutDiscount}");
                double discountPercent = purchase.SetDiscount(product, PurchasedDate);
                if (discountPercent == 0)
                {
                    totalPrice = totalPrice + priceWithoutDiscount;
                    Console.WriteLine();
                    continue;
                }
                double discount = Math.Round(priceWithoutDiscount * discountPercent,2);
                Console.WriteLine($"#discount {discountPercent*100}% -${discount}");
                totalPrice = totalPrice + priceWithoutDiscount;
                totalDiscount = totalDiscount + discount;

                Console.WriteLine();

            }
            Console.WriteLine("-----------------------------------------------------------------------------------\n");
            Console.WriteLine($"SUBTOTAL: ${totalPrice}");
            Console.WriteLine($"DISCOUNT: -${totalDiscount}\n");
            Console.WriteLine($"TOTAL: ${totalPrice-totalDiscount}");
        }

        
    }
}
