using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PCB.AppClasses
{
    class Setup
    {
        public string CPU { get; set; }

        public string Motherboard { get; set; }

        public string VideoCard { get; set; }

        public string PSU { get; set; }

        public string RAM { get; set; }

        public string HDD { get; set; }

        public string SSD { get; set; }

        public string Cooler { get; set; }

        public decimal Price { get; set; }

        public static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        public DataTable Select()
        {
            // Db Connection 
            var connection = new SqlConnection(connectionString);
            var dataTable = new DataTable();

            try
            {
                // SQL Query
                var query = $"SELECT * FROM Setup";
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

        public bool Insert(Setup ClassSetup)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO Setup (CPU, Motherboard, VideoCard, PSU, RAM, HDD, SSD, Cooler, Price) " +
                            "VALUES(@CPU, @Motherboard, @VideoCard, @PSU, @RAM, @HDD, @SSD, @Cooler, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CPU", ClassSetup.CPU);
                cmd.Parameters.AddWithValue("@Motherboard", ClassSetup.Motherboard);
                cmd.Parameters.AddWithValue("@VideoCard", ClassSetup.VideoCard);
                cmd.Parameters.AddWithValue("@PSU", ClassSetup.PSU);
                cmd.Parameters.AddWithValue("@RAM", ClassSetup.RAM);
                cmd.Parameters.AddWithValue("@HDD", ClassSetup.HDD);
                cmd.Parameters.AddWithValue("@SSD", ClassSetup.SSD);
                cmd.Parameters.AddWithValue("@Cooler", ClassSetup.Cooler);
                cmd.Parameters.AddWithValue("@Price", ClassSetup.Price);

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

        public bool Delete(int setupId)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM Setup WHERE SetupId=@SetupId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@SetupId", setupId);

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
