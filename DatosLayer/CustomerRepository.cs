using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer
{
    public class CustomerRepository
    {
        private const string BaseSelectQuery = @"
            SELECT [CustomerID], [CompanyName], [ContactName], 
                   [ContactTitle], [Address], [City], [Region], 
                   [PostalCode], [Country], [Phone], [Fax]
            FROM [dbo].[Customers]";

        public List<Customers> ObtenerTodos()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                using (SqlCommand comando = new SqlCommand(BaseSelectQuery, conexion))
                {
                    var reader = comando.ExecuteReader();
                    var customersList = new List<Customers>();

                    while (reader.Read())
                    {
                        customersList.Add(LeerDelDataReader(reader));
                    }

                    return customersList;
                }
            }
        }

        public Customers ObtenerPorID(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var selectForID = $"{BaseSelectQuery} WHERE [CustomerID] = @CustomerID";

                using (var comando = new SqlCommand(selectForID, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", id);

                    var reader = comando.ExecuteReader();
                    return reader.Read() ? LeerDelDataReader(reader) : null;
                }
            }
        }

        public Customers LeerDelDataReader(SqlDataReader reader)
        {
            return new Customers
            {
                CustomerID = reader["CustomerID"] as string ?? " ",
                CompanyName = reader["CompanyName"] as string ?? string.Empty,
                ContactName = reader["ContactName"] as string ?? string.Empty,
                ContactTitle = reader["ContactTitle"] as string ?? string.Empty,
                Address = reader["Address"] as string ?? string.Empty,
                City = reader["City"] as string ?? string.Empty,
                Region = reader["Region"] as string ?? string.Empty,
                PostalCode = reader["PostalCode"] as string ?? string.Empty,
                Country = reader["Country"] as string ?? string.Empty,
                Phone = reader["Phone"] as string ?? string.Empty,
                Fax = reader["Fax"] as string ?? string.Empty
            };
        }

        public int InsertarCliente(Customers customer)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var insertInto = @"
                    INSERT INTO [dbo].[Customers]
                        ([CustomerID], [CompanyName], [ContactName], 
                         [ContactTitle], [Address], [City])
                    VALUES 
                        (@CustomerID, @CompanyName, @ContactName, 
                         @ContactTitle, @Address, @City)";

                using (var comando = new SqlCommand(insertInto, conexion))
                {
                    return ConfigurarParametrosYActualizar(customer, comando);
                }
            }
        }

        public int ActualizarCliente(Customers customer)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var actualizarQuery = @"
                    UPDATE [dbo].[Customers]
                    SET [CompanyName] = @CompanyName, 
                        [ContactName] = @ContactName,
                        [ContactTitle] = @ContactTitle,
                        [Address] = @Address,
                        [City] = @City
                    WHERE [CustomerID] = @CustomerID";

                using (var comando = new SqlCommand(actualizarQuery, conexion))
                {
                    return ConfigurarParametrosYActualizar(customer, comando);
                }
            }
        }

        private int ConfigurarParametrosYActualizar(Customers customer, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
            comando.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
            comando.Parameters.AddWithValue("@ContactName", customer.ContactName);
            comando.Parameters.AddWithValue("@ContactTitle", customer.ContactTitle);
            comando.Parameters.AddWithValue("@Address", customer.Address);
            comando.Parameters.AddWithValue("@City", customer.City);

            return comando.ExecuteNonQuery();
        }

        public int EliminarCliente(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var eliminarCliente = "DELETE FROM [dbo].[Customers] WHERE [CustomerID] = @CustomerID";

                using (var comando = new SqlCommand(eliminarCliente, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", id);
                    return comando.ExecuteNonQuery();
                }
            }
        }
    }
}
