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
    public partial class DeleteDialog : Form
    {
        public int personDataId = 0;

        public DeleteDialog()
        {
            InitializeComponent();
        }

        public void ShowDeleteDialog(string message, int personId)
        {
            this.personDataId = personId;
            this.labelMessage.Text = message;
            this.ShowDialog();
        }        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click en botón eliminar");
            if (this.Owner is IPersonForm formInterface)
            {
                Console.WriteLine("Se debio configurar la interface");
                formInterface.ShareDeleteData(this.personDataId, true);
            } else
            {
                Console.WriteLine("algo paso no se configurar la interface");
            }
            this.Close();
        }
    }
}
