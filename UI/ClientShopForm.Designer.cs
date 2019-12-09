namespace V.ShopWithInventory.UI
{
    partial class ClientShopForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceForEachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceForEachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.addToCartButton = new System.Windows.Forms.Button();
            this.quantityAddTextBox = new System.Windows.Forms.TextBox();
            this.quantityRemoveTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(23, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(V.ShopWithInventory.Models.Product);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceForEachDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productBindingSource1;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 84);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(488, 251);
            this.productsDataGridView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceForEachDataGridViewTextBoxColumn
            // 
            this.priceForEachDataGridViewTextBoxColumn.DataPropertyName = "PriceForEach";
            this.priceForEachDataGridViewTextBoxColumn.HeaderText = "Цена за бройка";
            this.priceForEachDataGridViewTextBoxColumn.Name = "priceForEachDataGridViewTextBoxColumn";
            this.priceForEachDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceForEachDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "Налично количество";
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityInStockDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(V.ShopWithInventory.Models.Product);
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AutoGenerateColumns = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceForEachDataGridViewTextBoxColumn1,
            this.quantityInStockDataGridViewTextBoxColumn1});
            this.cartDataGridView.DataSource = this.productBindingSource2;
            this.cartDataGridView.Location = new System.Drawing.Point(697, 86);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.Size = new System.Drawing.Size(493, 251);
            this.cartDataGridView.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // priceForEachDataGridViewTextBoxColumn1
            // 
            this.priceForEachDataGridViewTextBoxColumn1.DataPropertyName = "PriceForEach";
            this.priceForEachDataGridViewTextBoxColumn1.HeaderText = "Цена за бройка";
            this.priceForEachDataGridViewTextBoxColumn1.Name = "priceForEachDataGridViewTextBoxColumn1";
            this.priceForEachDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceForEachDataGridViewTextBoxColumn1.Width = 150;
            // 
            // quantityInStockDataGridViewTextBoxColumn1
            // 
            this.quantityInStockDataGridViewTextBoxColumn1.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn1.HeaderText = "Налично количество";
            this.quantityInStockDataGridViewTextBoxColumn1.Name = "quantityInStockDataGridViewTextBoxColumn1";
            this.quantityInStockDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantityInStockDataGridViewTextBoxColumn1.Width = 150;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(V.ShopWithInventory.Models.Product);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(532, 86);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(149, 45);
            this.addToCartButton.TabIndex = 4;
            this.addToCartButton.Text = "Добави в количката";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // quantityAddTextBox
            // 
            this.quantityAddTextBox.Location = new System.Drawing.Point(581, 137);
            this.quantityAddTextBox.Name = "quantityAddTextBox";
            this.quantityAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityAddTextBox.TabIndex = 5;
            // 
            // quantityRemoveTextBox
            // 
            this.quantityRemoveTextBox.Location = new System.Drawing.Point(581, 294);
            this.quantityRemoveTextBox.Name = "quantityRemoveTextBox";
            this.quantityRemoveTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityRemoveTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество:";
            // 
            // removeFromCartButton
            // 
            this.removeFromCartButton.Location = new System.Drawing.Point(532, 244);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Size = new System.Drawing.Size(149, 44);
            this.removeFromCartButton.TabIndex = 8;
            this.removeFromCartButton.Text = "Премахни от количката";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromCartButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(697, 382);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 9;
            this.payButton.Text = "Плати";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Общо";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(752, 357);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 13);
            this.totalLabel.TabIndex = 11;
            // 
            // ClientShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 442);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.removeFromCartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityRemoveTextBox);
            this.Controls.Add(this.quantityAddTextBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartDataGridView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "ClientShopForm";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.ClientShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.TextBox quantityAddTextBox;
        private System.Windows.Forms.TextBox quantityRemoveTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeFromCartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceForEachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceForEachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalLabel;
    }
}