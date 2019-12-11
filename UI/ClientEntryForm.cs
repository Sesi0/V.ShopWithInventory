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
            decimal clientBalance = 0;

            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Не сте въвели име на клиент!");
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
                if (string.IsNullOrEmpty(clientMoneyTextBox.Text))
                {
                    MessageBox.Show($"Клиент с име {clientName} не е регистриран в системата. Моля въведете баланс и опитайте отново!");
                    clientMoneyTextBox.Visible = true;
                    balanceLabel.Visible = true;
                    return;
                }

                try
                {
                    clientBalance = decimal.Parse(clientMoneyTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невалидни данни за баланс!");
                    return;
                }

                if(clientBalance <= 0)
                {
                    MessageBox.Show("Моля, въведете полoжително число!");
                }

                dbo.AddClient(clientName, clientBalance);
                client = dbo.GetClientByName(clientName);
                clientMoneyTextBox.Visible = false;
                balanceLabel.Visible = false;
                clientMoneyTextBox.Clear();
            }

            // Запазваме клиента в статична променлива
            SessionHelper.CurrentLoggedClient = client;

            ClientShopForm clientShopForm = new ClientShopForm();
            clientShopForm.ShowDialog();
        }
    }
}
