using System.Data.SqlClient;

namespace PCB.AppClasses
{
    class Cooler : Component
    {
        public int FanRPM { get; set; }

        public int NoiseLevelDb { get; set; }

        // Adding to database
        public bool Insert(Cooler ClassCooler)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO Cooler (CoolerId, Manufacturer, Name, FanRPM, NoiseLevelDb, Price) " +
                            "VALUES(@CoolerId, @Manufacturer, @Name, @FanRPM, @NoiseLevelDb, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CoolerId", ClassCooler.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassCooler.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassCooler.Name);
                cmd.Parameters.AddWithValue("@FanRPM", ClassCooler.FanRPM);
                cmd.Parameters.AddWithValue("@NoiseLevelDb", ClassCooler.NoiseLevelDb);
                cmd.Parameters.AddWithValue("@Price", ClassCooler.Price);

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
        public bool Update(Cooler ClassCooler)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE Cooler SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "FanRPM=@FanRPM, NoiseLevelDb=@NoiseLevelDb, Price=@Price WHERE CoolerId=@CoolerId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CoolerId", ClassCooler.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassCooler.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassCooler.Name);
                cmd.Parameters.AddWithValue("@FanRPM", ClassCooler.FanRPM);
                cmd.Parameters.AddWithValue("@NoiseLevelDb", ClassCooler.NoiseLevelDb);
                cmd.Parameters.AddWithValue("@Price", ClassCooler.Price);

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

        public bool Delete(Cooler ClassCooler)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM Cooler WHERE CoolerId=@CoolerId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CoolerId", ClassCooler.Id);

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