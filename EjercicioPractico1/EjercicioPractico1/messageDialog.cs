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
    public partial class messageDialog : Form
    {
        public String Message = "";

        public messageDialog()
        {
            InitializeComponent();
        }

        public void ShowMessageDialog(List<String> WarningMessages)
        {
            WarningMessages.ForEach(Item => {
                Message += Item += "\n";
            });
            this.textAreaMessage.Text = Message;
            this.ShowDialog();
        }

        public void CloseMessageDialog()
        {
            this.Message = "";
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.CloseMessageDialog();
        }
    }
}
