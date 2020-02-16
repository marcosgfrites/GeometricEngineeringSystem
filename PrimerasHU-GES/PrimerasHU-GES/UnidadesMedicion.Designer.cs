namespace PrimerasHU_GES
{
    partial class UnidadesMedicion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadesMedicion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonVerUdeMed = new System.Windows.Forms.Button();
            this.btnEliminarUdeMed = new System.Windows.Forms.Button();
            this.btnModUdeMed = new System.Windows.Forms.Button();
            this.btnLimpiarUdeMed = new System.Windows.Forms.Button();
            this.btnRegUdeMed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescUdeMed = new System.Windows.Forms.TextBox();
            this.txtCodigoUdeMed = new System.Windows.Forms.TextBox();
            this.dgvUdeMed = new System.Windows.Forms.DataGridView();
            this.codUnidMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descUnidMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesMedicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.ges_v01DataSet20UdeMed = new PrimerasHU_GES.ges_v01DataSet20UdeMed();
      //      this.unidadesMedicionTableAdapter = new PrimerasHU_GES.ges_v01DataSet20UdeMedTableAdapters.unidadesMedicionTableAdapter();
            this.ges_v01DataSet18_UdeMed2 = new PrimerasHU_GES.ges_v01DataSet18_UdeMed2();
            this.unidadesMedicionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unidadesMedicionTableAdapter1 = new PrimerasHU_GES.ges_v01DataSet18_UdeMed2TableAdapters.unidadesMedicionTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdeMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedicionBindingSource)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet20UdeMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18_UdeMed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedicionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 49);
            this.panel1.TabIndex = 48;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(708, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(64, 49);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(89, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "GESTOR DE UNIDADES DE MEDICION";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Black;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(772, 0);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(64, 49);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.panel2.BackgroundImage = global::PrimerasHU_GES.Properties.Resources.LOGOENCABEZADO_Mesa_de_trabajo_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 49);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvUdeMed);
            this.panel3.Location = new System.Drawing.Point(25, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 456);
            this.panel3.TabIndex = 117;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.botonVerUdeMed);
            this.panel4.Controls.Add(this.btnEliminarUdeMed);
            this.panel4.Controls.Add(this.btnModUdeMed);
            this.panel4.Controls.Add(this.btnLimpiarUdeMed);
            this.panel4.Controls.Add(this.btnRegUdeMed);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtDescUdeMed);
            this.panel4.Controls.Add(this.txtCodigoUdeMed);
            this.panel4.Location = new System.Drawing.Point(25, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 423);
            this.panel4.TabIndex = 105;
            // 
            // botonVerUdeMed
            // 
            this.botonVerUdeMed.BackColor = System.Drawing.Color.Black;
            this.botonVerUdeMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVerUdeMed.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerUdeMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerUdeMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerUdeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonVerUdeMed.ForeColor = System.Drawing.Color.White;
            this.botonVerUdeMed.Location = new System.Drawing.Point(16, 378);
            this.botonVerUdeMed.Name = "botonVerUdeMed";
            this.botonVerUdeMed.Size = new System.Drawing.Size(344, 36);
            this.botonVerUdeMed.TabIndex = 85;
            this.botonVerUdeMed.Text = "Ver Unidad de Medicion en Panel";
            this.botonVerUdeMed.UseVisualStyleBackColor = false;
            this.botonVerUdeMed.Click += new System.EventHandler(this.botonVerUdeMed_Click);
            // 
            // btnEliminarUdeMed
            // 
            this.btnEliminarUdeMed.BackColor = System.Drawing.Color.Black;
            this.btnEliminarUdeMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUdeMed.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEliminarUdeMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarUdeMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUdeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUdeMed.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUdeMed.Location = new System.Drawing.Point(15, 336);
            this.btnEliminarUdeMed.Name = "btnEliminarUdeMed";
            this.btnEliminarUdeMed.Size = new System.Drawing.Size(345, 36);
            this.btnEliminarUdeMed.TabIndex = 83;
            this.btnEliminarUdeMed.Text = "Eliminar Unidad de Medicion";
            this.btnEliminarUdeMed.UseVisualStyleBackColor = false;
            this.btnEliminarUdeMed.Click += new System.EventHandler(this.btnEliminarUdeMed_Click);
            // 
            // btnModUdeMed
            // 
            this.btnModUdeMed.BackColor = System.Drawing.Color.Black;
            this.btnModUdeMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModUdeMed.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnModUdeMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModUdeMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModUdeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModUdeMed.ForeColor = System.Drawing.Color.White;
            this.btnModUdeMed.Location = new System.Drawing.Point(15, 252);
            this.btnModUdeMed.Name = "btnModUdeMed";
            this.btnModUdeMed.Size = new System.Drawing.Size(345, 36);
            this.btnModUdeMed.TabIndex = 82;
            this.btnModUdeMed.Text = "Modificar Unidad de Medicion";
            this.btnModUdeMed.UseVisualStyleBackColor = false;
            this.btnModUdeMed.Click += new System.EventHandler(this.btnModUdeMed_Click);
            // 
            // btnLimpiarUdeMed
            // 
            this.btnLimpiarUdeMed.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarUdeMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarUdeMed.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarUdeMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarUdeMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUdeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarUdeMed.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarUdeMed.Location = new System.Drawing.Point(15, 294);
            this.btnLimpiarUdeMed.Name = "btnLimpiarUdeMed";
            this.btnLimpiarUdeMed.Size = new System.Drawing.Size(345, 36);
            this.btnLimpiarUdeMed.TabIndex = 81;
            this.btnLimpiarUdeMed.Text = "Limpíar seleccion";
            this.btnLimpiarUdeMed.UseVisualStyleBackColor = false;
            this.btnLimpiarUdeMed.Click += new System.EventHandler(this.btnLimpiarUdeMed_Click);
            // 
            // btnRegUdeMed
            // 
            this.btnRegUdeMed.BackColor = System.Drawing.Color.Black;
            this.btnRegUdeMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegUdeMed.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegUdeMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegUdeMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegUdeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegUdeMed.ForeColor = System.Drawing.Color.White;
            this.btnRegUdeMed.Location = new System.Drawing.Point(16, 210);
            this.btnRegUdeMed.Name = "btnRegUdeMed";
            this.btnRegUdeMed.Size = new System.Drawing.Size(345, 36);
            this.btnRegUdeMed.TabIndex = 80;
            this.btnRegUdeMed.Text = "Registrar Unidad de Medicion";
            this.btnRegUdeMed.UseVisualStyleBackColor = false;
            this.btnRegUdeMed.Click += new System.EventHandler(this.btnRegUdeMed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Codigo de Entidad:";
            // 
            // txtDescUdeMed
            // 
            this.txtDescUdeMed.Location = new System.Drawing.Point(15, 111);
            this.txtDescUdeMed.Multiline = true;
            this.txtDescUdeMed.Name = "txtDescUdeMed";
            this.txtDescUdeMed.Size = new System.Drawing.Size(347, 77);
            this.txtDescUdeMed.TabIndex = 77;
            this.txtDescUdeMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescUdeMed.TextChanged += new System.EventHandler(this.txtDescUdeMed_TextChanged);
            // 
            // txtCodigoUdeMed
            // 
            this.txtCodigoUdeMed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoUdeMed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoUdeMed.Enabled = false;
            this.txtCodigoUdeMed.Location = new System.Drawing.Point(16, 45);
            this.txtCodigoUdeMed.Name = "txtCodigoUdeMed";
            this.txtCodigoUdeMed.Size = new System.Drawing.Size(345, 20);
            this.txtCodigoUdeMed.TabIndex = 76;
            this.txtCodigoUdeMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvUdeMed
            // 
            this.dgvUdeMed.AllowUserToAddRows = false;
            this.dgvUdeMed.AllowUserToDeleteRows = false;
            this.dgvUdeMed.AutoGenerateColumns = false;
            this.dgvUdeMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUdeMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codUnidMedDataGridViewTextBoxColumn,
            this.descUnidMedDataGridViewTextBoxColumn});
            this.dgvUdeMed.DataSource = this.unidadesMedicionBindingSource1;
            this.dgvUdeMed.Location = new System.Drawing.Point(426, 14);
            this.dgvUdeMed.Name = "dgvUdeMed";
            this.dgvUdeMed.ReadOnly = true;
            this.dgvUdeMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUdeMed.Size = new System.Drawing.Size(346, 423);
            this.dgvUdeMed.TabIndex = 108;
            this.dgvUdeMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUdeMed_CellClick);
            // 
            // codUnidMedDataGridViewTextBoxColumn
            // 
            this.codUnidMedDataGridViewTextBoxColumn.DataPropertyName = "codUnidMed";
            this.codUnidMedDataGridViewTextBoxColumn.HeaderText = "Codigo de Unidad de Medicion";
            this.codUnidMedDataGridViewTextBoxColumn.Name = "codUnidMedDataGridViewTextBoxColumn";
            this.codUnidMedDataGridViewTextBoxColumn.ReadOnly = true;
            this.codUnidMedDataGridViewTextBoxColumn.Width = 150;
            // 
            // descUnidMedDataGridViewTextBoxColumn
            // 
            this.descUnidMedDataGridViewTextBoxColumn.DataPropertyName = "descUnidMed";
            this.descUnidMedDataGridViewTextBoxColumn.HeaderText = "Descripcion de Unidada de Medicion";
            this.descUnidMedDataGridViewTextBoxColumn.Name = "descUnidMedDataGridViewTextBoxColumn";
            this.descUnidMedDataGridViewTextBoxColumn.ReadOnly = true;
            this.descUnidMedDataGridViewTextBoxColumn.Width = 150;
            // 
            // unidadesMedicionBindingSource
            // 
            this.unidadesMedicionBindingSource.DataMember = "unidadesMedicion";
          //  this.unidadesMedicionBindingSource.DataSource = this.ges_v01DataSet20UdeMed;
            // 
            // ges_v01DataSet20UdeMed
            // 
           // this.ges_v01DataSet20UdeMed.DataSetName = "ges_v01DataSet20UdeMed";
           // this.ges_v01DataSet20UdeMed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadesMedicionTableAdapter
            // 
         //   this.unidadesMedicionTableAdapter.ClearBeforeFill = true;
            // 
            // ges_v01DataSet18_UdeMed2
            // 
            this.ges_v01DataSet18_UdeMed2.DataSetName = "ges_v01DataSet18_UdeMed2";
            this.ges_v01DataSet18_UdeMed2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadesMedicionBindingSource1
            // 
            this.unidadesMedicionBindingSource1.DataMember = "unidadesMedicion";
            this.unidadesMedicionBindingSource1.DataSource = this.ges_v01DataSet18_UdeMed2;
            // 
            // unidadesMedicionTableAdapter1
            // 
            this.unidadesMedicionTableAdapter1.ClearBeforeFill = true;
            // 
            // UnidadesMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnidadesMedicion";
            this.Text = "Unidades de Medicion";
            this.Load += new System.EventHandler(this.UnidadesMedicion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdeMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedicionBindingSource)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet20UdeMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18_UdeMed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesMedicionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botonVerUdeMed;
        private System.Windows.Forms.Button btnEliminarUdeMed;
        private System.Windows.Forms.Button btnModUdeMed;
        private System.Windows.Forms.Button btnLimpiarUdeMed;
        private System.Windows.Forms.Button btnRegUdeMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescUdeMed;
        private System.Windows.Forms.TextBox txtCodigoUdeMed;
        private System.Windows.Forms.DataGridView dgvUdeMed;
      //  private ges_v01DataSet20UdeMed ges_v01DataSet20UdeMed;
        private System.Windows.Forms.BindingSource unidadesMedicionBindingSource;
      //  private ges_v01DataSet20UdeMedTableAdapters.unidadesMedicionTableAdapter unidadesMedicionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUnidMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descUnidMedDataGridViewTextBoxColumn;
        private ges_v01DataSet18_UdeMed2 ges_v01DataSet18_UdeMed2;
        private System.Windows.Forms.BindingSource unidadesMedicionBindingSource1;
        private ges_v01DataSet18_UdeMed2TableAdapters.unidadesMedicionTableAdapter unidadesMedicionTableAdapter1;
    }
}