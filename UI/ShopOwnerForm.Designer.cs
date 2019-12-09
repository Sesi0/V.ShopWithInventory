namespace V.ShopWithInventory.UI
{
    partial class ShopOwnerForm
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.editDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addProductButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.turnOverLabel = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceForEachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(12, 26);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име на продукт";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(141, 26);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.productPriceTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена на продукта:";
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(269, 26);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оборот:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Клиенти:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Продажби:";
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
            this.quantityInStockDataGridViewTextBoxColumn,
            this.editDataGridViewButtonColumn,
            this.deleteDataGridViewButtonColumn});
            this.productsDataGridView.DataSource = this.productBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 65);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(745, 285);
            this.productsDataGridView.TabIndex = 10;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // editDataGridViewButtonColumn
            // 
            this.editDataGridViewButtonColumn.HeaderText = "Редакция";
            this.editDataGridViewButtonColumn.Name = "editDataGridViewButtonColumn";
            this.editDataGridViewButtonColumn.ReadOnly = true;
            this.editDataGridViewButtonColumn.Text = "Редакция";
            this.editDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteDataGridViewButtonColumn
            // 
            this.deleteDataGridViewButtonColumn.HeaderText = "Изтриване";
            this.deleteDataGridViewButtonColumn.Name = "deleteDataGridViewButtonColumn";
            this.deleteDataGridViewButtonColumn.ReadOnly = true;
            this.deleteDataGridViewButtonColumn.Text = "Изтриване";
            this.deleteDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(375, 23);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 11;
            this.addProductButton.Text = "Добави";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(457, 23);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(538, 23);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Откажи";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 469);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // turnOverLabel
            // 
            this.turnOverLabel.AutoSize = true;
            this.turnOverLabel.Location = new System.Drawing.Point(77, 363);
            this.turnOverLabel.Name = "turnOverLabel";
            this.turnOverLabel.Size = new System.Drawing.Size(0, 13);
            this.turnOverLabel.TabIndex = 15;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(V.ShopWithInventory.Models.Product);
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(77, 390);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(0, 13);
            this.clientsLabel.TabIndex = 16;
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(77, 418);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(0, 13);
            this.salesLabel.TabIndex = 17;
            // 
            // ShopOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 508);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.turnOverLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameTextBox);
            this.Name = "ShopOwnerForm";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.ShopOwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceForEachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editDataGridViewButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteDataGridViewButtonColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label turnOverLabel;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Label salesLabel;
    }
}