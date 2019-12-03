using System;
using System.Windows.Forms;
using V.ShopWithInventory.Models;

namespace V.ShopWithInventory.UI
{
    public partial class ShopOwnerForm : Form
    {
        private BindingSource productsBindingSource;
        private readonly DBOperations dbo;
        private Product productForEdit;

        public ShopOwnerForm()
        {
            this.InitializeComponent();
            this.InitProductsDataGridView();
            this.dbo = new DBOperations();
        }

        // Инициализация на таблицата с продукти
        private void InitProductsDataGridView()
        {
            this.productsBindingSource = new BindingSource();
            this.productsBindingSource.DataSource = typeof(Product);
            this.productsDataGridView.DataSource = productsBindingSource;

        }

        private void ShopOwnerForm_Load(object sender, EventArgs e)
        {
            this.RefreshProducts();
        }

        // Обновяване на данните в таблицата
        private void RefreshProducts()
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

        // Добавяне на продукт в базата
        private void addProductButton_Click(object sender, EventArgs e)
        {
            decimal price = -1;
            int quantity = -1;
            string name = productNameTextBox.Text;

            if (dbo.CheckIfProductExists(name))
            {
                MessageBox.Show("Продукт с това име вече съществува!");
                return;
            }

            // Проверка за коректни данни за цена
            try
            {
                price = decimal.Parse(productPriceTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни за цена на продукт!");
                return;
            }


            // Проверка за коректни данни за количество
            try
            {
                quantity = int.Parse(productQuantityTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни за количество на продукт!");
                return;
            }

            dbo.AddProduct(name, price, quantity);
            this.productsBindingSource.Add(this.dbo.GetProductByName(name));
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == productsDataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == productsDataGridView.Columns["editDataGridViewButtonColumn"].Index)
            {
                this.productForEdit = (productsBindingSource[e.RowIndex] as Product);
                this.MakeEditMode();
            }

            //Check if click is on specific column 
            if (e.ColumnIndex == productsDataGridView.Columns["deleteDataGridViewButtonColumn"].Index)
            {
                var productForDeleteID = (productsBindingSource[e.RowIndex] as Product).ID;
                this.dbo.DeleteProduct(productForDeleteID);
                productsBindingSource.RemoveAt(e.RowIndex);
            }
        }

        private void MakeEditMode()
        {
            this.addProductButton.Visible = false;
            this.cancelButton.Visible = true;
            this.saveButton.Visible = true;
            this.productNameTextBox.Text = this.productForEdit.Name;
            this.productPriceTextBox.Text = this.productForEdit.PriceForEach.ToString();
            this.productQuantityTextBox.Text = this.productForEdit.QuantityInStock.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            decimal price = -1;
            int quantity = -1;
            string name = productNameTextBox.Text;

            if (dbo.CheckIfProductExists(name))
            {
                MessageBox.Show("Продукт с това име вече съществува!");
                return;
            }

            // Проверка за коректни данни за цена
            try
            {
                price = decimal.Parse(productPriceTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни за цена на продукт!");
                return;
            }


            // Проверка за коректни данни за количество
            try
            {
                quantity = int.Parse(productQuantityTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни за количество на продукт!");
                return;
            }

            dbo.UpdateProduct(this.productForEdit.ID, name, price, quantity);
            this.RefreshProducts();
            this.MakeAddMode();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.MakeAddMode();
        }

        private void MakeAddMode()
        {
            this.productForEdit = null;
            this.cancelButton.Visible = false;
            this.saveButton.Visible = false;
            this.productNameTextBox.Clear();
            this.productPriceTextBox.Clear();
            this.productQuantityTextBox.Clear();
            this.addProductButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
