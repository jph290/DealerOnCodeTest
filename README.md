# This application is designed to calculate sales totals with sales and import tax.
When coming up with the design, I was trying to be as user friendly as possible.  The user is able to enter the order like an excel spreadsheet.
The Data Grid View allows for easy design and has nice built-in functionality for binding, adding, removing, and editing.  
The Data Grid View brings a lot of nice features for free and allowed me to focus on the more demanding tasks.
The receipt is a simple Textbox in multiline mode.  This allows for a nice receipt look as well.

The assumption I made was the availability of a keyboard and mouse.  As this program is, it wouldn't support a scanner.

I have included unit tests for the 3 input/output scenarios given in the document.  I have also added a couple of test to make sure additional items are good as well.

Sales Tax Considerations
------------------------
The ability for the sales tax to be overridden in the children of the OrderItem was added to allow exceptions for Book, Medical items, and Food.

Order Entry Considerations
------------------------
If a quantity is 0, I have allowed it to be in the order, but will not print on the receipt as it was not purchased.  This is for ease of use.

Import Tax Considerations
------------------------
I chose to allow the Import Tax to be overridden in the children of the OrderItem for possible future needs.
