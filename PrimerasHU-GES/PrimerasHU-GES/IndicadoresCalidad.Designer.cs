namespace PrimerasHU_GES
{
    partial class IndicadoresCalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndicadoresCalidad));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomIndi = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtIndicadores = new System.Windows.Forms.DataGridView();
            this.codIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechoraModIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicadoresCalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet18 = new PrimerasHU_GES.ges_v01DataSet18();
            this.indicadoresCalidadTableAdapter = new PrimerasHU_GES.ges_v01DataSet18TableAdapters.indicadoresCalidadTableAdapter();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtIndicadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicadoresCalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Indicador";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(15, 340);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 36);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar Indicador";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 188);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtNomIndi
            // 
            this.txtNomIndi.Location = new System.Drawing.Point(15, 82);
            this.txtNomIndi.MaxLength = 30;
            this.txtNomIndi.Name = "txtNomIndi";
            this.txtNomIndi.Size = new System.Drawing.Size(200, 20);
            this.txtNomIndi.TabIndex = 4;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(15, 136);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 6;
            this.dtFecha.Value = new System.DateTime(2019, 11, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de modificacion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor del Indicador ";
            // 
            // dtIndicadores
            // 
            this.dtIndicadores.AllowUserToAddRows = false;
            this.dtIndicadores.AllowUserToDeleteRows = false;
            this.dtIndicadores.AutoGenerateColumns = false;
            this.dtIndicadores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIndicadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codIndicadorDataGridViewTextBoxColumn,
            this.fechoraModIndicadorDataGridViewTextBoxColumn,
            this.nomIndicadorDataGridViewTextBoxColumn,
            this.valorIndicadorDataGridViewTextBoxColumn});
            this.dtIndicadores.DataSource = this.indicadoresCalidadBindingSource;
            this.dtIndicadores.Location = new System.Drawing.Point(258, 82);
            this.dtIndicadores.MultiSelect = false;
            this.dtIndicadores.Name = "dtIndicadores";
            this.dtIndicadores.ReadOnly = true;
            this.dtIndicadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtIndicadores.Size = new System.Drawing.Size(442, 243);
            this.dtIndicadores.TabIndex = 10;
            this.dtIndicadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtIndicadores_CellClick);
            // 
            // codIndicadorDataGridViewTextBoxColumn
            // 
            this.codIndicadorDataGridViewTextBoxColumn.DataPropertyName = "codIndicador";
            this.codIndicadorDataGridViewTextBoxColumn.HeaderText = "Cod. Indicador";
            this.codIndicadorDataGridViewTextBoxColumn.Name = "codIndicadorDataGridViewTextBoxColumn";
            this.codIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codIndicadorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codIndicadorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechoraModIndicadorDataGridViewTextBoxColumn
            // 
            this.fechoraModIndicadorDataGridViewTextBoxColumn.DataPropertyName = "fechoraModIndicador";
            this.fechoraModIndicadorDataGridViewTextBoxColumn.HeaderText = "Fecha ";
            this.fechoraModIndicadorDataGridViewTextBoxColumn.Name = "fechoraModIndicadorDataGridViewTextBoxColumn";
            this.fechoraModIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomIndicadorDataGridViewTextBoxColumn
            // 
            this.nomIndicadorDataGridViewTextBoxColumn.DataPropertyName = "nomIndicador";
            this.nomIndicadorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomIndicadorDataGridViewTextBoxColumn.Name = "nomIndicadorDataGridViewTextBoxColumn";
            this.nomIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorIndicadorDataGridViewTextBoxColumn
            // 
            this.valorIndicadorDataGridViewTextBoxColumn.DataPropertyName = "valorIndicador";
            this.valorIndicadorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorIndicadorDataGridViewTextBoxColumn.Name = "valorIndicadorDataGridViewTextBoxColumn";
            this.valorIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indicadoresCalidadBindingSource
            // 
            this.indicadoresCalidadBindingSource.DataMember = "indicadoresCalidad";
            this.indicadoresCalidadBindingSource.DataSource = this.ges_v01DataSet18;
            // 
            // ges_v01DataSet18
            // 
            this.ges_v01DataSet18.DataSetName = "ges_v01DataSet18";
            this.ges_v01DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // indicadoresCalidadTableAdapter
            // 
            this.indicadoresCalidadTableAdapter.ClearBeforeFill = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(195, 340);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 36);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(374, 340);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(147, 36);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(553, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.panel1.Size = new System.Drawing.Size(723, 49);
            this.panel1.TabIndex = 47;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.button1.Location = new System.Drawing.Point(621, 0);
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
            this.btn_Salir.Location = new System.Drawing.Point(672, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(70, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "GESTIÓN INDICADORES DE CALIDAD";
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
            // IndicadoresCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtIndicadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtNomIndi);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IndicadoresCalidad";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IndicadoresCalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIndicadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicadoresCalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNomIndi;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtIndicadores;
        private ges_v01DataSet18 ges_v01DataSet18;
        private System.Windows.Forms.BindingSource indicadoresCalidadBindingSource;
        private ges_v01DataSet18TableAdapters.indicadoresCalidadTableAdapter indicadoresCalidadTableAdapter;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechoraModIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
    }
}