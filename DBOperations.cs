using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using V.ShopWithInventory.Models;

namespace V.ShopWithInventory
{
    public class DBOperations
    {
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ShopWithInventory;User ID=bobiteo;Password=bobiteo;MultipleActiveResultSets=true;Connection Timeout=10;";

        private readonly SqlConnection connection;

        public DBOperations()
        {
            this.connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Добавяне на клиент към базата данни
        /// </summary>
        /// <param name="name">Име на клиент</param>
        /// <param name="balance">Баланс на клиент</param>
        public void AddClient(string name, decimal balance)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name is null or empty!");
            }

            if (this.CheckIfClientExists(name))
            {
                throw new ArgumentException("Client with that name already exists!");
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();

                
                // Подсигоряваме се десетичния разделител да е с точка, не запетая
                sql = $"INSERT INTO clients (Name, Balance) VALUES('{name}', '{balance.ToString("N2", CultureInfo.InvariantCulture)}');";

                command = new SqlCommand(sql, this.connection);

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> AddClient)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Вземи клиент по име
        /// </summary>
        /// <param name="name">Името на клиента, който се търси</param>
        /// <returns>Клиента, ако не го намери връща <see cref="null"/></returns>
        public Client GetClientByName(string name)
        {
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";
            Client client = null;

            try
            {
                this.connection.Open();

                sql = $"SELECT * FROM clients WHERE Name = '{name}';";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                // Четем само първия намерен клиент с това име
                reader.Read();
                if (reader.HasRows)
                {
                    client = new Client
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Name = reader.GetValue(1).ToString(),
                        Balance = decimal.Parse(reader.GetValue(2).ToString())
                    };
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetClientByName)");
            }
            finally
            {
                this.connection.Close();
            }

            return client;
        }

        /// <summary>
        /// Проверява дали клиента с подаденото име съществува
        /// </summary>
        /// <param name="name">Името на клиента, който се търси</param>
        /// <returns><see cref="true"/> ако клиента е съществува, <see cref="false"/> ако не съществува</returns>
        private bool CheckIfClientExists(string name)
        {
            return this.GetClientByName(name) != null;
        }
    }
}
