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
    public partial class MainForm : Form
    {
        private DBOperations dbOperations;

        public MainForm()
        {
            this.InitializeComponent();
            this.dbOperations = new DBOperations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dbOperations.AddClient("Малин", 154.45M);
        }
    }
}
