using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPractico2Agroquimicos.Properties;
using System.Configuration;

namespace EjercicioPractico2Agroquimicos
{
    internal class DBConnection
    {
        public static SqlConnection connectionVar = new SqlConnection(Settings.Default.DBConnectionString);

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
