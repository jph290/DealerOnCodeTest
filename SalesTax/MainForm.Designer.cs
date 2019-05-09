namespace SalesTax
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grp_Order = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.dgv_OrderEntries = new System.Windows.Forms.DataGridView();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemTypeDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImportedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderItemInterfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp_Receipt = new System.Windows.Forms.GroupBox();
            this.txt_Receipt = new System.Windows.Forms.TextBox();
            this.grp_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemInterfaceBindingSource)).BeginInit();
            this.grp_Receipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Order
            // 
            this.grp_Order.Controls.Add(this.btn_Clear);
            this.grp_Order.Controls.Add(this.btn_Total);
            this.grp_Order.Controls.Add(this.dgv_OrderEntries);
            this.grp_Order.Location = new System.Drawing.Point(12, 12);
            this.grp_Order.Name = "grp_Order";
            this.grp_Order.Size = new System.Drawing.Size(550, 651);
            this.grp_Order.TabIndex = 0;
            this.grp_Order.TabStop = false;
            this.grp_Order.Text = "Order";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(6, 604);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(538, 39);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(6, 559);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(538, 39);
            this.btn_Total.TabIndex = 1;
            this.btn_Total.Text = "&Total";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.Btn_Total_Click);
            // 
            // dgv_OrderEntries
            // 
            this.dgv_OrderEntries.AutoGenerateColumns = false;
            this.dgv_OrderEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qtyDataGridViewTextBoxColumn,
            this.orderItemTypeDataGridViewComboBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.isImportedDataGridViewCheckBoxColumn});
            this.dgv_OrderEntries.DataSource = this.orderItemInterfaceBindingSource;
            this.dgv_OrderEntries.Location = new System.Drawing.Point(6, 19);
            this.dgv_OrderEntries.Name = "dgv_OrderEntries";
            this.dgv_OrderEntries.Size = new System.Drawing.Size(538, 534);
            this.dgv_OrderEntries.TabIndex = 0;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 30;
            // 
            // orderItemTypeDataGridViewComboBoxColumn
            // 
            this.orderItemTypeDataGridViewComboBoxColumn.DataPropertyName = "OrderItemType";
            this.orderItemTypeDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.orderItemTypeDataGridViewComboBoxColumn.HeaderText = "Item Type";
            this.orderItemTypeDataGridViewComboBoxColumn.Name = "orderItemTypeDataGridViewComboBoxColumn";
            this.orderItemTypeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // isImportedDataGridViewCheckBoxColumn
            // 
            this.isImportedDataGridViewCheckBoxColumn.DataPropertyName = "IsImported";
            this.isImportedDataGridViewCheckBoxColumn.HeaderText = "Imported";
            this.isImportedDataGridViewCheckBoxColumn.Name = "isImportedDataGridViewCheckBoxColumn";
            this.isImportedDataGridViewCheckBoxColumn.Width = 50;
            // 
            // orderItemInterfaceBindingSource
            // 
            this.orderItemInterfaceBindingSource.DataSource = typeof(SalesTax.OrderItemInterface);
            // 
            // grp_Receipt
            // 
            this.grp_Receipt.Controls.Add(this.txt_Receipt);
            this.grp_Receipt.Location = new System.Drawing.Point(568, 12);
            this.grp_Receipt.Name = "grp_Receipt";
            this.grp_Receipt.Size = new System.Drawing.Size(324, 651);
            this.grp_Receipt.TabIndex = 1;
            this.grp_Receipt.TabStop = false;
            this.grp_Receipt.Text = "Receipt";
            // 
            // txt_Receipt
            // 
            this.txt_Receipt.AcceptsReturn = true;
            this.txt_Receipt.Enabled = false;
            this.txt_Receipt.Location = new System.Drawing.Point(6, 19);
            this.txt_Receipt.Multiline = true;
            this.txt_Receipt.Name = "txt_Receipt";
            this.txt_Receipt.Size = new System.Drawing.Size(312, 624);
            this.txt_Receipt.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 669);
            this.Controls.Add(this.grp_Receipt);
            this.Controls.Add(this.grp_Order);
            this.Name = "MainForm";
            this.Text = "Helmus\' Discount Warehouse";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grp_Order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemInterfaceBindingSource)).EndInit();
            this.grp_Receipt.ResumeLayout(false);
            this.grp_Receipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Order;
        private System.Windows.Forms.GroupBox grp_Receipt;
        private System.Windows.Forms.DataGridView dgv_OrderEntries;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.TextBox txt_Receipt;
        private System.Windows.Forms.BindingSource orderItemInterfaceBindingSource;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderItemTypeDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isImportedDataGridViewCheckBoxColumn;
    }
}

