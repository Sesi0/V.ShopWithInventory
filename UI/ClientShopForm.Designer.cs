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
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceForEachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceForEachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(929, 427);
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
            this.label1.Location = new System.Drawing.Point(466, 137);
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
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceForEachDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productBindingSource1;
            this.productsDataGridView.Location = new System.Drawing.Point(23, 84);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(437, 251);
            this.productsDataGridView.TabIndex = 2;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(V.ShopWithInventory.Models.Product);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceForEachDataGridViewTextBoxColumn
            // 
            this.priceForEachDataGridViewTextBoxColumn.DataPropertyName = "PriceForEach";
            this.priceForEachDataGridViewTextBoxColumn.HeaderText = "PriceForEach";
            this.priceForEachDataGridViewTextBoxColumn.Name = "priceForEachDataGridViewTextBoxColumn";
            this.priceForEachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AutoGenerateColumns = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.priceForEachDataGridViewTextBoxColumn1,
            this.quantityInStockDataGridViewTextBoxColumn1});
            this.cartDataGridView.DataSource = this.productBindingSource2;
            this.cartDataGridView.Location = new System.Drawing.Point(661, 84);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.Size = new System.Drawing.Size(442, 251);
            this.cartDataGridView.TabIndex = 3;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(V.ShopWithInventory.Models.Product);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceForEachDataGridViewTextBoxColumn1
            // 
            this.priceForEachDataGridViewTextBoxColumn1.DataPropertyName = "PriceForEach";
            this.priceForEachDataGridViewTextBoxColumn1.HeaderText = "PriceForEach";
            this.priceForEachDataGridViewTextBoxColumn1.Name = "priceForEachDataGridViewTextBoxColumn1";
            this.priceForEachDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityInStockDataGridViewTextBoxColumn1
            // 
            this.quantityInStockDataGridViewTextBoxColumn1.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn1.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn1.Name = "quantityInStockDataGridViewTextBoxColumn1";
            this.quantityInStockDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(479, 86);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(149, 45);
            this.addToCartButton.TabIndex = 4;
            this.addToCartButton.Text = "Добави в количката";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(541, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Премахни от количката";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartDataGridView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "ClientShopForm";
            this.Text = "Магазин";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceForEachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceForEachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}