using System;
using System.Collections.Generic;
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

        #region Clients operations
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
                sql = $"INSERT INTO clients (Name, Balance) VALUES('{name}', {balance.ToString(CultureInfo.InvariantCulture)});";

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
                if (reader.HasRows)
                {
                    reader.Read();

                    client = new Client
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Name = reader.GetValue(1).ToString(),
                        Balance = decimal.Parse(reader.GetValue(2).ToString())
                    };

                    reader.Close();
                }

                command.Dispose();


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
        /// Вземи клиент по ID
        /// </summary>
        /// <param name="clientID">ID-то на клиента, който се търси</param>
        /// <returns>Клиента, ако не го намери връща <see cref="null"/></returns>
        public Client GetClientByID(int clientID)
        {
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";
            Client client = null;

            try
            {
                this.connection.Open();

                sql = $"SELECT * FROM clients WHERE ID = '{clientID}';";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                // Четем само първия намерен клиент с това име
                if (reader.HasRows)
                {
                    reader.Read();

                    client = new Client
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Name = reader.GetValue(1).ToString(),
                        Balance = decimal.Parse(reader.GetValue(2).ToString())
                    };

                    reader.Close();
                }

                command.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetClientByID)");
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
        public bool CheckIfClientExists(string name)
        {
            return this.GetClientByName(name) != null;
        }

        /// <summary>
        /// Изтрива клиент от базата данни
        /// </summary>
        /// <param name="clientID">ID на клиента</param>
        public void DeleteClient(int clientID)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();
                sql = $"DELETE clients WHERE ID = {clientID};";
                command = new SqlCommand(sql, this.connection);

                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> DeleteClient)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Промяна на клиент по ID
        /// </summary>
        /// <param name="clientID">ID на клиент</param>
        /// <param name="name">Новота стойност на име на клиента ако е null или празно не се променя</param>
        /// <param name="balance">Новата стойност на баланса на клиента, ако е под 0 не се променя</param>
        public void UpdateClient(int clientID, string name, decimal balance)
        {
            if (string.IsNullOrEmpty(name) && balance < 0)
            {
                throw new ArgumentNullException("name is null or empty or balance is lower than zero!");
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();
                sql = "UPDATE clients SET ";

                // Ако името е празно или null остава старото
                if (!string.IsNullOrEmpty(name))
                {
                    // Новата стойност на името
                    sql += $"Name = {name}";
                }

                // Ако баланса е по-малък от 0 остава старото
                if (balance >= 0)
                {
                    // Ако се променя и името се слага запетая щом ще се променя и баланса
                    if (!string.IsNullOrEmpty(name))
                    {
                        sql += ", ";
                    }

                    // Новата стойност на баланса
                    sql += $"Balance = {balance.ToString(CultureInfo.InvariantCulture)}";
                }

                // IDто на клиента, който ще се променя
                sql += $" WHERE ID = {clientID};";

                command = new SqlCommand(sql, this.connection);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> UpdateClient)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Всички клиенти от базата данни
        /// </summary>
        /// <returns>Списък от клиенти</returns>
        public List<Client> GetClients()
        {
            List<Client> clients = null;
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";

            try
            {
                this.connection.Open();

                sql = $"SELECT * FROM clients;";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    clients = new List<Client>();

                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ID = int.Parse(reader.GetValue(0).ToString()),
                            Name = reader.GetValue(1).ToString(),
                            Balance = decimal.Parse(reader.GetValue(2).ToString())
                        });
                    }

                    reader.Close();
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetClients)");
            }
            finally
            {
                this.connection.Close();
            }

            return clients;
        }

        #endregion

        #region Products operations

        /// <summary>
        /// Добавяне на продукт към базата данни
        /// </summary>
        /// <param name="name">Име на продукт</param>
        /// <param name="priceForEach">Цена за бройка</param>
        /// <param name="quantityInStock">Количество</param>
        public void AddProduct(string name, decimal priceForEach, int quantityInStock)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name is null or empty!");
            }

            if (priceForEach <= 0)
            {
                throw new ArgumentNullException("priceForEach cannot be lower than or 0!");
            }

            if (quantityInStock < 0)
            {
                throw new ArgumentNullException("quantity cannot be lower than 0!");
            }

            if (this.CheckIfProductExists(name))
            {
                throw new ArgumentException("Product with that name already exists!");
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();

                // Подсигоряваме се десетичния разделител да е с точка, не запетая
                sql = $"INSERT INTO products (Name, PriceForEach, QuantityInStock) VALUES('{name}', {priceForEach.ToString(CultureInfo.InvariantCulture)}, {quantityInStock});";

                command = new SqlCommand(sql, this.connection);

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> AddProduct)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Вземи продукт по име
        /// </summary>
        /// <param name="name">Името на продукт, който се търси</param>
        /// <returns>Продукта, ако не го намери връща <see cref="null"/></returns>
        public Product GetProductByName(string name)
        {
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";
            Product product = null;

            try
            {
                this.connection.Open();

                sql = $"SELECT * FROM products WHERE Name = '{name}';";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                // Четем само първия намерен продукт с това име
                if (reader.HasRows)
                {
                    reader.Read();

                    product = new Product
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Name = reader.GetValue(1).ToString(),
                        PriceForEach = decimal.Parse(reader.GetValue(2).ToString()),
                        QuantityInStock = int.Parse(reader.GetValue(3).ToString())
                    };

                    reader.Close();
                }

                command.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetProductByName)");
            }
            finally
            {
                this.connection.Close();
            }

            return product;
        }

        /// <summary>
        /// Вземи продукт по ID
        /// </summary>
        /// <param name="productID">ID-то на продукт, който се търси</param>
        /// <returns>Продукта, ако не го намери връща <see cref="null"/></returns>
        public Product GetProductByID(int productID)
        {
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";
            Product product = null;

            try
            {
                this.connection.Open();

                sql = $"SELECT * FROM products WHERE ID = '{productID}';";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                // Четем само първия намерен продукт с това име
                if (reader.HasRows)
                {
                    reader.Read();

                    product = new Product
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Name = reader.GetValue(1).ToString(),
                        PriceForEach = decimal.Parse(reader.GetValue(2).ToString()),
                        QuantityInStock = int.Parse(reader.GetValue(3).ToString())
                    };

                    reader.Close();
                }

                command.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetProductByID)");
            }
            finally
            {
                this.connection.Close();
            }

            return product;
        }


        /// <summary>
        /// Проверява дали продукта с подаденото име съществува
        /// </summary>
        /// <param name="name">Името на продукта, който се търси</param>
        /// <returns><see cref="true"/> ако продукта е съществува, <see cref="false"/> ако не съществува</returns>
        public bool CheckIfProductExists(string name)
        {
            return this.GetProductByName(name) != null;
        }

        /// <summary>
        /// Изтрива продукт от базата данни
        /// </summary>
        /// <param name="productID">ID на клиента</param>
        public void DeleteProduct(int productID)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();
                sql = $"DELETE products WHERE ID = {productID};";
                command = new SqlCommand(sql, this.connection);

                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> DeleteProduct)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Промяна на продукт по ID
        /// </summary>
        /// <param name="productID">ID на продукта</param>
        /// <param name="name">Новота стойност на име на продукта ако е null или празно не се променя</param>
        /// <param name="priceForEach">Новата стойност на цена за бройка на продукта, ако е под 0 не се променя</param>
        /// <param name="quantityInStock">Новата стойност на количеството на продукта, ако е под 0 не се променя</param>
        public void UpdateProduct(int productID, string name, decimal priceForEach, int quantityInStock)
        {
            if (string.IsNullOrEmpty(name) && priceForEach <= 0 && quantityInStock < 0)
            {
                throw new ArgumentNullException("name is null or empty or priceForEach is lower than or zero or quantityInStock is lower than zero!");
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();
                sql = "UPDATE products SET ";

                // Ако името е празно или null остава старото
                if (!string.IsNullOrEmpty(name))
                {
                    // Новата стойност на името
                    sql += $"Name = '{name}'";
                }

                // Ако цена за бройка е по-малък от 0 остава старото
                if (priceForEach >= 0)
                {
                    // Ако се променя и името се слага запетая щом ще се променя и бройката
                    if (!string.IsNullOrEmpty(name))
                    {
                        sql += ", ";
                    }

                    // Новата стойност на цена за бройка
                    sql += $"PriceForEach = {priceForEach.ToString(CultureInfo.InvariantCulture)}";
                }

                // Ако количеството е по-малъко от 0 остава старото
                if (quantityInStock > 0)
                {
                    // Ако се променя и името или количеството е по-голямо от 0 се слага запетая щом ще се променя и бройката
                    if (!string.IsNullOrEmpty(name) || priceForEach > 0)
                    {
                        sql += ", ";
                    }

                    // Новата стойност на цена за бройка
                    sql += $"QuantityInStock = {quantityInStock}";
                }

                // IDто на продукта, който ще се променя
                sql += $" WHERE ID = {productID};";

                command = new SqlCommand(sql, this.connection);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> UpdateProduct)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Всички продукти от базата данни
        /// </summary>
        /// <returns>Списък от продукти</returns>
        public List<Product> GetProducts()
        {
            List<Product> products = null;
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";

            try
            {
                this.connection.Open();

                sql = $"SELECT * FROM products;";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    products = new List<Product>();

                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ID = int.Parse(reader.GetValue(0).ToString()),
                            Name = reader.GetValue(1).ToString(),
                            PriceForEach = decimal.Parse(reader.GetValue(2).ToString()),
                            QuantityInStock = int.Parse(reader.GetValue(3).ToString())
                        });
                    }

                    reader.Close();
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetProducts)");
            }
            finally
            {
                this.connection.Close();
            }

            return products;
        }

        #endregion

        #region Sales operations

        public void MakeSale(int boughtProductID, int boughtQuantity, int clientBuyerID)
        {
            var client = this.GetClientByID(clientBuyerID);

            // Check if client does not exists
            if (client == null)
            {
                throw new ArgumentNullException($"Client with ID: {clientBuyerID} was not found!");
            }

            // Get bought product
            var product = this.GetProductByID(boughtProductID);

            // Check if product does not exists
            if (product == null)
            {
                throw new ArgumentNullException($"Product with ID: {boughtProductID} was not found!");
            }

            // Check if product has enough quantity
            if (product.QuantityInStock < boughtQuantity)
            {
                throw new ArgumentOutOfRangeException($"Not enough quantity in stock for product with ID {boughtProductID}!");
            }

            var saleAmount = product.PriceForEach * boughtQuantity;

            // Check if client has enough money
            if (saleAmount > client.Balance)
            {
                throw new ArgumentOutOfRangeException($"Client with ID {clientBuyerID} does not have enough money for this sale!");
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            try
            {
                this.connection.Open();

                sql = $"INSERT INTO sales (ClientID, BoughtProductID, BoughtQuantity) VALUES({clientBuyerID}, {boughtProductID}, {boughtQuantity});";

                command = new SqlCommand(sql, this.connection);

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                // Update quantity of product
                this.UpdateProduct(product.ID, product.Name, product.PriceForEach, product.QuantityInStock - boughtQuantity);

                // Update balance of client
                this.UpdateClient(client.ID, client.Name, client.Balance - saleAmount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> MakeSale)");
            }
            finally
            {
                this.connection.Close();
            }
        }

        #endregion

        #region Reports

        /// <summary>
        /// Взима оборота на магазина
        /// </summary>
        /// <returns>оборота на магазина</returns>
        public decimal GetTurnover()
        {
            decimal turnover = 0;
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";

            try
            {
                this.connection.Open();

                sql = $"SELECT SUM((products.PriceForEach * sales.BoughtQuantity)) FROM sales INNER JOIN products ON sales.BoughtProductID = products.ID;";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string result = reader.GetValue(0).ToString();
                    if (!string.IsNullOrEmpty(result))
                    {
                        turnover = decimal.Parse(result);
                    }

                    reader.Close();
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetTurnover)");
            }
            finally
            {
                this.connection.Close();
            }

            return turnover;
        }

        /// <summary>
        /// Взима бройката клиенти на магазина
        /// </summary>
        /// <returns>брой клиенти</returns>
        public int GetClientsCount()
        {
            int clientsCount = 0;
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";

            try
            {
                this.connection.Open();

                sql = $"SELECT COUNT(*) FROM clients;";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string result = reader.GetValue(0).ToString();
                    if (!string.IsNullOrEmpty(result))
                    {
                        clientsCount = int.Parse(result);
                    }

                    reader.Close();
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetClientsCount)");
            }
            finally
            {
                this.connection.Close();
            }

            return clientsCount;
        }

        /// <summary>
        /// Взима броя продажби на магазина
        /// </summary>
        /// <returns>брой продажби</returns>
        public int GetSalesCount()
        {
            int salesCount = 0;
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";

            try
            {
                this.connection.Open();

                sql = $"SELECT COUNT(*) FROM sales;";

                command = new SqlCommand(sql, this.connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string result = reader.GetValue(0).ToString();

                    if (!string.IsNullOrEmpty(result))
                    {
                        salesCount = int.Parse(result);
                    }

                    reader.Close();
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "(DBOperations -> GetSalesCount)");
            }
            finally
            {
                this.connection.Close();
            }

            return salesCount;
        }

        #endregion
    }
}
