using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTax
{
    public partial class MainForm : Form
    {
        private List<OrderItem> OrderItems;

        public MainForm()
        {
            InitializeComponent();
            OrderItems = new List<OrderItem>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn itemTypeColumn = (DataGridViewComboBoxColumn)dgv_OrderEntries.Columns["orderItemTypeDataGridViewComboBoxColumn"];

            //Set the dropdown item type and the available items
            itemTypeColumn.ValueType = typeof(ItemType);
            itemTypeColumn.Items.AddRange(ItemType.Other, ItemType.Book, ItemType.Food, ItemType.Medical);

            OrderItemInterface defaultItem = new OrderItemInterface();
            defaultItem.Description = "Chocolate bar";
            defaultItem.IsImported = true;
            defaultItem.Price = 0.85m;
            defaultItem.Qty = 1;
            defaultItem.OrderItemType = ItemType.Food;

            orderItemInterfaceBindingSource.Add(defaultItem);
        }

        private void Btn_Total_Click(object sender, EventArgs e)
        {
            OrderItems.Clear();

            //Process all of the order items
            foreach (OrderItemInterface item in orderItemInterfaceBindingSource)
            {
                switch(item.OrderItemType)
                {
                    case ItemType.Book:
                        Book newBookItem = new Book(item.Qty, item.Price, item.Description, item.IsImported);
                        OrderItems.Add(newBookItem);
                        break;
                    case ItemType.Food:
                        Food newFoodItem = new Food(item.Qty, item.Price, item.Description, item.IsImported);
                        OrderItems.Add(newFoodItem);
                        break;
                    case ItemType.Medical:
                        Medical newMedicalItem = new Medical(item.Qty, item.Price, item.Description, item.IsImported);
                        OrderItems.Add(newMedicalItem);
                        break;
                    case ItemType.Other:
                    default:
                        OrderItem newOrderItem = new OrderItem(item.Qty, item.Price, item.Description, item.IsImported);
                        OrderItems.Add(newOrderItem);
                        break;
                }
            }

            //Generate Receipt
            txt_Receipt.Text = Receipt.GenerateReceipt(OrderItems);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            //Clear the order and the receipt
            dgv_OrderEntries.Rows.Clear();
            txt_Receipt.Text = "";
        }
    }
}
