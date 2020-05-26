using System.Data.SqlClient;

namespace PCB.AppClasses
{
    class PSU : Component
    {
        public int Wattage { get; set; }

        // Adding to database
        public bool Insert(PSU ClassPSU)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO PSU (PSUId, Manufacturer, Name, Wattage, Price) " +
                            "VALUES(@PSUId, @Manufacturer, @Name, @Wattage, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PSUId", ClassPSU.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassPSU.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassPSU.Name);
                cmd.Parameters.AddWithValue("@Wattage", ClassPSU.Wattage);
                cmd.Parameters.AddWithValue("@Price", ClassPSU.Price);

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
        public bool Update(PSU ClassPSU)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE PSU SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "Wattage=@Wattage, Price=@Price WHERE CoolerId=@CoolerId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PSUId", ClassPSU.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassPSU.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassPSU.Name);
                cmd.Parameters.AddWithValue("@Wattage", ClassPSU.Wattage);
                cmd.Parameters.AddWithValue("@Price", ClassPSU.Price);

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

        public bool Delete(PSU ClassPSU)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM PSU WHERE PSUId=@PSUId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PSUId", ClassPSU.Id);

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