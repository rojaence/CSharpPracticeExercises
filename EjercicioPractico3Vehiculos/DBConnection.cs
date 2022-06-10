using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using EjercicioPractico3Vehiculos.Properties;
using System.Data.SqlClient;

namespace EjercicioPractico3Vehiculos
{
    internal class DBConnection
    {
        public static SqlConnection connectionVar = new SqlConnection(Settings.Default.VehicleDBConnectionString);

        public static void Connect()
        {
            try
            {
                connectionVar.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void Disconnect()
        {
            try
            {
                connectionVar.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }

}
