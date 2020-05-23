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
    class CPU : Component
    {
        public int Cores { get; set; }

        public double CoreClock { get; set; }

        public double BoostClock { get; set; }

        public int TDP { get; set; }

        public string IntegratedGraphics { get; set; }

        // Adding to database
        public bool Insert(CPU ClassCPU) 
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);
            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO CPU (CPUId, Manufacturer, Name, Cores, CoreClock, BoostClock, TDP, IntegratedGraphics, Price) " +
                            "VALUES(@CPUId, @Manufacturer, @Name, @Cores, @CoreClock, @BoostClock, @TDP, @IntegratedGraphics, @Price)";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CPUId", ClassCPU.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassCPU.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassCPU.Name);
                cmd.Parameters.AddWithValue("@Cores", ClassCPU.Cores);
                cmd.Parameters.AddWithValue("@CoreClock", ClassCPU.CoreClock);
                cmd.Parameters.AddWithValue("@BoostClock", ClassCPU.BoostClock);
                cmd.Parameters.AddWithValue("@TDP", ClassCPU.TDP);
                cmd.Parameters.AddWithValue("@IntegratedGraphics", ClassCPU.IntegratedGraphics);
                cmd.Parameters.AddWithValue("@Price", ClassCPU.Price);

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
        public bool Update(CPU ClassCPU)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE CPU SET Manufacturer=@Manufacturer, Name=@Name, " +
                    "Cores=@Cores, CoreClock=@CoreClock, BoostClock=@BoostClock, " +
                    "TDP=@TDP, IntegratedGraphics=@IntegratedGraphics, Price=@Price WHERE CPUId=@CPUId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CPUId", ClassCPU.Id);
                cmd.Parameters.AddWithValue("@Manufacturer", ClassCPU.Manufacturer);
                cmd.Parameters.AddWithValue("@Name", ClassCPU.Name);
                cmd.Parameters.AddWithValue("@Cores", ClassCPU.Cores);
                cmd.Parameters.AddWithValue("@CoreClock", ClassCPU.CoreClock);
                cmd.Parameters.AddWithValue("@BoostClock", ClassCPU.BoostClock);
                cmd.Parameters.AddWithValue("@TDP", ClassCPU.TDP);
                cmd.Parameters.AddWithValue("@IntegratedGraphics", ClassCPU.IntegratedGraphics);
                cmd.Parameters.AddWithValue("@Price", ClassCPU.Price);

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

        public bool Delete(CPU ClassCPU)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = "DELETE FROM CPU WHERE CPUId=@CPUId";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CPUId", ClassCPU.Id);

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
