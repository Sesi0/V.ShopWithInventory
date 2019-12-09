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

        public ClientShopForm()
        {
            this.InitializeComponent();
            this.dbo = new DBOperations();
            this.InitProductsDataGridView();
            this.InitProductsDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeFromCartButton_Click(object sender, EventArgs e)
        {

        }

        private void ClientShopForm_Load(object sender, EventArgs e)
        {
            this.RefreshProductsTable();
        }

        // Инициализация на таблицата с продукти
        private void InitProductsDataGridView()
        {
            this.productsBindingSource = new BindingSource();
            this.productsBindingSource.DataSource = typeof(Product);
            this.productsDataGridView.DataSource = productsBindingSource;
        }

        // Инициализация на таблицата количка
        private void InitCartDataGridView()
        {
            this.productsBindingSource = new BindingSource();
            this.productsBindingSource.DataSource = typeof(Product);
            this.productsDataGridView.DataSource = productsBindingSource;
        }

        private void RefreshProductsTable()
        {
            var products = this.dbo.GetProducts();

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
    }
}
