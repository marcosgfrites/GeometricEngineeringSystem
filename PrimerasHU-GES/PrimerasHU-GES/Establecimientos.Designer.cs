namespace PrimerasHU_GES
{
    partial class Establecimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Establecimientos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonVerEstablecimiento = new System.Windows.Forms.Button();
            this.btnEliminarEstablecimiento = new System.Windows.Forms.Button();
            this.btnModEstablecimiento = new System.Windows.Forms.Button();
            this.btnLimpiarEstablecimiento = new System.Windows.Forms.Button();
            this.btnRegEstablecimiento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescEstablecimiento = new System.Windows.Forms.TextBox();
            this.txtCodigoEstablecimiento = new System.Windows.Forms.TextBox();
            this.dgvEstablecimiento = new System.Windows.Forms.DataGridView();
            this.codEstablecimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descEstablecimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establecimientosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet18_Establecimientos2 = new PrimerasHU_GES.ges_v01DataSet18_Establecimientos2();
            this.establecimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet19_Establecimientos = new PrimerasHU_GES.ges_v01DataSet19();
            this.establecimientosTableAdapter1 = new PrimerasHU_GES.ges_v01DataSet18_Establecimientos2TableAdapters.establecimientosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.establecimientosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18_Establecimientos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.establecimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet19_Establecimientos)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(843, 49);
            this.panel1.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(89, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "GESTOR DE ESTABLECIMIENTOS";
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
            this.panel3.Controls.Add(this.dgvEstablecimiento);
            this.panel3.Location = new System.Drawing.Point(24, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 456);
            this.panel3.TabIndex = 117;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.botonVerEstablecimiento);
            this.panel4.Controls.Add(this.btnEliminarEstablecimiento);
            this.panel4.Controls.Add(this.btnModEstablecimiento);
            this.panel4.Controls.Add(this.btnLimpiarEstablecimiento);
            this.panel4.Controls.Add(this.btnRegEstablecimiento);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtDescEstablecimiento);
            this.panel4.Controls.Add(this.txtCodigoEstablecimiento);
            this.panel4.Location = new System.Drawing.Point(25, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 423);
            this.panel4.TabIndex = 105;
            // 
            // botonVerEstablecimiento
            // 
            this.botonVerEstablecimiento.BackColor = System.Drawing.Color.Black;
            this.botonVerEstablecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVerEstablecimiento.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerEstablecimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerEstablecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonVerEstablecimiento.ForeColor = System.Drawing.Color.White;
            this.botonVerEstablecimiento.Location = new System.Drawing.Point(16, 378);
            this.botonVerEstablecimiento.Name = "botonVerEstablecimiento";
            this.botonVerEstablecimiento.Size = new System.Drawing.Size(345, 36);
            this.botonVerEstablecimiento.TabIndex = 85;
            this.botonVerEstablecimiento.Text = "Ver Establecimiento en Panel";
            this.botonVerEstablecimiento.UseVisualStyleBackColor = false;
            this.botonVerEstablecimiento.Click += new System.EventHandler(this.botonVerEstablecimiento_Click);
            // 
            // btnEliminarEstablecimiento
            // 
            this.btnEliminarEstablecimiento.BackColor = System.Drawing.Color.Black;
            this.btnEliminarEstablecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEstablecimiento.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEliminarEstablecimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarEstablecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEstablecimiento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEstablecimiento.Location = new System.Drawing.Point(16, 336);
            this.btnEliminarEstablecimiento.Name = "btnEliminarEstablecimiento";
            this.btnEliminarEstablecimiento.Size = new System.Drawing.Size(345, 36);
            this.btnEliminarEstablecimiento.TabIndex = 83;
            this.btnEliminarEstablecimiento.Text = "Eliminar Establecimiento";
            this.btnEliminarEstablecimiento.UseVisualStyleBackColor = false;
            this.btnEliminarEstablecimiento.Click += new System.EventHandler(this.btnEliminarEstablecimiento_Click);
            // 
            // btnModEstablecimiento
            // 
            this.btnModEstablecimiento.BackColor = System.Drawing.Color.Black;
            this.btnModEstablecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModEstablecimiento.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnModEstablecimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModEstablecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModEstablecimiento.ForeColor = System.Drawing.Color.White;
            this.btnModEstablecimiento.Location = new System.Drawing.Point(16, 252);
            this.btnModEstablecimiento.Name = "btnModEstablecimiento";
            this.btnModEstablecimiento.Size = new System.Drawing.Size(345, 36);
            this.btnModEstablecimiento.TabIndex = 82;
            this.btnModEstablecimiento.Text = "Modificar Establecimiento";
            this.btnModEstablecimiento.UseVisualStyleBackColor = false;
            this.btnModEstablecimiento.Click += new System.EventHandler(this.btnModEstablecimiento_Click);
            // 
            // btnLimpiarEstablecimiento
            // 
            this.btnLimpiarEstablecimiento.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarEstablecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarEstablecimiento.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarEstablecimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarEstablecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarEstablecimiento.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEstablecimiento.Location = new System.Drawing.Point(16, 294);
            this.btnLimpiarEstablecimiento.Name = "btnLimpiarEstablecimiento";
            this.btnLimpiarEstablecimiento.Size = new System.Drawing.Size(345, 36);
            this.btnLimpiarEstablecimiento.TabIndex = 81;
            this.btnLimpiarEstablecimiento.Text = "Limpíar seleccion";
            this.btnLimpiarEstablecimiento.UseVisualStyleBackColor = false;
            this.btnLimpiarEstablecimiento.Click += new System.EventHandler(this.btnLimpiarEstablecimiento_Click);
            // 
            // btnRegEstablecimiento
            // 
            this.btnRegEstablecimiento.BackColor = System.Drawing.Color.Black;
            this.btnRegEstablecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEstablecimiento.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegEstablecimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegEstablecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegEstablecimiento.ForeColor = System.Drawing.Color.White;
            this.btnRegEstablecimiento.Location = new System.Drawing.Point(16, 210);
            this.btnRegEstablecimiento.Name = "btnRegEstablecimiento";
            this.btnRegEstablecimiento.Size = new System.Drawing.Size(345, 36);
            this.btnRegEstablecimiento.TabIndex = 80;
            this.btnRegEstablecimiento.Text = "Registrar Establecimiento";
            this.btnRegEstablecimiento.UseVisualStyleBackColor = false;
            this.btnRegEstablecimiento.Click += new System.EventHandler(this.btnRegEstablecimiento_Click);
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
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Codigo de Establecimiento:";
            // 
            // txtDescEstablecimiento
            // 
            this.txtDescEstablecimiento.Location = new System.Drawing.Point(15, 111);
            this.txtDescEstablecimiento.Multiline = true;
            this.txtDescEstablecimiento.Name = "txtDescEstablecimiento";
            this.txtDescEstablecimiento.Size = new System.Drawing.Size(347, 77);
            this.txtDescEstablecimiento.TabIndex = 77;
            this.txtDescEstablecimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescEstablecimiento.TextChanged += new System.EventHandler(this.txtDescEstablecimiento_TextChanged);
            // 
            // txtCodigoEstablecimiento
            // 
            this.txtCodigoEstablecimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoEstablecimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoEstablecimiento.Enabled = false;
            this.txtCodigoEstablecimiento.Location = new System.Drawing.Point(16, 45);
            this.txtCodigoEstablecimiento.Name = "txtCodigoEstablecimiento";
            this.txtCodigoEstablecimiento.Size = new System.Drawing.Size(345, 20);
            this.txtCodigoEstablecimiento.TabIndex = 76;
            this.txtCodigoEstablecimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEstablecimiento
            // 
            this.dgvEstablecimiento.AllowUserToAddRows = false;
            this.dgvEstablecimiento.AllowUserToDeleteRows = false;
            this.dgvEstablecimiento.AutoGenerateColumns = false;
            this.dgvEstablecimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablecimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEstablecimientoDataGridViewTextBoxColumn,
            this.descEstablecimientoDataGridViewTextBoxColumn});
            this.dgvEstablecimiento.DataSource = this.establecimientosBindingSource1;
            this.dgvEstablecimiento.Location = new System.Drawing.Point(426, 14);
            this.dgvEstablecimiento.Name = "dgvEstablecimiento";
            this.dgvEstablecimiento.ReadOnly = true;
            this.dgvEstablecimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstablecimiento.Size = new System.Drawing.Size(346, 423);
            this.dgvEstablecimiento.TabIndex = 108;
            this.dgvEstablecimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstablecimiento_CellClick);
            // 
            // codEstablecimientoDataGridViewTextBoxColumn
            // 
            this.codEstablecimientoDataGridViewTextBoxColumn.DataPropertyName = "codEstablecimiento";
            this.codEstablecimientoDataGridViewTextBoxColumn.HeaderText = "Codigo de Establecimiento";
            this.codEstablecimientoDataGridViewTextBoxColumn.Name = "codEstablecimientoDataGridViewTextBoxColumn";
            this.codEstablecimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEstablecimientoDataGridViewTextBoxColumn.Width = 150;
            // 
            // descEstablecimientoDataGridViewTextBoxColumn
            // 
            this.descEstablecimientoDataGridViewTextBoxColumn.DataPropertyName = "descEstablecimiento";
            this.descEstablecimientoDataGridViewTextBoxColumn.HeaderText = "Descripcion de Establecimiento";
            this.descEstablecimientoDataGridViewTextBoxColumn.Name = "descEstablecimientoDataGridViewTextBoxColumn";
            this.descEstablecimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descEstablecimientoDataGridViewTextBoxColumn.Width = 150;
            // 
            // establecimientosBindingSource1
            // 
            this.establecimientosBindingSource1.DataMember = "establecimientos";
            this.establecimientosBindingSource1.DataSource = this.ges_v01DataSet18_Establecimientos2;
            // 
            // ges_v01DataSet18_Establecimientos2
            // 
            this.ges_v01DataSet18_Establecimientos2.DataSetName = "ges_v01DataSet18_Establecimientos2";
            this.ges_v01DataSet18_Establecimientos2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // establecimientosBindingSource
            // 
            this.establecimientosBindingSource.DataMember = "establecimientos";
            this.establecimientosBindingSource.DataSource = this.ges_v01DataSet19_Establecimientos;
            // 
            // ges_v01DataSet19_Establecimientos
            // 
            this.ges_v01DataSet19_Establecimientos.DataSetName = "ges_v01DataSet19_Establecimientos";
            this.ges_v01DataSet19_Establecimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // establecimientosTableAdapter1
            // 
            this.establecimientosTableAdapter1.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(741, 0);
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
            this.btn_Salir.Location = new System.Drawing.Point(792, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // Establecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Establecimientos";
            this.Text = "Establecimientos";
            this.Load += new System.EventHandler(this.Establecimientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.establecimientosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18_Establecimientos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.establecimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet19_Establecimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botonVerEstablecimiento;
        private System.Windows.Forms.Button btnEliminarEstablecimiento;
        private System.Windows.Forms.Button btnModEstablecimiento;
        private System.Windows.Forms.Button btnLimpiarEstablecimiento;
        private System.Windows.Forms.Button btnRegEstablecimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescEstablecimiento;
        private System.Windows.Forms.TextBox txtCodigoEstablecimiento;
        private System.Windows.Forms.DataGridView dgvEstablecimiento;
        private ges_v01DataSet19 ges_v01DataSet19_Establecimientos;
        private System.Windows.Forms.BindingSource establecimientosBindingSource;
       // private ges_v01DataSet19TableAdapters.establecimientosTableAdapter establecimientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstablecimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEstablecimientoDataGridViewTextBoxColumn;
        private ges_v01DataSet18_Establecimientos2 ges_v01DataSet18_Establecimientos2;
        private System.Windows.Forms.BindingSource establecimientosBindingSource1;
        private ges_v01DataSet18_Establecimientos2TableAdapters.establecimientosTableAdapter establecimientosTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
    }
}