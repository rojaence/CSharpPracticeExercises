namespace EjercicioPractico3Vehiculos
{
    partial class MessageDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textareaMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAccept.Location = new System.Drawing.Point(158, 122);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(100, 40);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Aceptar";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textareaMessage
            // 
            this.textareaMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textareaMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textareaMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textareaMessage.Location = new System.Drawing.Point(12, 12);
            this.textareaMessage.Name = "textareaMessage";
            this.textareaMessage.ReadOnly = true;
            this.textareaMessage.Size = new System.Drawing.Size(393, 98);
            this.textareaMessage.TabIndex = 4;
            this.textareaMessage.Text = "Aquí el mensaje para el usuario";
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 173);
            this.Controls.Add(this.textareaMessage);
            this.Controls.Add(this.buttonAccept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensaje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.RichTextBox textareaMessage;
    }
}