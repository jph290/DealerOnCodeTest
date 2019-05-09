using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input1Test()
        {
            /*
             * Tests the following Inputs
             * 1 Book at 12.49
             * 1 Book at 12.49
             * 1 Music CD at 14.99
             * 1 Chocolate bar at 0.85
             */

            //Generate Expected receipt
            string expectedReceipt = "Book: 24.98 (2 @ 12.49)\r\n" +
                                     "Music CD: 16.49\r\n" +
                                     "Chocolate bar: 0.85\r\n" +
                                     "Sales Taxes: 1.50\r\n" +
                                     "Total: 42.32";

            //Test
            List<OrderItem> orderItems = new List<OrderItem>();

            Book book1 = new Book(1, 12.49m, "Book", false);
            Book book2 = new Book(1, 12.49m, "Book", false);
            OrderItem cd = new OrderItem(1, 14.99m, "Music CD", false);
            Food chocolate = new Food(1, 0.85m, "Chocolate bar", false);

            orderItems.Add(book1);
            orderItems.Add(book2);
            orderItems.Add(cd);
            orderItems.Add(chocolate);

            string generatedReceipt = Receipt.GenerateReceipt(orderItems);

            Assert.AreEqual<string>(expectedReceipt, generatedReceipt);
        }

        [TestMethod]
        public void Input2Test()
        {
            /*
             * Tests the following Inputs
             * 1 Imported box of chocolates at 10.00
             * 1 Imported bottle of perfume at 47.50
             */

            //Generate Expected receipt
            string expectedReceipt = "Imported box of chocolates: 10.50\r\n" +
                                     "Imported bottle of perfume: 54.65\r\n" +
                                     "Sales Taxes: 7.65\r\n" +
                                     "Total: 65.15";

            //Test
            List<OrderItem> orderItems = new List<OrderItem>();

            Food chocolate = new Food(1, 10.00m, "box of chocolates", true);
            OrderItem perfume = new OrderItem(1, 47.50m, "bottle of perfume", true);
            

            orderItems.Add(chocolate);
            orderItems.Add(perfume);
            
            string generatedReceipt = Receipt.GenerateReceipt(orderItems);

            Assert.AreEqual<string>(expectedReceipt, generatedReceipt);
        }

        [TestMethod]
        public void Input3Test()
        {
            /*
             * Tests the following Inputs
             * 1 Imported bottle of perfume at 27.99
             * 1 Bottle of perfume at 18.99
             * 1 Packet of headache pills at 9.75
             * 1 Imported box of chocolates at 11.25
             * 1 Imported box of chocolates at 11.25
             */

            //Generate Expected receipt
            string expectedReceipt = "Imported bottle of perfume: 32.19\r\n" +
                                     "Bottle of perfume: 20.89\r\n" +
                                     "Packet of headache pills: 9.75\r\n" +
                                     "Imported box of chocolates: 23.70 (2 @ 11.85)\r\n" +
                                     "Sales Taxes: 7.30\r\n" +
                                     "Total: 86.53";

            //Test
            List<OrderItem> orderItems = new List<OrderItem>();

            OrderItem importPerfume = new OrderItem(1, 27.99m, "bottle of perfume", true);
            OrderItem perfume = new OrderItem(1, 18.99m, "Bottle of perfume", false);
            Medical pills = new Medical(1, 9.75m, "Packet of headache pills", false);
            Food chocolate1 = new Food(1, 11.25m, "box of chocolates", true);
            Food chocolate2 = new Food(1, 11.25m, "box of chocolates", true);

            orderItems.Add(importPerfume);
            orderItems.Add(perfume);
            orderItems.Add(pills);
            orderItems.Add(chocolate1);
            orderItems.Add(chocolate2);

            string generatedReceipt = Receipt.GenerateReceipt(orderItems);

            Assert.AreEqual<string>(expectedReceipt, generatedReceipt);
        }

        [TestMethod]
        public void ZeroQtyTest()
        {
            /*
             * Tests the following Inputs
             * 1 Imported box of chocolates at 10.00
             * 0 Imported bottle of perfume at 47.50
             */

            //Generate Expected receipt
            string expectedReceipt = "Imported box of chocolates: 11.05\r\n" +
                                     "Sales Taxes: 0.55\r\n" +
                                     "Total: 11.05";

            //Test
            List<OrderItem> orderItems = new List<OrderItem>();

            Food chocolate = new Food(1, 10.50m, "box of chocolates", true);
            OrderItem perfume = new OrderItem(0, 47.50m, "bottle of perfume", true);


            orderItems.Add(chocolate);
            orderItems.Add(perfume);

            string generatedReceipt = Receipt.GenerateReceipt(orderItems);

            Assert.AreEqual<string>(expectedReceipt, generatedReceipt);
        }

        [TestMethod]
        public void ZeroTaxesTest()
        {
            /*
             * Tests the following Inputs
             * 1 box of chocolates at 10.00
             * 1 box of ibuprofen at 11.00
             * 1 Book at 11.99
             */

            //Generate Expected receipt
            string expectedReceipt = "box of chocolates: 10.00\r\n" +
                                     "box of ibuprofen: 11.00\r\n" +
                                     "Book: 11.99\r\n" +
                                     "Sales Taxes: 0.00\r\n" +
                                     "Total: 32.99";

            //Test
            List<OrderItem> orderItems = new List<OrderItem>();

            Food chocolate = new Food(1, 10.00m, "box of chocolates", false);
            Medical pills = new Medical(1, 11.00m, "box of ibuprofen", false);
            Book book = new Book(1, 11.99m, "Book", false);


            orderItems.Add(chocolate);
            orderItems.Add(pills);
            orderItems.Add(book);

            string generatedReceipt = Receipt.GenerateReceipt(orderItems);

            Assert.AreEqual<string>(expectedReceipt, generatedReceipt);
        }
    }
}
