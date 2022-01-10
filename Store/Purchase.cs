using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Purchase
    {
        public double Discount { get; set; }
        

        public double SetDiscount(Product p,DateTime PurchasedDate)
        {
            switch (p)
            {
                case PerishableProducts:
                    PerishableProducts perishableProducts = (PerishableProducts) p;
                    TimeSpan difference = perishableProducts.ExpirationDate - PurchasedDate;
                    if (difference.Days <= 5 && difference.Days > 0) Discount = 0.1;
                    else if (difference.Days == 0) Discount = 0.5;
                    else Discount = 0;
                    break;
                case Clothes:
                    //Clothes clothes = (Clothes)p;
                    if ((PurchasedDate.DayOfWeek >= DayOfWeek.Monday) && (PurchasedDate.DayOfWeek <= DayOfWeek.Friday))
                        Discount = 0.1;
                    else Discount = 0;
                     break;
                case Appliances:
                    Appliances appliances = (Appliances)p;
                    if (appliances.Price > 999 && ((PurchasedDate.DayOfWeek == DayOfWeek.Saturday) || (PurchasedDate.DayOfWeek == DayOfWeek.Sunday)))
                        Discount = 0.05;
                    else Discount = 0;
                        break;
            }
            return Discount;
            
        }
    }
}
