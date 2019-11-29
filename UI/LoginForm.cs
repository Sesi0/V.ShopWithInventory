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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutInfoForm aboutinfoForm = new AboutInfoForm();
            aboutinfoForm.Show();
        }

        private void clientLoginButton_Click(object sender, EventArgs e)
        {
            //clientDetails client_details = new clientDetails();
            //client_details.Show();
        }

        private void ownerLoginButton_Click(object sender, EventArgs e)
        {
            ShopOwnerForm shopOwnerForm = new ShopOwnerForm();
            shopOwnerForm.Show();
        }
    }
}
