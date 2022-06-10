namespace EjercicioPractico3Vehiculos
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
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.modelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.vehicleDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDBDataSet = new EjercicioPractico3Vehiculos.VehicleDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(21, 44);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(121, 16);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Buscar por modelo";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(148, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(556, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(787, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonAdd.Size = new System.Drawing.Size(132, 40);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.AllowUserToAddRows = false;
            this.dataGridViewVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewVehicles.AutoGenerateColumns = false;
            this.dataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelName,
            this.vehicleTypeId,
            this.vehicleId,
            this.brandId,
            this.countryId,
            this.modelYear,
            this.price,
            this.update,
            this.delete});
            this.dataGridViewVehicles.DataSource = this.vehicleDBDataSetBindingSource;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(24, 90);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.ReadOnly = true;
            this.dataGridViewVehicles.RowHeadersVisible = false;
            this.dataGridViewVehicles.RowHeadersWidth = 51;
            this.dataGridViewVehicles.RowTemplate.Height = 24;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(895, 356);
            this.dataGridViewVehicles.TabIndex = 3;
            this.dataGridViewVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehicles_CellClick);
            // 
            // modelName
            // 
            this.modelName.DataPropertyName = "modelName";
            this.modelName.FillWeight = 82.08112F;
            this.modelName.HeaderText = "Modelo";
            this.modelName.MinimumWidth = 6;
            this.modelName.Name = "modelName";
            // 
            // vehicleTypeId
            // 
            this.vehicleTypeId.DataPropertyName = "typeName";
            this.vehicleTypeId.FillWeight = 82.08112F;
            this.vehicleTypeId.HeaderText = "Tipo";
            this.vehicleTypeId.MinimumWidth = 6;
            this.vehicleTypeId.Name = "vehicleTypeId";
            // 
            // vehicleId
            // 
            this.vehicleId.DataPropertyName = "vehicleId";
            this.vehicleId.HeaderText = "ID";
            this.vehicleId.MinimumWidth = 6;
            this.vehicleId.Name = "vehicleId";
            this.vehicleId.Visible = false;
            // 
            // brandId
            // 
            this.brandId.DataPropertyName = "brandName";
            this.brandId.FillWeight = 82.08112F;
            this.brandId.HeaderText = "Marca";
            this.brandId.MinimumWidth = 6;
            this.brandId.Name = "brandId";
            // 
            // countryId
            // 
            this.countryId.DataPropertyName = "countryName";
            this.countryId.FillWeight = 82.08112F;
            this.countryId.HeaderText = "País";
            this.countryId.MinimumWidth = 6;
            this.countryId.Name = "countryId";
            // 
            // modelYear
            // 
            this.modelYear.DataPropertyName = "modelYear";
            this.modelYear.FillWeight = 82.08112F;
            this.modelYear.HeaderText = "Año";
            this.modelYear.MinimumWidth = 6;
            this.modelYear.Name = "modelYear";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 82.08112F;
            this.price.HeaderText = "Precio";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // update
            // 
            this.update.FillWeight = 126.1641F;
            this.update.HeaderText = "Editar";
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.MinimumWidth = 32;
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // delete
            // 
            this.delete.FillWeight = 118.6204F;
            this.delete.HeaderText = "Eliminar";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 32;
            this.delete.Name = "delete";
            // 
            // vehicleDBDataSetBindingSource
            // 
            this.vehicleDBDataSetBindingSource.DataSource = this.vehicleDBDataSet;
            this.vehicleDBDataSetBindingSource.Position = 0;
            // 
            // vehicleDBDataSet
            // 
            this.vehicleDBDataSet.DataSetName = "VehicleDBDataSet";
            this.vehicleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 468);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.BindingSource vehicleDBDataSetBindingSource;
        private VehicleDBDataSet vehicleDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandId;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn update;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}

