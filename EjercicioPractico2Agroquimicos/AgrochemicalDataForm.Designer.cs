namespace EjercicioPractico2Agroquimicos
{
    partial class AgrochemicalDataForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelLaboratory = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelToxicityLevel = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMeasure = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxLaboratory = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxToxicityLevel = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxMeasure = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre";
            // 
            // labelLaboratory
            // 
            this.labelLaboratory.AutoSize = true;
            this.labelLaboratory.Location = new System.Drawing.Point(24, 88);
            this.labelLaboratory.Name = "labelLaboratory";
            this.labelLaboratory.Size = new System.Drawing.Size(76, 16);
            this.labelLaboratory.TabIndex = 1;
            this.labelLaboratory.Text = "Laboratorio";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(24, 140);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(45, 16);
            this.labelBrand.TabIndex = 2;
            this.labelBrand.Text = "Marca";
            // 
            // labelToxicityLevel
            // 
            this.labelToxicityLevel.AutoSize = true;
            this.labelToxicityLevel.Location = new System.Drawing.Point(24, 188);
            this.labelToxicityLevel.Name = "labelToxicityLevel";
            this.labelToxicityLevel.Size = new System.Drawing.Size(114, 16);
            this.labelToxicityLevel.TabIndex = 3;
            this.labelToxicityLevel.Text = "Nivel de toxicidad";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDosage.Location = new System.Drawing.Point(24, 259);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(93, 16);
            this.labelDosage.TabIndex = 4;
            this.labelDosage.Text = "Dosificación";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(25, 309);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 16);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Cantidad";
            // 
            // labelMeasure
            // 
            this.labelMeasure.AutoSize = true;
            this.labelMeasure.Location = new System.Drawing.Point(154, 309);
            this.labelMeasure.Name = "labelMeasure";
            this.labelMeasure.Size = new System.Drawing.Size(53, 16);
            this.labelMeasure.TabIndex = 6;
            this.labelMeasure.Text = "Medida";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(364, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // comboBoxLaboratory
            // 
            this.comboBoxLaboratory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaboratory.FormattingEnabled = true;
            this.comboBoxLaboratory.Location = new System.Drawing.Point(112, 85);
            this.comboBoxLaboratory.Name = "comboBoxLaboratory";
            this.comboBoxLaboratory.Size = new System.Drawing.Size(364, 24);
            this.comboBoxLaboratory.TabIndex = 8;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(112, 140);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(364, 24);
            this.comboBoxBrand.TabIndex = 9;
            // 
            // comboBoxToxicityLevel
            // 
            this.comboBoxToxicityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToxicityLevel.FormattingEnabled = true;
            this.comboBoxToxicityLevel.Location = new System.Drawing.Point(157, 185);
            this.comboBoxToxicityLevel.Name = "comboBoxToxicityLevel";
            this.comboBoxToxicityLevel.Size = new System.Drawing.Size(182, 24);
            this.comboBoxToxicityLevel.TabIndex = 10;
            this.comboBoxToxicityLevel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxToxicityLevel_SelectionChangeCommitted);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(27, 351);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(111, 22);
            this.textBoxQuantity.TabIndex = 11;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // comboBoxMeasure
            // 
            this.comboBoxMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeasure.FormattingEnabled = true;
            this.comboBoxMeasure.Location = new System.Drawing.Point(157, 349);
            this.comboBoxMeasure.Name = "comboBoxMeasure";
            this.comboBoxMeasure.Size = new System.Drawing.Size(319, 24);
            this.comboBoxMeasure.TabIndex = 12;
            this.comboBoxMeasure.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMeasure_SelectionChangeCommitted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(129, 409);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(261, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AgrochemicalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 468);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxMeasure);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.comboBoxToxicityLevel);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxLaboratory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMeasure);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelToxicityLevel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelLaboratory);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgrochemicalDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información de agroquímico";
            this.Load += new System.EventHandler(this.AgrochemicalDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLaboratory;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelToxicityLevel;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMeasure;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxLaboratory;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxToxicityLevel;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxMeasure;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}