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
    public partial class MessageDialog : Form
    {
        public MessageDialog()
        {
            InitializeComponent();
        }

        public void ShowMessage(string title, string message)
        {
            Text = title;
            textareaMessage.Text = message;
            ShowDialog();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
