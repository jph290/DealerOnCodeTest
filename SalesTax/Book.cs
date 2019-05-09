using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    public class Book: OrderItem
    {
        internal override decimal GetSalesTaxRate()
        {
            //Override the sales tax for this item.
            return 0.00m;
        }

        public Book(int qty, decimal price, string description, bool imported) :
            base(qty, price, description, imported)
        {

        }
    }
}
