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

namespace EjercicioPractico2Agroquimicos
{
    public partial class AgrochemicalDataForm : Form
    {
        public string actionForm = "";
        public int agrochemicalId = 0;

        public AgrochemicalDataForm()
        {
            InitializeComponent();
            comboBoxToxicityLevel.DisplayMember = "Text";
            comboBoxToxicityLevel.ValueMember = "Value";
            comboBoxToxicityLevel.DataSource = CatalogData.GetToxicityLevels();
        }

        public void ShowDataForm(int agrochemicalId, Boolean update)
        {
            try
            {
                FillComboBoxData();
                if (update)
                {
                    actionForm = "update";
                    this.Text = "Actualizar datos de agroquímico";
                    this.agrochemicalId = agrochemicalId;
                    var agrochemicalData = CatalogData.GetAgrochemicalById(agrochemicalId).Rows[0];
                    textBoxName.Text = agrochemicalData["agrochemicalName"].ToString();
                    comboBoxLaboratory.SelectedValue = int.Parse(agrochemicalData["laboratoryId"].ToString());
                    comboBoxBrand.SelectedValue = int.Parse(agrochemicalData["brandId"].ToString());
                    comboBoxMeasure.SelectedValue = int.Parse(agrochemicalData["measureId"].ToString());
                    comboBoxToxicityLevel.SelectedValue = int.Parse(agrochemicalData["toxicityLevel"].ToString());
                    textBoxQuantity.Text = agrochemicalData["measureUnit"].ToString();
                }
                else
                {
                    this.Text = "Nuevo agroquímico";
                    actionForm = "create";
                }
                ShowDialog();
            }
            catch(Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage(ex.Message, "Error");
            }
        }

        private void comboBoxToxicityLevel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMeasure_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var result = comboBoxMeasure.SelectedItem;
            Console.WriteLine(result);
        }

        private void AgrochemicalDataForm_Load(object sender, EventArgs e)
        {
            
        }

        public void FillComboBoxData() 
        {
            try
            {
                comboBoxToxicityLevel.DisplayMember = "name";
                comboBoxToxicityLevel.ValueMember = "level";
                comboBoxToxicityLevel.DataSource = CatalogData.GetToxicityLevels();

                comboBoxBrand.DisplayMember = "brandName";
                comboBoxBrand.ValueMember = "brandId";
                comboBoxBrand.DataSource = CatalogData.GetBrands();

                comboBoxLaboratory.DisplayMember = "laboratoryName";
                comboBoxLaboratory.ValueMember = "laboratoryId";
                comboBoxLaboratory.DataSource = CatalogData.GetLaboratories();

                comboBoxMeasure.DisplayMember = "fullName";
                comboBoxMeasure.ValueMember = "measureId";
                comboBoxMeasure.DataSource = CatalogData.GetMeasures();
            }
            catch (Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage(ex.Message, "Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    if (!Agrochemical.AgrochemicalExists(textBoxName.Text.Trim(), actionForm == "update", agrochemicalId))
                    {
                        var newData = new Agrochemical
                        {
                            Name = textBoxName.Text.Trim(),
                            LaboratoryId = int.Parse(comboBoxLaboratory.SelectedValue.ToString()),
                            BrandId = int.Parse(comboBoxBrand.SelectedValue.ToString()),
                            MeasureId = int.Parse(comboBoxMeasure.SelectedValue.ToString()),
                            MeasureQuantity = double.Parse(textBoxQuantity.Text.ToString(), CultureInfo.InvariantCulture),
                            ToxicityLevel = int.Parse(comboBoxToxicityLevel.SelectedValue.ToString())
                        };
                        if (actionForm == "create")
                        {
                            newData.CreateAgrochemical();
                            var modalMessage = new MessageDialog();
                            modalMessage.ShowMessage("Se ha guardado el nuevo registro", "Operación exitosa");
                        }
                        else if (actionForm == "update")
                        {
                            newData.AgrochemicalId = this.agrochemicalId;
                            newData.UpdateAgrochemical();
                            var modalMessage = new MessageDialog();
                            modalMessage.ShowMessage("Se ha actualizado el registro", "Operación exitosa");
                        }

                        if (this.Owner is IAgrochemicalForm formInterface)
                        {
                            formInterface.AgrochemicalDataChanged(true);
                        }
                        Dispose();
                    } 
                    else
                    {
                        var modalMessage = new MessageDialog();
                        modalMessage.ShowMessage($"Ya existe un agroquímico con el nombre {textBoxName.Text.Trim()}", "Registro existente");
                    }
                }
            }
            catch (Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage(ex.Message, "Error");
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private Boolean ValidateForm()
        {
            var isValid = true;
            var alertMessages = "";

            if (textBoxName.Text.Trim() == "")
            {
                alertMessages += "* Ingrese el nombre\n";
                isValid = false;
            }
            if (textBoxQuantity.Text.Trim() == "" || Single.Parse(textBoxQuantity.Text.Trim()) == 0)
            {
                alertMessages += "* Ingrese un número válido\n";
                isValid = false;
            }

            if (!isValid)
            {
                var messageDialog = new MessageDialog();
                messageDialog.ShowMessage(alertMessages, "Datos inválidos");
            }
            
            return isValid;
        }
    }
}
