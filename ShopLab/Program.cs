using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopLab
{
    class Program
    {
        private static string _connectionString = @"Server=.\SQLEXPRESS;Database=Shop;Trusted_Connection=True;";
        static void Main(string [] args)
        {
            string command = args[0];

            if (command == "delete")
            {
                List<Order> orders = ReadOrder();
                foreach (Order order in orders)
                {
                    Console.WriteLine(order.ProductName, order.Price);
                }
            }
            else if (command == "insert")
            {
                int createdOrderId = InsertOrder( 1, "ProductName", 100 );
                Console.WriteLine("Created order: " + createdOrderId);
            }
            else if (command == "update")
            {
                UpdateOrder(1, "UPDATED ProductName");
            }
        }

        private static List<Order> ReadOrder()
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [OrderId],
                            [ProductName],
                            [Price],
                            [CustomerId]
                        FROM Order";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var order = new Order
                            {
                                OrderId = Convert.ToInt32(reader["OrderId"]),
                                ProductName = Convert.ToString(reader["ProductName"]),
                                Price = Convert.ToInt32(reader["Price"]),
                                CustomerId = Convert.ToInt32(reader["CustomerId"])
                            };
                            orders.Add(order);
                        }
                    }
                }
            }
            return orders;
        }

        private static int InsertOrder( int customerId, string productName, int price )
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = @"
                    INSERT INTO [Order]
                       (
                        [ProductName],
                        [Price],
                        [CustomerId])
                    VALUES 
                       (
                        @ProductName,
                        @Price,
                        @CustomerId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productName;
                    cmd.Parameters.Add("@Price", SqlDbType.Int).Value = price;
                    cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private static void UpdateOrder(int orderId, string productName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        UPDATE [Order]
                        SET [ProductName] = @ProductName
                        WHERE OrderId = @OrderId";

                    command.Parameters.Add("@OrderId", SqlDbType.BigInt).Value = orderId;
                    command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productName;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
