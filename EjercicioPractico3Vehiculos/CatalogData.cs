using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EjercicioPractico3Vehiculos
{
    internal class CatalogData
    {
        public static SqlCommand queryCommand = new SqlCommand();
        
        public static DataTable GetBrands()
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = "SELECT * FROM Brand";
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            return data;
        }
    
        public static DataTable GetCountries()
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = "SELECT * FROM Country";
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            return data;
        }

        public static DataTable GetVehicleTypes()
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = "SELECT * FROM VehicleType";
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
