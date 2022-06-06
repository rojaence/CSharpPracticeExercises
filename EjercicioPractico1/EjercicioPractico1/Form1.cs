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

    public partial class Form1 : Form, IPersonForm
        
    {

        public BindingList<Person> personList = new BindingList<Person>();
        public BindingList<Person> personListFiltered = new BindingList<Person>();
        PersonDataForm personDataFormModal = new PersonDataForm();
        DeleteDialog personDeleteDialog = new DeleteDialog();

        public int newId = 1;
        public string searchPlaceholder = "Buscar por nombre, apellido o dirección";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personDataFormModal.Owner = this;
            personDeleteDialog.Owner = this;
            ShowSearchPlaceholder(true);

            // Datos iniciales
            var person1 = new Person(1, "Alex", "Fernandez", DateTime.Parse("19/02/1995") , "Cdla. Las Piñas");
            var person2 = new Person(2, "Bryan", "Carrión", DateTime.Parse("02/06/1996"), "Av. 17 de Septiembre");
            var person3 = new Person(3, "Luis", "Oñate", DateTime.Parse("10/09/1990"), "Cdla. Inheri");
            newId = 4;
            
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            //

            dataGridViewPersons.DataSource = personList;
        }

        private void button_add(object sender, EventArgs e)
        {
            personDataFormModal.ShowPersonFormData(newId, null, null, DateTime.Now, null, "create");
        }

        #region IPersonForm Members
        public void SharePersonData(int personId, string name, string surname, DateTime birth, string address, string action)
        {
            if (action == "create")
            {
                this.personList.Add(new Person(personId, name, surname, birth, address));
                newId += 1;
            }
            else if (action == "update")
            {
                var selectedPersonId = FindPersonIndex(personId);

                this.personList[selectedPersonId].firstName = name;
                this.personList[selectedPersonId].lastName = surname;
                this.personList[selectedPersonId].dateBirth = birth;
                this.personList[selectedPersonId].address = address;
            }
            FilterPerson("");
            ShowSearchPlaceholder(true);
        }

        public void ShareDeleteData(int personId, Boolean confirmDelete)
        {
            if (confirmDelete == true)
            {
                var personIndex = FindPersonIndex(personId);
                this.personList.RemoveAt(personIndex);
                FilterPerson("");
                ShowSearchPlaceholder(true);
            }
        }
        #endregion

        public int FindPersonIndex(int personId)
        {
            Person personData = personList.SingleOrDefault(item => item.id == personId);
            return personList.IndexOf(personData);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != searchPlaceholder)
            {
                FilterPerson(textBoxSearch.Text.ToLower().Trim());
            }
        }

        private void dataGridViewPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == this.dataGridViewPersons.Columns["update"].Index || e.ColumnIndex == this.dataGridViewPersons.Columns["delete"].Index))
            {
                DataGridViewCell personIdCell = (DataGridViewCell)
                    dataGridViewPersons.Rows[e.RowIndex].Cells["personId"];
                var selectedId = (int)personIdCell.Value;

                Person personData = personList.SingleOrDefault(item => item.id == selectedId);
                if (e.ColumnIndex == this.dataGridViewPersons.Columns["update"].Index)
                {
                    personDataFormModal.ShowPersonFormData(personData.id, personData.firstName, personData.lastName, personData.dateBirth, personData.address, "update");
                }
                else if (e.ColumnIndex == this.dataGridViewPersons.Columns["delete"].Index)
                {
                    var message = $"¿Está seguro de eliminar a \n {personData.firstName} {personData.lastName}?";
                    personDeleteDialog.ShowDeleteDialog(message, personData.id);
                }
            }
        }

        private void ShowSearchPlaceholder(Boolean show)
        {
            if (show)
            {
                textBoxSearch.Text = searchPlaceholder;
                textBoxSearch.ForeColor = Color.Gray;
            } 
            else
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void FilterPerson(string param)
        {
            personListFiltered.Clear();
            if (param != "")
            {
                foreach (var item in personList)
                {
                    if (item.firstName.ToLower().Contains(param) || item.lastName.ToLower().Contains(param) || item.address.ToLower().Contains(param))
                    {
                        personListFiltered.Add(item);
                    }
                }
                dataGridViewPersons.DataSource = personListFiltered;
            } 
            else if (param == "")
            {
                textBoxSearch.Text = "";
                dataGridViewPersons.DataSource = personList;
            }

            dataGridViewPersons.Refresh();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == searchPlaceholder)
            {
                ShowSearchPlaceholder(false);
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                ShowSearchPlaceholder(true);
            }
        }
    }
}
