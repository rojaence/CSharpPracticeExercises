using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjercicioPractico1
{
    public partial class PersonDataForm : Form
    {
        public string actionForm = "";
        public int personDataId = 0;
        public List<String> validationMessages = new List<String>();

        public PersonDataForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowPersonFormData(int personId, string name, string surname, DateTime birth, string address, string action)
        {
            this.personDataId = personId;
            if (action == "create")
            {
                this.Text = "Nuevo registro de persona";
                actionForm = "create";
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                dateTimePickerBirth.Text = "";
                textAreaAddress.Text = "";
            }
            else if (action == "update")
            {
                this.Text = "Editar datos de persona";
                actionForm = "update";
                textBoxName.Text = name;
                textBoxSurname.Text = surname;
                dateTimePickerBirth.Value = birth;
                textAreaAddress.Text = address;
            }

            this.ShowDialog();
        }

        private void SavePersonData()
        {
            if (this.Owner is IPersonForm formInterface)
            {
                formInterface.SharePersonData(
                    personDataId,
                    textBoxName.Text.Trim(),
                    textBoxSurname.Text.Trim(),
                    dateTimePickerBirth.Value,
                    textAreaAddress.Text.Trim(),
                    actionForm
                );
            }
            this.Close();
        }

        private Boolean ValidatePersonData()
        {
            Boolean validateForm = true;
            
            if (this.textBoxName.Text == "")
            {
                validationMessages.Add("* Ingrese el nombre");
                validateForm = false;
            }
            if (this.textBoxSurname.Text == "")
            {
                validationMessages.Add("* Ingrese el apellido");
                validateForm = false;
            }
            if (this.textAreaAddress.Text == "")
            { 
                validationMessages.Add("* Ingrese la dirección");
                validateForm = false;
            }
            return validateForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var validation = ValidatePersonData();
            if (validation)
            {
                SavePersonData();
            } 
            else if (!validation)
            {
                var modalMessage = new messageDialog();
                modalMessage.ShowMessageDialog(this.validationMessages);
                this.validationMessages.Clear();
            }
        }
    }
}
