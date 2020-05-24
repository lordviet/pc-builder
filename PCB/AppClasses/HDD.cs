using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB.AppClasses
{
    class HDD : Component
    {
        public int CapacityGB { get; set; }

        public int CacheMb { get; set; }

        public string Interface { get; set; }

        // Adding to database
        public bool Insert(HDD ClassHDD)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO HDD (HDDId, Manufacturer, Name, CapacityGB, CacheMb, Interface, Price) " +
                            "VALUES(@HDDId, @Manufacturer, @Name, @CapacityGB, @CacheMb, @Interface, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@HDDId", ClassHDD.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassHDD.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassHDD.Name);
                cmd.Parameters.AddWithValue("@CapacityGB", ClassHDD.CapacityGB);
                cmd.Parameters.AddWithValue("@CacheMb", ClassHDD.CacheMb);
                cmd.Parameters.AddWithValue("@Interface", ClassHDD.Interface);
                cmd.Parameters.AddWithValue("@Price", ClassHDD.Price);

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
        public bool Update(HDD ClassHDD)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE HDD SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "CapacityGB=@CapacityGB, CacheMb=@CacheMb, Interface=@Interface, " +
                    "Price=@Price WHERE HDDId=@HDDId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@HDDId", ClassHDD.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassHDD.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassHDD.Name);
                cmd.Parameters.AddWithValue("@CapacityGB", ClassHDD.CapacityGB);
                cmd.Parameters.AddWithValue("@CacheMb", ClassHDD.CacheMb);
                cmd.Parameters.AddWithValue("@Interface", ClassHDD.Interface);
                cmd.Parameters.AddWithValue("@Price", ClassHDD.Price);

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

        public bool Delete(HDD ClassHDD)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM HDD WHERE HDDId=@HDDId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@HDDId", ClassHDD.Id);

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