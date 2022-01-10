using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class PerishableProducts : Product
    {

        public DateTime ExpirationDate { get; set; }

    }
}
