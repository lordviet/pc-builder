using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB.AppClasses
{
    class SSD : Component
    {
        public int CapacityGB { get; set; }

        public int CacheMb { get; set; }

        public string Interface { get; set; }

        // Adding to database
        public bool Insert(SSD ClassSSD)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO SSD (SSDId, Manufacturer, Name, CapacityGB, CacheMb, Interface, Price) " +
                            "VALUES(@SSDId, @Manufacturer, @Name, @CapacityGB, @CacheMb, @Interface, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@SSDId", ClassSSD.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassSSD.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassSSD.Name);
                cmd.Parameters.AddWithValue("@CapacityGB", ClassSSD.CapacityGB);
                cmd.Parameters.AddWithValue("@CacheMb", ClassSSD.CacheMb);
                cmd.Parameters.AddWithValue("@Interface", ClassSSD.Interface);
                cmd.Parameters.AddWithValue("@Price", ClassSSD.Price);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0 ? true : false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }

        // Updating the database
        public bool Update(SSD ClassSSD)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE SSD SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "CapacityGB=@CapacityGB, CacheMb=@CacheMb, Interface=@Interface, " +
                    "Price=@Price WHERE SSDId=@SSDId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@SSDId", ClassSSD.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassSSD.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassSSD.Name);
                cmd.Parameters.AddWithValue("@CapacityGB", ClassSSD.CapacityGB);
                cmd.Parameters.AddWithValue("@CacheMb", ClassSSD.CacheMb);
                cmd.Parameters.AddWithValue("@Interface", ClassSSD.Interface);
                cmd.Parameters.AddWithValue("@Price", ClassSSD.Price);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0 ? true : false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;

        }

        public bool Delete(SSD ClassSSD)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM SSD WHERE SSDId=@SSDId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@SSDId", ClassSSD.Id);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0 ? true : false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }
    }
}