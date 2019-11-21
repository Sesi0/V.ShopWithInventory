using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V.ShopWithInventory
{
    public class DBOperations
    {
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ShopWithInventory;User ID=bobiteo;Password=bobiteo;MultipleActiveResultSets=true;Connection Timeout=10;";

        public DBOperations()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

        }
    }
}
