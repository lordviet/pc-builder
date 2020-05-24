using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB.AppClasses
{
    class RAM : Component
    {
        public string Speed { get; set; }

        public int Size { get; set; }

        // Adding to database
        public bool Insert(RAM ClassRAM)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO RAM (RAMId, Manufacturer, Name, Speed, Size, Price) " +
                            "VALUES(@RAMId, @Manufacturer, @Name, @Speed, @Size, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@RAMId", ClassRAM.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassRAM.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassRAM.Name);
                cmd.Parameters.AddWithValue("@Speed", ClassRAM.Speed);
                cmd.Parameters.AddWithValue("@Size", ClassRAM.Size);
                cmd.Parameters.AddWithValue("@Price", ClassRAM.Price);

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
        public bool Update(RAM ClassRAM)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE RAM SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "Speed=@Speed, Size=@Size, Price=@Price WHERE RAMId=@RAMId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@RAMId", ClassRAM.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassRAM.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassRAM.Name);
                cmd.Parameters.AddWithValue("@Speed", ClassRAM.Speed);
                cmd.Parameters.AddWithValue("@Size", ClassRAM.Size);
                cmd.Parameters.AddWithValue("@Price", ClassRAM.Price);

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

        public bool Delete(RAM ClassRAM)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM RAM WHERE RAMId=@RAMId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@RAMId", ClassRAM.Id);

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