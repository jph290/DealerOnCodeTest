using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    public class OrderItem
    {
        #region Properties

        public int Qty { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsImported { get; set; }

        #endregion

        public OrderItem()
        {
            //Set properties to default values
            IsImported = false;
            Qty = 0;
            Price = 0;
            Description = "";
        }

        public OrderItem(int qty, decimal price, string description, bool imported)
        {
            IsImported = imported;
            Qty = qty;
            Price = price;
            Description = description;
        }

        public (decimal ItemTotal, decimal TaxTotal) GetItemTotals()
        {
            decimal price = Qty * Price;
            decimal salesTaxes = Qty * (GetSalesTax() + GetImportTax());

            //Returns the price and sales tax to allow for calculating total cost of the order
            return (price, salesTaxes);
        }

        private decimal GetImportTax()
        {
            if (IsImported)
            {
                //Item is imported, add import tax
                decimal unroundedTax = Price * GetImportTaxRate();
                decimal roundedTax = RoundUpTax(unroundedTax);

                return roundedTax;
            }
            else
            {
                //Item is not imported
                return 0.00m;
            }
        }

        private decimal GetSalesTax()
        {
            //Gets the sales tax for a single item.  This allows for the sales tax rate to change for children, while separating the import tax calculations for future changes.
            decimal unroundedSingleItemSalesTax = Price * GetSalesTaxRate();
            decimal roundedSingleItemSalesTax = RoundUpTax(unroundedSingleItemSalesTax);

            return roundedSingleItemSalesTax;
        }

        private decimal RoundUpTax(decimal tax)
        {
            decimal taxRemainder = tax % 0.05m;

            if (taxRemainder > 0)
            {
                //Need to round up
                decimal roundedDownTax = tax - taxRemainder;

                //Add the extra 0.05 to round up
                return roundedDownTax + 0.05m;
            }
            else
            {
                //No need to round
                return tax;
            }
        }

        #region Child Overrides

        internal virtual decimal GetSalesTaxRate()
        {
            //This function allows for the sales tax rate to be adjusted for a child item
            return 0.10m;
        }

        internal virtual decimal GetImportTaxRate()
        {
            //This function allows for the import tax rate to be adjusted for a child item
            return 0.05m;
        }

        #endregion

        #region Overrides

        //Change the ToString to show the receipt line
        public override string ToString()
        {
            if (Qty != 0)
            {
                //Build receipt string
                string receiptString = IsImported ? "Imported " : "";
                receiptString += $"{Description}: {Qty * (Price + GetImportTax() + GetSalesTax()):0.00}";

                //Add quantity split if there are multiple items for the given entry
                if (Qty > 1 || Qty < -1)
                {
                    receiptString += $" ({Qty} @ {Price + GetImportTax() + GetSalesTax():0.00})";
                }

                return receiptString + "\r\n"; //Add space between items
            }
            else
            {
                //Return nothing as qty was 0 (also known as voided).
                return "";
            }
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //Return false if the item is null or the wrong type
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            //Check to see if the items have the same values that matter
            OrderItem otherItem = (OrderItem)obj;

            bool descriptionEqual = Description.Equals(otherItem.Description, StringComparison.OrdinalIgnoreCase); //Compare ignoring case
            bool importStatusEqual = (IsImported == otherItem.IsImported);
            bool priceEqual = (Price == otherItem.Price);

            return descriptionEqual && importStatusEqual && priceEqual;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Operators
        public static bool operator ==(OrderItem item1, OrderItem item2)
        {
            return item1.Equals(item2);
        }

        public static bool operator !=(OrderItem item1, OrderItem item2)
        {
            return !(item1.Equals(item2));
        }

        #endregion
    }
}
