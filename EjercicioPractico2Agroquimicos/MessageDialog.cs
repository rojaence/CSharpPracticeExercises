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
    public partial class MessageDialog : Form
    {
        public MessageDialog()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message, string title)
        {
            this.Text = title;
            textareaMessage.Text = message;
            this.ShowDialog();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MessageDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
