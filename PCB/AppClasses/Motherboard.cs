using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB.AppClasses
{
    class Motherboard : Component
    {
        public string SocketCPU { get; set; }

        public string FormFactor { get; set; }

        public int MemoryMax { get; set; }

        public int MemorySlots { get; set; }

        // Adding to database
        public bool Insert(Motherboard ClassMotherboard)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO Motherboard (MotherboardId, Manufacturer, Name, SocketCPU, FormFactor, MemoryMax, MemorySlots, Price) " +
                            "VALUES(@MotherboardId, @Manufacturer, @Name, @SocketCPU, @FormFactor, @MemoryMax, @MemorySlots, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@MotherboardId", ClassMotherboard.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassMotherboard.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassMotherboard.Name);
                cmd.Parameters.AddWithValue("@SocketCPU", ClassMotherboard.SocketCPU);
                cmd.Parameters.AddWithValue("@FormFactor", ClassMotherboard.FormFactor);
                cmd.Parameters.AddWithValue("@MemoryMax", ClassMotherboard.MemoryMax);
                cmd.Parameters.AddWithValue("@MemorySlots", ClassMotherboard.MemorySlots);
                cmd.Parameters.AddWithValue("@Price", ClassMotherboard.Price);

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
        public bool Update(Motherboard ClassMotherboard)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE Motherboard SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "SocketCPU=@SocketCPU, FormFactor=@FormFactor, MemoryMax=@MemoryMax, " +
                    "MemorySlots=@MemorySlots, Price=@Price WHERE MotherboardId=@MotherboardId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@MotherboardId", ClassMotherboard.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassMotherboard.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassMotherboard.Name);
                cmd.Parameters.AddWithValue("@SocketCPU", ClassMotherboard.SocketCPU);
                cmd.Parameters.AddWithValue("@FormFactor", ClassMotherboard.FormFactor);
                cmd.Parameters.AddWithValue("@MemoryMax", ClassMotherboard.MemoryMax);
                cmd.Parameters.AddWithValue("@MemorySlots", ClassMotherboard.MemorySlots);
                cmd.Parameters.AddWithValue("@Price", ClassMotherboard.Price);

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

        public bool Delete(Motherboard ClassMotherboard)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM Motherboard WHERE MotherboardId=@MotherboardId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@MotherboardId", ClassMotherboard.Id);

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