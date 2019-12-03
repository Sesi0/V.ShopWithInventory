using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V.ShopWithInventory.UI
{
    public partial class ClientEntryForm : Form
    {
        public ClientEntryForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void clientShopButton_Click_1(object sender, EventArgs e)
        {
            ClientShopForm clientShopForm = new ClientShopForm();
            clientShopForm.Show();
        }
    }
}
