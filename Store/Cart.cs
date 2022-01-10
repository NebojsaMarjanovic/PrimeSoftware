using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cart
    {
        public double Quantity { get; set; }
        public List<Product> cart;

        public Cart()
        {
            cart = new List<Product>(); 
        }

        public void AddProduct(Product p, double quantity)
        {
            p.Quantity = quantity;
            cart.Add(p);
        }




    }


}
