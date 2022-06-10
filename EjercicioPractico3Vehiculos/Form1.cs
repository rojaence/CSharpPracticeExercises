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
    public partial class MainForm : Form, IVehicleForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new VehicleDataForm
            {
                Owner = this
            };
            form.ShowFormData(0, false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDataGridViewVehicles("");
        }

        private void FillDataGridViewVehicles(string param)
        {
            try
            {
                dataGridViewVehicles.DataSource = Vehicle.GetVehicles(param);

            }
            catch (Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Error", ex.Message);
            }
        }

        private void dataGridViewVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell vehicleIdCell = (DataGridViewCell)
                    dataGridViewVehicles.Rows[e.RowIndex].Cells["vehicleId"];
                if (e.ColumnIndex == dataGridViewVehicles.Columns["update"].Index)
                {
                    var vehicleDataFormDialog = new VehicleDataForm
                    {
                        Owner = this
                    };
                    vehicleDataFormDialog.ShowFormData(int.Parse(vehicleIdCell.Value.ToString()), true);
                }
                else if (e.ColumnIndex == dataGridViewVehicles.Columns["delete"].Index)
                {
                    DataGridViewCell modelNameCell = (DataGridViewCell)
                    dataGridViewVehicles.Rows[e.RowIndex].Cells["modelName"];
                    var deleteFormDialog = new DeleteDialog
                    {
                        Owner = this
                    };
                    deleteFormDialog.ShowDeleteDialog(modelNameCell.Value.ToString(), int.Parse(vehicleIdCell.Value.ToString()));
                }
            }
        }

        #region IVehicleForm
        public void ChangedVehicleData(Boolean change)
        {
            if (change)
            {
                FillDataGridViewVehicles("");
            }
        }
        #endregion

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDataGridViewVehicles(textBoxSearch.Text.Trim());
        }
    }
}
