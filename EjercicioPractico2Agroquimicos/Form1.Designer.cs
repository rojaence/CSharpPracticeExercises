namespace EjercicioPractico2Agroquimicos
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewAgrochemicals = new System.Windows.Forms.DataGridView();
            this.agrochemicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toxicityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agrochemicalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.agrochemicalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agrochemicalDBDataSet = new EjercicioPractico2Agroquimicos.AgrochemicalDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgrochemicals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrochemicalDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrochemicalDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(26, 41);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(121, 16);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Buscar por nombre";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(163, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(517, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(867, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonAdd.Size = new System.Drawing.Size(136, 39);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewAgrochemicals
            // 
            this.dataGridViewAgrochemicals.AllowUserToAddRows = false;
            this.dataGridViewAgrochemicals.AllowUserToDeleteRows = false;
            this.dataGridViewAgrochemicals.AutoGenerateColumns = false;
            this.dataGridViewAgrochemicals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgrochemicals.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewAgrochemicals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgrochemicals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agrochemicalName,
            this.laboratory,
            this.brand,
            this.dosage,
            this.toxicityLevel,
            this.agrochemicalId,
            this.edit,
            this.delete});
            this.dataGridViewAgrochemicals.DataSource = this.agrochemicalDBDataSetBindingSource;
            this.dataGridViewAgrochemicals.Location = new System.Drawing.Point(29, 88);
            this.dataGridViewAgrochemicals.Name = "dataGridViewAgrochemicals";
            this.dataGridViewAgrochemicals.RowHeadersVisible = false;
            this.dataGridViewAgrochemicals.RowHeadersWidth = 51;
            this.dataGridViewAgrochemicals.RowTemplate.Height = 24;
            this.dataGridViewAgrochemicals.Size = new System.Drawing.Size(974, 410);
            this.dataGridViewAgrochemicals.TabIndex = 3;
            this.dataGridViewAgrochemicals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgrochemicals_CellClick);
            this.dataGridViewAgrochemicals.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAgrochemicals_CellFormatting);
            // 
            // agrochemicalName
            // 
            this.agrochemicalName.DataPropertyName = "agrochemicalName";
            this.agrochemicalName.FillWeight = 108.3601F;
            this.agrochemicalName.HeaderText = "Nombre";
            this.agrochemicalName.MinimumWidth = 150;
            this.agrochemicalName.Name = "agrochemicalName";
            // 
            // laboratory
            // 
            this.laboratory.DataPropertyName = "laboratoryName";
            this.laboratory.FillWeight = 80.41875F;
            this.laboratory.HeaderText = "Laboratorio";
            this.laboratory.MinimumWidth = 150;
            this.laboratory.Name = "laboratory";
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brandName";
            this.brand.FillWeight = 80.41875F;
            this.brand.HeaderText = "Marca";
            this.brand.MinimumWidth = 120;
            this.brand.Name = "brand";
            // 
            // dosage
            // 
            this.dosage.DataPropertyName = "dosage";
            this.dosage.FillWeight = 80.41875F;
            this.dosage.HeaderText = "Dosificación";
            this.dosage.MinimumWidth = 120;
            this.dosage.Name = "dosage";
            // 
            // toxicityLevel
            // 
            this.toxicityLevel.DataPropertyName = "toxicityLevel";
            this.toxicityLevel.FillWeight = 80.41875F;
            this.toxicityLevel.HeaderText = "Toxicidad";
            this.toxicityLevel.MinimumWidth = 100;
            this.toxicityLevel.Name = "toxicityLevel";
            // 
            // agrochemicalId
            // 
            this.agrochemicalId.DataPropertyName = "agrochemicalId";
            this.agrochemicalId.HeaderText = "ID";
            this.agrochemicalId.MinimumWidth = 6;
            this.agrochemicalId.Name = "agrochemicalId";
            this.agrochemicalId.ReadOnly = true;
            this.agrochemicalId.Visible = false;
            // 
            // edit
            // 
            this.edit.FillWeight = 99.61549F;
            this.edit.HeaderText = "Editar";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 40;
            this.edit.Name = "edit";
            // 
            // delete
            // 
            this.delete.FillWeight = 109.3472F;
            this.delete.HeaderText = "Eliminar";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 40;
            this.delete.Name = "delete";
            // 
            // agrochemicalDBDataSetBindingSource
            // 
            this.agrochemicalDBDataSetBindingSource.DataSource = this.agrochemicalDBDataSet;
            this.agrochemicalDBDataSetBindingSource.Position = 0;
            // 
            // agrochemicalDBDataSet
            // 
            this.agrochemicalDBDataSet.DataSetName = "AgrochemicalDBDataSet";
            this.agrochemicalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 527);
            this.Controls.Add(this.dataGridViewAgrochemicals);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agroquímicos";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgrochemicals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrochemicalDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrochemicalDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewAgrochemicals;
        private System.Windows.Forms.BindingSource agrochemicalDBDataSetBindingSource;
        private AgrochemicalDBDataSet agrochemicalDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrochemicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratory;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn toxicityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrochemicalId;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}

