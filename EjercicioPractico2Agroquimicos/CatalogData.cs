using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace EjercicioPractico2Agroquimicos
{
    internal class CatalogData
    {
        public static SqlCommand queryCommand = new SqlCommand();
        public static List<ToxicityLevel> toxicityLevels = new List<ToxicityLevel>(){new ToxicityLevel("Bajo", 1), new ToxicityLevel("Medio", 2), new ToxicityLevel("Alto", 3)};

        public static DataTable GetMeasures()
        {
            var data = new DataTable();
            var dataset = new DataSet();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = "SELECT * FROM Measure";
            queryCommand.CommandText = "SELECT * FROM Measure";
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            data.Columns.Add("fullName", typeof(string), "'( ' + measureUnit + ' )' + '   ' + measureName");
            return data;
        }

        public static DataTable GetToxicityLevels()
        {
            var data = new DataTable();

            data.Columns.Add("name", typeof(string));
            data.Columns.Add("level", typeof(int));
            foreach (var toxicityLevel in toxicityLevels)
            {
                data.Rows.Add(toxicityLevel.Name, toxicityLevel.Level);
            }
            return data;
        }

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

        public static DataTable GetLaboratories()
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.Text;
            queryCommand.CommandText = "SELECT * FROM Laboratory";
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            return data;
        }

        public static DataTable GetAgrochemicalById(int agrochemicalId)
        {
            var data = new DataTable();
            var adapter = new SqlDataAdapter();
            queryCommand.CommandType = CommandType.StoredProcedure;
            queryCommand.CommandText = "GetAgrochemicalById";
            queryCommand.Parameters.Clear();
            queryCommand.Parameters.AddWithValue("@agrochemicalId", agrochemicalId);
            queryCommand.Connection = DBConnection.connectionVar;
            DBConnection.Connect();
            queryCommand.ExecuteReader();
            DBConnection.Disconnect();
            adapter.SelectCommand = queryCommand;
            adapter.Fill(data);
            return data;
        }

        public class ToxicityLevel
        {
            public string Name { get; set; }
            public int Level { get; set; }

            public ToxicityLevel(string name, int level)
            {
                Name = name;
                Level = level;
            }
        }
    }
}
