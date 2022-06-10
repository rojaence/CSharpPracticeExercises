using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPractico3Vehiculos
{
    public partial class DeleteDialog : Form
    {
        int dataId = 0;

        public DeleteDialog()
        {
            InitializeComponent();
        }

        public void ShowDeleteDialog(string paramText, int paramId)
        {
            textareaMessage.Text = $"¿Está seguro de eliminar el registro {paramText}?";
            dataId = paramId;
            ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicleData = new Vehicle
                {
                    VehicleId = dataId
                };
                vehicleData.DeleteVehicle();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Eliminación de vehículo", "El vehículo ha sido eliminado correctamente");
                if (Owner is IVehicleForm formInterface)
                {
                    formInterface.ChangedVehicleData(true);
                }
            }
            catch (Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Error", ex.Message);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
