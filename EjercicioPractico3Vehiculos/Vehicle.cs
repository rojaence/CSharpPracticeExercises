using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EjercicioPractico3Vehiculos
{
    public class Vehicle
    {
        public static SqlCommand queryCommand = new SqlCommand();

        public int VehicleId { get; set; }
        public int BrandId { get; set; }
        public int CountryId { get; set; }
        public int VehicleTypeId { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public double Price { get; set; }

        public Vehicle() { }

        public Vehicle(int vehicleId, int brandId, int countryId, int vehicleTypeId, string modelName, int modelYear, double price)
        {
            VehicleId = vehicleId;
            BrandId = brandId;
            CountryId = countryId;
            VehicleTypeId = vehicleTypeId;
            ModelName = modelName;
            ModelYear = modelYear;
            Price = price;
        }
        
        public void CreateVehicle()
        {
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "AddVehicle";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@brandId", BrandId);
            queryCommand.Parameters.AddWithValue("@countryId", CountryId);
            queryCommand.Parameters.AddWithValue("@vehicleTypeId", VehicleTypeId);
            queryCommand.Parameters.AddWithValue("@modelName", ModelName);
            queryCommand.Parameters.AddWithValue("@modelYear", ModelYear);
            queryCommand.Parameters.AddWithValue("@price", Price);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
        }

        public void UpdateVehicle() {
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "UpdateVehicle";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@vehicleId", VehicleId);
            queryCommand.Parameters.AddWithValue("@brandId", BrandId);
            queryCommand.Parameters.AddWithValue("@countryId", CountryId);
            queryCommand.Parameters.AddWithValue("@vehicleTypeId", VehicleTypeId);
            queryCommand.Parameters.AddWithValue("@modelName", ModelName);
            queryCommand.Parameters.AddWithValue("@modelYear", ModelYear);
            queryCommand.Parameters.AddWithValue("@price", Price);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
        }    

        public void DeleteVehicle()
        {
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "DeleteVehicle";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@vehicleId", VehicleId);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
        }

        public static DataTable GetVehicles(string param)
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "GetVehicles";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@param", param);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            return data;
        }

        public static Boolean VehicleExists(string modelName, Boolean update, int id)
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = $"SELECT TOP 1 * FROM Vehicle WHERE LOWER(modelName) = '{modelName.ToLower()}' ORDER BY vehicleId DESC";
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            if (data.Rows.Count > 0)
            {
                if (update)
                {
                    return data.Rows[0].Field<int>("vehicleId") != id;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetVehicleById(int vehicleId)
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = $"SELECT * FROM Vehicle WHERE VehicleId = {vehicleId}";
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            return data;
        }
    }
}
