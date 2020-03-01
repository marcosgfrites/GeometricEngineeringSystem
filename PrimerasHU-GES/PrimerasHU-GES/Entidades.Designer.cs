namespace PrimerasHU_GES
{
    partial class Entidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entidades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonVerEntidad = new System.Windows.Forms.Button();
            this.btnEliminarEntidad = new System.Windows.Forms.Button();
            this.btnModEntidad = new System.Windows.Forms.Button();
            this.btnLimpiarEntidad = new System.Windows.Forms.Button();
            this.btnRegEntidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescEntidad = new System.Windows.Forms.TextBox();
            this.txtCodigoEntidad = new System.Windows.Forms.TextBox();
            this.dgvEntidad = new System.Windows.Forms.DataGridView();
            this.codEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet18Entidades2 = new PrimerasHU_GES.ges_v01DataSet18Entidades2();
            this.entidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entidadesTableAdapter1 = new PrimerasHU_GES.ges_v01DataSet18Entidades2TableAdapters.entidadesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18Entidades2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 49);
            this.panel1.TabIndex = 47;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(738, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Black;
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(789, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(89, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "GESTOR DE ENTIDADES";
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
            this.panel3.Controls.Add(this.dgvEntidad);
            this.panel3.Location = new System.Drawing.Point(21, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 456);
            this.panel3.TabIndex = 116;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.botonVerEntidad);
            this.panel4.Controls.Add(this.btnEliminarEntidad);
            this.panel4.Controls.Add(this.btnModEntidad);
            this.panel4.Controls.Add(this.btnLimpiarEntidad);
            this.panel4.Controls.Add(this.btnRegEntidad);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtDescEntidad);
            this.panel4.Controls.Add(this.txtCodigoEntidad);
            this.panel4.Location = new System.Drawing.Point(25, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 423);
            this.panel4.TabIndex = 105;
            // 
            // botonVerEntidad
            // 
            this.botonVerEntidad.BackColor = System.Drawing.Color.Black;
            this.botonVerEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVerEntidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.botonVerEntidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.botonVerEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerEntidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.botonVerEntidad.ForeColor = System.Drawing.Color.White;
            this.botonVerEntidad.Location = new System.Drawing.Point(81, 378);
            this.botonVerEntidad.Name = "botonVerEntidad";
            this.botonVerEntidad.Size = new System.Drawing.Size(215, 36);
            this.botonVerEntidad.TabIndex = 85;
            this.botonVerEntidad.Text = "Ver Entidades en Panel";
            this.botonVerEntidad.UseVisualStyleBackColor = false;
            this.botonVerEntidad.Click += new System.EventHandler(this.botonVerEntidad_Click);
            // 
            // btnEliminarEntidad
            // 
            this.btnEliminarEntidad.BackColor = System.Drawing.Color.Black;
            this.btnEliminarEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEntidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnEliminarEntidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnEliminarEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEntidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEntidad.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEntidad.Location = new System.Drawing.Point(81, 336);
            this.btnEliminarEntidad.Name = "btnEliminarEntidad";
            this.btnEliminarEntidad.Size = new System.Drawing.Size(215, 36);
            this.btnEliminarEntidad.TabIndex = 83;
            this.btnEliminarEntidad.Text = "Eliminar Entidad";
            this.btnEliminarEntidad.UseVisualStyleBackColor = false;
            this.btnEliminarEntidad.Click += new System.EventHandler(this.btnEliminarEntidad_Click);
            // 
            // btnModEntidad
            // 
            this.btnModEntidad.BackColor = System.Drawing.Color.Black;
            this.btnModEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModEntidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnModEntidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnModEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModEntidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnModEntidad.ForeColor = System.Drawing.Color.White;
            this.btnModEntidad.Location = new System.Drawing.Point(81, 252);
            this.btnModEntidad.Name = "btnModEntidad";
            this.btnModEntidad.Size = new System.Drawing.Size(215, 36);
            this.btnModEntidad.TabIndex = 82;
            this.btnModEntidad.Text = "Modificar Entidad";
            this.btnModEntidad.UseVisualStyleBackColor = false;
            this.btnModEntidad.Click += new System.EventHandler(this.btnModEntidad_Click);
            // 
            // btnLimpiarEntidad
            // 
            this.btnLimpiarEntidad.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarEntidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnLimpiarEntidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnLimpiarEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEntidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarEntidad.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEntidad.Location = new System.Drawing.Point(81, 294);
            this.btnLimpiarEntidad.Name = "btnLimpiarEntidad";
            this.btnLimpiarEntidad.Size = new System.Drawing.Size(215, 36);
            this.btnLimpiarEntidad.TabIndex = 81;
            this.btnLimpiarEntidad.Text = "Limpíar seleccion";
            this.btnLimpiarEntidad.UseVisualStyleBackColor = false;
            this.btnLimpiarEntidad.Click += new System.EventHandler(this.btnLimpiarEntidad_Click);
            // 
            // btnRegEntidad
            // 
            this.btnRegEntidad.BackColor = System.Drawing.Color.Black;
            this.btnRegEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEntidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnRegEntidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnRegEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEntidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegEntidad.ForeColor = System.Drawing.Color.White;
            this.btnRegEntidad.Location = new System.Drawing.Point(81, 210);
            this.btnRegEntidad.Name = "btnRegEntidad";
            this.btnRegEntidad.Size = new System.Drawing.Size(215, 36);
            this.btnRegEntidad.TabIndex = 80;
            this.btnRegEntidad.Text = "Registrar Entidad";
            this.btnRegEntidad.UseVisualStyleBackColor = false;
            this.btnRegEntidad.Click += new System.EventHandler(this.btnRegEntidad_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // txtDescEntidad
            // 
            this.txtDescEntidad.Location = new System.Drawing.Point(15, 111);
            this.txtDescEntidad.Multiline = true;
            this.txtDescEntidad.Name = "txtDescEntidad";
            this.txtDescEntidad.Size = new System.Drawing.Size(347, 77);
            this.txtDescEntidad.TabIndex = 77;
            this.txtDescEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescEntidad.TextChanged += new System.EventHandler(this.txtDescEntidad_TextChanged);
            // 
            // txtCodigoEntidad
            // 
            this.txtCodigoEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoEntidad.Enabled = false;
            this.txtCodigoEntidad.Location = new System.Drawing.Point(16, 45);
            this.txtCodigoEntidad.Name = "txtCodigoEntidad";
            this.txtCodigoEntidad.Size = new System.Drawing.Size(345, 20);
            this.txtCodigoEntidad.TabIndex = 76;
            this.txtCodigoEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEntidad
            // 
            this.dgvEntidad.AllowUserToAddRows = false;
            this.dgvEntidad.AllowUserToDeleteRows = false;
            this.dgvEntidad.AutoGenerateColumns = false;
            this.dgvEntidad.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEntidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEntidadDataGridViewTextBoxColumn,
            this.descEntidadDataGridViewTextBoxColumn});
            this.dgvEntidad.DataSource = this.entidadesBindingSource1;
            this.dgvEntidad.Location = new System.Drawing.Point(426, 14);
            this.dgvEntidad.Name = "dgvEntidad";
            this.dgvEntidad.ReadOnly = true;
            this.dgvEntidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidad.Size = new System.Drawing.Size(346, 423);
            this.dgvEntidad.TabIndex = 108;
            this.dgvEntidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntidad_CellClick);
            // 
            // codEntidadDataGridViewTextBoxColumn
            // 
            this.codEntidadDataGridViewTextBoxColumn.DataPropertyName = "codEntidad";
            this.codEntidadDataGridViewTextBoxColumn.HeaderText = "Codigo de la Entidad";
            this.codEntidadDataGridViewTextBoxColumn.Name = "codEntidadDataGridViewTextBoxColumn";
            this.codEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEntidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // descEntidadDataGridViewTextBoxColumn
            // 
            this.descEntidadDataGridViewTextBoxColumn.DataPropertyName = "descEntidad";
            this.descEntidadDataGridViewTextBoxColumn.HeaderText = "Descripcion de la Entidad";
            this.descEntidadDataGridViewTextBoxColumn.Name = "descEntidadDataGridViewTextBoxColumn";
            this.descEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.descEntidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // entidadesBindingSource1
            // 
            this.entidadesBindingSource1.DataMember = "entidades";
            this.entidadesBindingSource1.DataSource = this.ges_v01DataSet18Entidades2;
            // 
            // ges_v01DataSet18Entidades2
            // 
            this.ges_v01DataSet18Entidades2.DataSetName = "ges_v01DataSet18Entidades2";
            this.ges_v01DataSet18Entidades2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entidadesBindingSource
            // 
            this.entidadesBindingSource.DataMember = "entidades";
            // 
            // entidadesTableAdapter1
            // 
            this.entidadesTableAdapter1.ClearBeforeFill = true;
            // 
            // Entidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entidades";
            this.Text = "Entidades";
            this.Load += new System.EventHandler(this.Entidades_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Entidades_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18Entidades2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botonVerEntidad;
        private System.Windows.Forms.Button btnEliminarEntidad;
        private System.Windows.Forms.Button btnModEntidad;
        private System.Windows.Forms.Button btnLimpiarEntidad;
        private System.Windows.Forms.Button btnRegEntidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescEntidad;
        private System.Windows.Forms.TextBox txtCodigoEntidad;
        private System.Windows.Forms.DataGridView dgvEntidad;
       // private ges_v01DataSet17 ges_v01DataSet17_Entidades;
        private System.Windows.Forms.BindingSource entidadesBindingSource;
       // private ges_v01DataSet17TableAdapters.entidadesTableAdapter entidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEntidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEntidadDataGridViewTextBoxColumn;
        private ges_v01DataSet18Entidades2 ges_v01DataSet18Entidades2;
        private System.Windows.Forms.BindingSource entidadesBindingSource1;
        private ges_v01DataSet18Entidades2TableAdapters.entidadesTableAdapter entidadesTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
    }
}