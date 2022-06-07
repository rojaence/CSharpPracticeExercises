using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPractico2Agroquimicos
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
            textareaMessage.Text = $"¿Está seguro que desea eliminar el registro {paramText}?";
            dataId = paramId;
            this.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                var agrochemicalData = new Agrochemical
                {
                    AgrochemicalId = dataId
                };
                agrochemicalData.DeleteAgrochemical();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Registro eliminado correctamente", "Error");
                if (this.Owner is IAgrochemicalForm formInterface)
                {
                    formInterface.AgrochemicalDataChanged(true);
                }
            }
            catch (Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage(ex.Message, "Error");
            }
            finally
            {
                Dispose();
            }
        }
    }
}
