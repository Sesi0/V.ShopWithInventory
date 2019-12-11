using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V.ShopWithInventory.Models;

namespace V.ShopWithInventory.UI
{
    public partial class ClientShopForm : Form
    {
        private readonly DBOperations dbo;

        private BindingSource productsBindingSource;
        private BindingSource cartBindingSource;

        private decimal totalAmount;

        public ClientShopForm()
        {
            this.InitializeComponent();
            this.dbo = new DBOperations();
            this.InitProductsDataGridView();
            this.InitCartDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Изчистваме клиента
            SessionHelper.CurrentLoggedClient = null;
            this.Close();
        }

        private void ClientShopForm_Load(object sender, EventArgs e)
        {
            this.RefreshProductsTable();
            this.LoadClientInfo();
        }

        private void LoadClientInfo()
        {
            clientNameLabel.Text = SessionHelper.CurrentLoggedClient.Name;
            clientBalanceLabel.Text = SessionHelper.CurrentLoggedClient.Balance.ToString();
        }

        // Инициализация на таблицата с продукти
        private void InitProductsDataGridView()
        {
            this.productsBindingSource = new BindingSource();
            this.productsBindingSource.DataSource = typeof(Product);
            this.productsDataGridView.DataSource = productsBindingSource;
            this.productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.MultiSelect = false;
        }

        // Инициализация на таблицата количка
        private void InitCartDataGridView()
        {
            this.cartBindingSource = new BindingSource();
            this.cartBindingSource.DataSource = typeof(Product);
            this.cartDataGridView.DataSource = cartBindingSource;
            this.cartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGridView.MultiSelect = false;
        }

        private void RefreshProductsTable()
        {
            var products = this.dbo.GetProductsForSale();

            if (products == null)
            {
                return;
            }

            this.productsBindingSource.Clear();

            foreach (var product in products)
            {
                this.productsBindingSource.Add(product);
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            int quantityAdd = 0;

            try
            {
                quantityAdd = int.Parse(quantityAddTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидно количество, моля проверете и опитайте пак!");
                return;
            }

            var selectedProduct = (Product)this.productsBindingSource[this.productsDataGridView.CurrentCell.RowIndex];

            if (selectedProduct == null)
            {
                MessageBox.Show("Моля, изберете продукт!");
                return;
            }

            if (cartBindingSource.List.Count > 0 && (cartBindingSource.List as ICollection<Product>).Any(p => p.ID == selectedProduct.ID))
            {
                MessageBox.Show("Избраният продукт е вече добавен.");
                return;
            }

            if (quantityAdd <= 0)
            {
                MessageBox.Show("Въведете положително число.");
                return;
            }

            //Проверка дали избраното количество е по-малко от наличното          
            var productToAdd = new Product { ID = selectedProduct.ID, Name = selectedProduct.Name, PriceForEach = selectedProduct.PriceForEach, QuantityInStock = quantityAdd };
            if (quantityAdd > dbo.GetProductByID(productToAdd.ID).QuantityInStock)
            {
                MessageBox.Show("Избраните продукти превишават бройката на наличните в магазина. Моля изберете по-малко количество. ");
                return;
            }

            this.cartBindingSource.Add(productToAdd);
            this.RefreshTotalAmount();
        }

        private void RefreshTotalAmount()
        {
            if (cartBindingSource.List.Count > 0)
            {
                this.totalAmount = (cartBindingSource.List as ICollection<Product>).Sum(p => p.PriceForEach * p.QuantityInStock);
            }
            else
            {
                totalAmount = 0;
            }

            totalLabel.Text = totalAmount.ToString();
        }

        private void removeFromCartButton_Click(object sender, EventArgs e)
        {
            //Изтриване на избран от количката продукт по ред
            try
            {
                var deleteSelectedRowbyItem = cartDataGridView.SelectedRows[0];
                cartDataGridView.Rows.RemoveAt(deleteSelectedRowbyItem.Index);
                this.RefreshTotalAmount();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Моля, изберете ред за триене.");
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (cartBindingSource.List.Count <= 0)
            {
                MessageBox.Show("Количката е празна.");
                return;
            }

            if (totalAmount > SessionHelper.CurrentLoggedClient.Balance)
            {
                MessageBox.Show("Нямате достатъчно пари. Моля, изберете по-малко продукти.");
                return;
            }

            foreach (var product in cartBindingSource.List as ICollection<Product>)
            {
                dbo.MakeSale(product.ID, product.QuantityInStock, SessionHelper.CurrentLoggedClient.ID);
            }

            cartBindingSource.Clear();
            this.RefreshTotalAmount();
            SessionHelper.RefreshCurrentLoggedClient();
            this.LoadClientInfo();
            this.RefreshProductsTable();
        }
    }
}
