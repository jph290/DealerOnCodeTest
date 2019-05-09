using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    public static class Receipt
    {
        public static string GenerateReceipt(List<OrderItem> orderItems)
        {
            List<OrderItem> receiptOrderItems = new List<OrderItem>();

            //Check For Duplicates
            foreach(OrderItem item in orderItems)
            {
                CheckForDuplicateItem(item, ref receiptOrderItems);
            }

            string receiptOutput = "";
            Decimal taxTotal = 0.00m;
            Decimal itemTotal = 0.00m;

            foreach (OrderItem item in receiptOrderItems)
            {
                receiptOutput += item.ToString();

                var totals = item.GetItemTotals();
                taxTotal += totals.TaxTotal;
                itemTotal += totals.ItemTotal;
            }

            //Generate Receipt Footer

            receiptOutput += $"Sales Taxes: {taxTotal:0.00}\r\n";
            receiptOutput += $"Total: {taxTotal + itemTotal:0.00}";

            return receiptOutput;
        }

        private static void CheckForDuplicateItem(OrderItem newItem, ref List<OrderItem> existingItems)
        {
            foreach (OrderItem item in existingItems)
            {
                if (item == newItem)
                {
                    //Add the quantity of this line to the previous entry for the item
                    item.Qty += newItem.Qty;

                    //Speed up processing
                    return;
                }
            }

            //This will only be hit if the item was not found in the order already
            existingItems.Add(newItem);
        }
    }
}
