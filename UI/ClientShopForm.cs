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
            this.InitCartDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            var quantityAdd=0;
            //Проверка дали е въведено количество
            try
            {
                if (quantityAddTextBox == null)
                {
                    MessageBox.Show("Моля, въведете количество!");
                }
                else
                {
                    quantityAdd = int.Parse(quantityAddTextBox.Text);
                    
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


                    //Проверка дали избраното количество е по-малко от наличното          
                    var productToAdd = new Product { ID = selectedProduct.ID, Name = selectedProduct.Name, PriceForEach = selectedProduct.PriceForEach, QuantityInStock = quantityAdd };                  
                    if(quantityAdd > dbo.GetProductByID(productToAdd.ID).QuantityInStock)
                    {
                       MessageBox.Show("Избраните продукти превишават бройката на наличните в магазина. Моля изберете по-малко количество. ");
                    }
                    else
                    {
                        this.cartBindingSource.Add(productToAdd);
                    }
                    
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля, въведете стойност!");
            }
        }


        private void removeFromCartButton_Click(object sender, EventArgs e)
        {
            //Изтриване на избран от количката продукт по ред
            try
            {
                var a = cartDataGridView.SelectedRows[0];
                cartDataGridView.Rows.RemoveAt(a.Index);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Моля, изберете ред за триене.");
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
           /* var clientBalance = dbo.GetClientByID();
            if()
            {

            }*/
            // TODO: Провеери дали клиента има достатъчно пари


        }

        
    }
}
