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
    public partial class MainForm : Form, IAgrochemicalForm
    {

        public BindingList<Agrochemical> agrochemicalList = new BindingList<Agrochemical>();
            
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDataGridViewAgrochemicals("");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var agrochemicalDataFormDialog = new AgrochemicalDataForm
            {
                Owner = this
            };
            agrochemicalDataFormDialog.ShowDataForm(0, false);
        }

        public void FillDataGridViewAgrochemicals(string param)
        {
            try
            {
                dataGridViewAgrochemicals.DataSource = Agrochemical.GetAgrochemicals(param);
            }
            catch (Exception ex)
            {
                DBConnection.Disconnect();
                var modalMessage = new MessageDialog();
                modalMessage.ShowMessage(ex.Message, "Error");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            FillDataGridViewAgrochemicals(textBoxSearch.Text);
        }

        #region IAgrochemicalForm
        public void AgrochemicalDataChanged(Boolean change)
        {
            if (change)
            {
                textBoxSearch.Text = "";
                FillDataGridViewAgrochemicals("");
            }
        }
        #endregion

        private void dataGridViewAgrochemicals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAgrochemicals.Columns[e.ColumnIndex].Name == "toxicityLevel" && e.RowIndex >= 0)
            {

                e.Value = CatalogData.toxicityLevels.Find(x => x.Level == Convert.ToInt32(e.Value)).Name;
            }
        }

        private void dataGridViewAgrochemicals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell agrochemicalIdCell = (DataGridViewCell)
                dataGridViewAgrochemicals.Rows[e.RowIndex].Cells["agrochemicalId"];
                
                if (e.ColumnIndex == dataGridViewAgrochemicals.Columns["edit"].Index) {
                    var agrochemicalDataFormDialog = new AgrochemicalDataForm
                    {
                        Owner = this
                    };
                    agrochemicalDataFormDialog.ShowDataForm(int.Parse(agrochemicalIdCell.Value.ToString()), true);
                }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                else if (e.ColumnIndex == dataGridViewAgrochemicals.Columns["delete"].Index)
                {
                    DataGridViewCell agrochemicalNameCell = (DataGridViewCell)
                    dataGridViewAgrochemicals.Rows[e.RowIndex].Cells["agrochemicalName"];
                    var deleteFormDialog = new DeleteDialog
                    {
                        Owner = this
                    };
                    deleteFormDialog.ShowDeleteDialog(agrochemicalNameCell.Value.ToString(), int.Parse(agrochemicalIdCell.Value.ToString()));

                }
            }
        }
    }

}
