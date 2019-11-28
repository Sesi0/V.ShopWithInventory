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
                    sql += $"Balance = {balance}";
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
                    reader.Read();

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
                MessageBox.Show(ex.Message + "(DBOperations -> GetClientByName)");
            }
            finally
            {
                this.connection.Close();
            }

            return clients;
        }

    }
}
