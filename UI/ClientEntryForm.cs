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
        
        private void clientShopButton_Click(object sender, EventArgs e)
        {
            var clientName = clientNameTextBox.Text;
            var clientBalance = clientMoneyTextBox.Text;

            if (string.IsNullOrEmpty(clientName) || string.IsNullOrEmpty(clientBalance))
            {
                MessageBox.Show("Не сте въвели име на клиент или баланс на клиент!");
                return;
            }

            DBOperations dbo = new DBOperations();
            Client client = null;
            if (dbo.CheckIfClientExists(clientName))
            {
                client = dbo.GetClientByName(clientName);
                MessageBox.Show($"Добре дошъл, {client.Name} вашият настоящ баланс е {client.Balance}.");
            }
            else
            {
                dbo.AddClient(clientName, decimal.Parse(clientBalance));
                client = dbo.GetClientByName(clientName);
            }

            // Запазваме клиента в статична променлива
            SessionHelper.CurrentLoggedClient = client;

            ClientShopForm clientShopForm = new ClientShopForm();
            clientShopForm.Show();
        }
    }
}
