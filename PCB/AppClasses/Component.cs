using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB.AppClasses
{
    abstract class Component
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        public DataTable Select(string tableName)
        {
            // Db Connection 
            var connection = new SqlConnection(connectionString);
            var dataTable = new DataTable();

            try
            {
                // SQL Query
                var query = $"SELECT * FROM {tableName}";
                var cmd = new SqlCommand(query, connection);

                // Creating SQL Data Adapter using cmd
                var adapter = new SqlDataAdapter(cmd);
                connection.Open();

                // Filling the data table
                adapter.Fill(dataTable);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    }
}
