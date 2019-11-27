using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V.ShopWithInventory
{
    public partial class clientDetails : Form
    {
        public clientDetails()
        {
            InitializeComponent();
        }

        private void backToLoginFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueToShopClientView_Click(object sender, EventArgs e)
        {
            ShopClientView shop_client_view = new ShopClientView();
            shop_client_view.Show();
        }
    }
}
