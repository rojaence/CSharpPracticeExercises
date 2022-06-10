using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPractico3Vehiculos
{
    public partial class VehicleDataForm : Form
    {
        public string actionForm = "";
        public int vehicleId = 0;

        public VehicleDataForm()
        {
            InitializeComponent();
        }
        
        public void ShowFormData(int vehicleId, Boolean update)
        {
            try
            {
                FillCatalogData();
                if (update)
                {
                    actionForm = "update";
                    Text = "Actualizar datos de vehículo";
                    this.vehicleId = vehicleId;
                    var vehicleData = Vehicle.GetVehicleById(vehicleId).Rows[0];
                    textBoxModelName.Text = vehicleData["modelName"].ToString();
                    comboBoxBrand.SelectedValue = int.Parse(vehicleData["brandId"].ToString());
                    comboBoxCountry.SelectedValue = int.Parse(vehicleData["countryId"].ToString());
                    comboBoxVehicleType.SelectedValue = int.Parse(vehicleData["vehicleTypeId"].ToString());
                    textBoxYear.Text = vehicleData["modelYear"].ToString();
                    textBoxPrice.Text = vehicleData["price"].ToString();
                }
                else
                {
                    Text = "Nuevo vehículo";
                    actionForm = "create";
                }
                ShowDialog();
            }
            catch(Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Error", ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void FillCatalogData()
        {
            try
            {
                comboBoxBrand.DisplayMember = "brandName";
                comboBoxBrand.ValueMember = "brandId";
                comboBoxBrand.DataSource = CatalogData.GetBrands();

                comboBoxCountry.DisplayMember = "countryName";
                comboBoxCountry.ValueMember = "countryId";
                comboBoxCountry.DataSource = CatalogData.GetCountries();

                comboBoxVehicleType.DisplayMember = "typeName";
                comboBoxVehicleType.ValueMember = "vehicleTypeId";
                comboBoxVehicleType.DataSource = CatalogData.GetVehicleTypes();
            }
            catch(Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Error", ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    var modalMessage = new MessageDialog();
                    var newData = new Vehicle
                    {
                        ModelName = textBoxModelName.Text.Trim(),
                        BrandId = int.Parse(comboBoxBrand.SelectedValue.ToString()),
                        CountryId = int.Parse(comboBoxCountry.SelectedValue.ToString()),
                        VehicleTypeId = int.Parse(comboBoxVehicleType.SelectedValue.ToString()),
                        ModelYear = int.Parse(textBoxYear.Text.ToString()),
                        Price = double.Parse(textBoxPrice.Text.ToString(), CultureInfo.InvariantCulture)
                    };
                    if (actionForm == "create")
                    {
                        newData.CreateVehicle();
                        modalMessage.ShowMessage("Operación exitosa", "Se ha guardado el nuevo vehículo");
                    }
                    else if (actionForm == "update")
                    {
                        newData.VehicleId = this.vehicleId;
                        newData.UpdateVehicle();
                        modalMessage.ShowMessage("Operación exitosa", "El registro se ha actualizado correctamente");
                    }

                    if (this.Owner is IVehicleForm formInterface)
                    {
                        formInterface.ChangedVehicleData(true);
                    }
                    Dispose();              
                }
            }
            catch(Exception ex)
            {
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Error", ex.Message);
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private Boolean ValidateForm()
        {
            var isValid = true;
            var alertMessages = "";

            if (textBoxModelName.Text.Trim() == "")
            {
                alertMessages += "* Ingrese el modelo\n";
                isValid = false;
            }
            if (textBoxPrice.Text.Trim() == "" || Double.Parse(textBoxPrice.Text.Trim()) == 0)
            {
                alertMessages += "* Ingrese un precio válido\n";
                isValid = false;
            }
            if (textBoxYear.Text.Trim() == "" || Double.Parse(textBoxYear.Text.Trim()) == 0)
            {
                alertMessages += "* Ingrese el año\n";
                isValid = false;
            }
            if (textBoxYear.Text.Trim() != "" && (Double.Parse(textBoxYear.Text.Trim()) < 1753 || Double.Parse(textBoxYear.Text.Trim()) > 9999))
            {
                alertMessages += "* El año debe estar entre 1753 y 9999\n";
                isValid = false;
            }

            if (!isValid)
            {
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage("Datos incorrectos", alertMessages);
            }
            return isValid;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
