using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    public class OrderItemInterface
    {
        public int Qty { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsImported { get; set; }
        public ItemType OrderItemType { get; set; }

        public OrderItemInterface()
        {
            //Set properties to default values
            IsImported = false;
            Qty = 0;
            Price = 0;
            Description = "";
            OrderItemType = ItemType.Other;
        }
    }

    public enum ItemType
    {
        Book,
        Food,
        Medical,
        Other
    }
}
