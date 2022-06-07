using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace EjercicioPractico2Agroquimicos
{
    public class Agrochemical
    {
        public static SqlCommand queryCommand = new SqlCommand();
        public int AgrochemicalId { get; set; }
        public int LaboratoryId { get; set; }
        public int BrandId { get; set; }
        public int MeasureId { get; set; }
        public string Name { get; set; }
        public double MeasureQuantity { get; set; }
        public int ToxicityLevel { get; set; }

        public Agrochemical() { }

        public Agrochemical(int agrochemicalIdVal, int laboratoryIdVal, int brandIdVal, int measureIdVal, string nameVal, double measureQuantityVal, int toxicityLevelVal)
        {
            AgrochemicalId = agrochemicalIdVal;
            LaboratoryId = laboratoryIdVal;
            BrandId = brandIdVal;
            MeasureId = measureIdVal;
            Name = nameVal;
            MeasureQuantity = measureQuantityVal;
            ToxicityLevel = toxicityLevelVal;
        }

        public void CreateAgrochemical()
        {
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "AddAgrochemical";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@laboratoryId", LaboratoryId);
            queryCommand.Parameters.AddWithValue("@brandId", BrandId);
            queryCommand.Parameters.AddWithValue("@measureId", MeasureId);
            queryCommand.Parameters.AddWithValue("@name", Name);
            queryCommand.Parameters.AddWithValue("@unitValue", MeasureQuantity);
            queryCommand.Parameters.AddWithValue("@toxLevel", ToxicityLevel);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
        }

        public void DeleteAgrochemical()
        {
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "DeleteAgrochemical";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("agrochemicalId", AgrochemicalId);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
        }

        public void UpdateAgrochemical()
        {
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "UpdateAgrochemical";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@agrochemicalId", AgrochemicalId);
            queryCommand.Parameters.AddWithValue("@laboratoryId", LaboratoryId);
            queryCommand.Parameters.AddWithValue("@brandId", BrandId);
            queryCommand.Parameters.AddWithValue("@measureId", MeasureId);
            queryCommand.Parameters.AddWithValue("@name", Name);
            queryCommand.Parameters.AddWithValue("@unitValue", MeasureQuantity);
            queryCommand.Parameters.AddWithValue("@toxLevel", ToxicityLevel);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
        }

        public static DataTable GetAgrochemicals(string param)
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "GetAgrochemicals";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@param", param);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            data.Columns.Add("dosage", typeof(string), "measureQuantity + ' ' + measureUnit");
            return data;
        }
        
        public static Boolean AgrochemicalExists(string name, Boolean update, int id)
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = $"SELECT TOP 1 * FROM Agrochemical WHERE LOWER(agrochemicalName) = '{name.ToLower()}' ORDER BY agrochemicalId DESC";
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            if (data.Rows.Count > 0)
            {
                if (update)
                {
                    return data.Rows[0].Field<int>("agrochemicalId") != id;
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
    }

}
