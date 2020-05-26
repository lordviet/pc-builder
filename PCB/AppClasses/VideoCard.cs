using System.Data.SqlClient;

namespace PCB.AppClasses
{
    class VideoCard : Component
    {
        public int Memory { get; set; }

        public int CoreClockMhz { get; set; }

        public int BoostClockMhz { get; set; }

        // Adding to database
        public bool Insert(VideoCard ClassVideoCard)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO VideoCard (VideoCardId, Manufacturer, Name, Memory, CoreClockMhz, BoostClockMhz, Price) " +
                            "VALUES(@VideoCardId, @Manufacturer, @Name, @Memory, @CoreClockMhz, @BoostClockMhz, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@VideoCardId", ClassVideoCard.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassVideoCard.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassVideoCard.Name);
                cmd.Parameters.AddWithValue("@Memory", ClassVideoCard.Memory);
                cmd.Parameters.AddWithValue("@CoreClockMhz", ClassVideoCard.CoreClockMhz);
                cmd.Parameters.AddWithValue("@BoostClockMhz", ClassVideoCard.BoostClockMhz);
                cmd.Parameters.AddWithValue("@Price", ClassVideoCard.Price);

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
        public bool Update(VideoCard ClassVideoCard)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE VideoCard SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "Memory=@Memory, CoreClockMhz=@CoreClockMhz, BoostClockMhz=@BoostClockMhz, " +
                    "Price=@Price WHERE VideoCardId=@VideoCardId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@VideoCardId", ClassVideoCard.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassVideoCard.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassVideoCard.Name);
                cmd.Parameters.AddWithValue("@Memory", ClassVideoCard.Memory);
                cmd.Parameters.AddWithValue("@CoreClockMhz", ClassVideoCard.CoreClockMhz);
                cmd.Parameters.AddWithValue("@BoostClockMhz", ClassVideoCard.BoostClockMhz);
                cmd.Parameters.AddWithValue("@Price", ClassVideoCard.Price);

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

        public bool Delete(VideoCard ClassVideoCard)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM VideoCard WHERE VideoCardId=@VideoCardId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@VideoCardId", ClassVideoCard.Id);

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