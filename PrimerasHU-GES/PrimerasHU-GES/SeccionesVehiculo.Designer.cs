namespace PrimerasHU_GES
{
    partial class SeccionesVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeccionesVehiculo));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerSec = new System.Windows.Forms.TextBox();
            this.txtDescSec = new System.Windows.Forms.TextBox();
            this.txtCodSec = new System.Windows.Forms.TextBox();
            this.dgvSeccionesVehiculo = new System.Windows.Forms.DataGridView();
            this.codSeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descSeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verSeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secionesVehiulobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet2 = new PrimerasHU_GES.ges_v01DataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.seccionesVehiculoTableAdapter = new PrimerasHU_GES.ges_v01DataSet2TableAdapters.seccionesVehiculoTableAdapter();
            this.btnRegCodSec = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModSecVeh = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerTod = new System.Windows.Forms.Button();
            this.cbCodProyecto = new System.Windows.Forms.ComboBox();
            this.modelosVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet6 = new PrimerasHU_GES.ges_v01DataSet6();
            this.modelosVehiculoTableAdapter = new PrimerasHU_GES.ges_v01DataSet6TableAdapters.modelosVehiculoTableAdapter();
            this.errorProviderCodSeccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVerSec = new System.Windows.Forms.ErrorProvider(this.components);
            this.ges_v01DataSet22NuevoProyecto = new PrimerasHU_GES.ges_v01DataSet22NuevoProyecto();
            this.modelosVehiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelosVehiculoTableAdapter1 = new PrimerasHU_GES.ges_v01DataSet22NuevoProyectoTableAdapters.modelosVehiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccionesVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secionesVehiulobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelosVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVerSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet22NuevoProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosVehiculoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Version de seccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descripcion Seccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo Seccion:";
            // 
            // txtVerSec
            // 
            this.txtVerSec.Location = new System.Drawing.Point(159, 196);
            this.txtVerSec.MaxLength = 3;
            this.txtVerSec.Name = "txtVerSec";
            this.txtVerSec.Size = new System.Drawing.Size(182, 20);
            this.txtVerSec.TabIndex = 20;
            this.txtVerSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVerSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVerSec_KeyPress);
            // 
            // txtDescSec
            // 
            this.txtDescSec.Location = new System.Drawing.Point(159, 155);
            this.txtDescSec.MaxLength = 50;
            this.txtDescSec.Multiline = true;
            this.txtDescSec.Name = "txtDescSec";
            this.txtDescSec.Size = new System.Drawing.Size(182, 20);
            this.txtDescSec.TabIndex = 21;
            this.txtDescSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescSec_KeyPress);
            // 
            // txtCodSec
            // 
            this.txtCodSec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodSec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodSec.Enabled = false;
            this.txtCodSec.Location = new System.Drawing.Point(159, 68);
            this.txtCodSec.Name = "txtCodSec";
            this.txtCodSec.Size = new System.Drawing.Size(182, 20);
            this.txtCodSec.TabIndex = 18;
            this.txtCodSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodSec_KeyPress);
            // 
            // dgvSeccionesVehiculo
            // 
            this.dgvSeccionesVehiculo.AllowUserToAddRows = false;
            this.dgvSeccionesVehiculo.AllowUserToDeleteRows = false;
            this.dgvSeccionesVehiculo.AutoGenerateColumns = false;
            this.dgvSeccionesVehiculo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSeccionesVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccionesVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSeccionDataGridViewTextBoxColumn,
            this.codProyectoDataGridViewTextBoxColumn,
            this.descSeccionDataGridViewTextBoxColumn,
            this.verSeccionDataGridViewTextBoxColumn});
            this.dgvSeccionesVehiculo.DataSource = this.secionesVehiulobindingSource;
            this.dgvSeccionesVehiculo.Location = new System.Drawing.Point(368, 68);
            this.dgvSeccionesVehiculo.Name = "dgvSeccionesVehiculo";
            this.dgvSeccionesVehiculo.ReadOnly = true;
            this.dgvSeccionesVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeccionesVehiculo.Size = new System.Drawing.Size(442, 409);
            this.dgvSeccionesVehiculo.TabIndex = 17;
            this.dgvSeccionesVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeccionesVehiculo_CellClick);
            // 
            // codSeccionDataGridViewTextBoxColumn
            // 
            this.codSeccionDataGridViewTextBoxColumn.DataPropertyName = "codSeccion";
            this.codSeccionDataGridViewTextBoxColumn.HeaderText = "Codigo de Seccion";
            this.codSeccionDataGridViewTextBoxColumn.Name = "codSeccionDataGridViewTextBoxColumn";
            this.codSeccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProyectoDataGridViewTextBoxColumn
            // 
            this.codProyectoDataGridViewTextBoxColumn.DataPropertyName = "codProyecto";
            this.codProyectoDataGridViewTextBoxColumn.HeaderText = "Codigo de Proyecto";
            this.codProyectoDataGridViewTextBoxColumn.Name = "codProyectoDataGridViewTextBoxColumn";
            this.codProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descSeccionDataGridViewTextBoxColumn
            // 
            this.descSeccionDataGridViewTextBoxColumn.DataPropertyName = "descSeccion";
            this.descSeccionDataGridViewTextBoxColumn.HeaderText = "Descripcion de Seccion";
            this.descSeccionDataGridViewTextBoxColumn.Name = "descSeccionDataGridViewTextBoxColumn";
            this.descSeccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verSeccionDataGridViewTextBoxColumn
            // 
            this.verSeccionDataGridViewTextBoxColumn.DataPropertyName = "verSeccion";
            this.verSeccionDataGridViewTextBoxColumn.HeaderText = "Version de Seccion";
            this.verSeccionDataGridViewTextBoxColumn.Name = "verSeccionDataGridViewTextBoxColumn";
            this.verSeccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secionesVehiulobindingSource
            // 
            this.secionesVehiulobindingSource.DataMember = "seccionesVehiculo";
            this.secionesVehiulobindingSource.DataSource = this.ges_v01DataSet2;
            // 
            // ges_v01DataSet2
            // 
            this.ges_v01DataSet2.DataSetName = "ges_v01DataSet2";
            this.ges_v01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Size = new System.Drawing.Size(837, 49);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button1.Location = new System.Drawing.Point(735, 0);
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
            this.btn_Salir.Location = new System.Drawing.Point(786, 0);
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
            this.label8.Size = new System.Drawing.Size(378, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "GESTOR DE SECCIONES DE VEHÍCULO";
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
            // seccionesVehiculoTableAdapter
            // 
            this.seccionesVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegCodSec
            // 
            this.btnRegCodSec.BackColor = System.Drawing.Color.Black;
            this.btnRegCodSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegCodSec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnRegCodSec.FlatAppearance.BorderSize = 0;
            this.btnRegCodSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnRegCodSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegCodSec.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegCodSec.ForeColor = System.Drawing.Color.White;
            this.btnRegCodSec.Location = new System.Drawing.Point(28, 260);
            this.btnRegCodSec.Name = "btnRegCodSec";
            this.btnRegCodSec.Size = new System.Drawing.Size(147, 51);
            this.btnRegCodSec.TabIndex = 53;
            this.btnRegCodSec.Text = "Registrar Seccion";
            this.btnRegCodSec.UseVisualStyleBackColor = false;
            this.btnRegCodSec.Click += new System.EventHandler(this.BtnRegCodSec_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(28, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 50);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar Seccion";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // btnModSecVeh
            // 
            this.btnModSecVeh.BackColor = System.Drawing.Color.Black;
            this.btnModSecVeh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModSecVeh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnModSecVeh.FlatAppearance.BorderSize = 0;
            this.btnModSecVeh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnModSecVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModSecVeh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnModSecVeh.ForeColor = System.Drawing.Color.White;
            this.btnModSecVeh.Location = new System.Drawing.Point(205, 328);
            this.btnModSecVeh.Name = "btnModSecVeh";
            this.btnModSecVeh.Size = new System.Drawing.Size(139, 50);
            this.btnModSecVeh.TabIndex = 58;
            this.btnModSecVeh.Text = "Modificar Seccion";
            this.btnModSecVeh.UseVisualStyleBackColor = false;
            this.btnModSecVeh.Click += new System.EventHandler(this.BtnModSecVeh_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(205, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 51);
            this.btnLimpiar.TabIndex = 57;
            this.btnLimpiar.Text = "Limpíar Panel";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // btnVerTod
            // 
            this.btnVerTod.BackColor = System.Drawing.Color.Black;
            this.btnVerTod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnVerTod.FlatAppearance.BorderSize = 0;
            this.btnVerTod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btnVerTod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTod.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerTod.ForeColor = System.Drawing.Color.White;
            this.btnVerTod.Location = new System.Drawing.Point(28, 407);
            this.btnVerTod.Name = "btnVerTod";
            this.btnVerTod.Size = new System.Drawing.Size(313, 70);
            this.btnVerTod.TabIndex = 61;
            this.btnVerTod.Text = "Ver todas las secciones";
            this.btnVerTod.UseVisualStyleBackColor = false;
            this.btnVerTod.Click += new System.EventHandler(this.BtnVerTod_Click);
            // 
            // cbCodProyecto
            // 
            this.cbCodProyecto.DataSource = this.modelosVehiculoBindingSource1;
            this.cbCodProyecto.DisplayMember = "nomModelo";
            this.cbCodProyecto.FormattingEnabled = true;
            this.cbCodProyecto.Location = new System.Drawing.Point(159, 111);
            this.cbCodProyecto.Name = "cbCodProyecto";
            this.cbCodProyecto.Size = new System.Drawing.Size(182, 21);
            this.cbCodProyecto.TabIndex = 62;
            this.cbCodProyecto.ValueMember = "codProyecto";
            // 
            // modelosVehiculoBindingSource
            // 
            this.modelosVehiculoBindingSource.DataMember = "modelosVehiculo";
            this.modelosVehiculoBindingSource.DataSource = this.ges_v01DataSet6;
            // 
            // ges_v01DataSet6
            // 
            this.ges_v01DataSet6.DataSetName = "ges_v01DataSet6";
            this.ges_v01DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelosVehiculoTableAdapter
            // 
            this.modelosVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProviderCodSeccion
            // 
            this.errorProviderCodSeccion.ContainerControl = this;
            // 
            // errorProviderVerSec
            // 
            this.errorProviderVerSec.ContainerControl = this;
            // 
            // ges_v01DataSet22NuevoProyecto
            // 
            this.ges_v01DataSet22NuevoProyecto.DataSetName = "ges_v01DataSet22NuevoProyecto";
            this.ges_v01DataSet22NuevoProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelosVehiculoBindingSource1
            // 
            this.modelosVehiculoBindingSource1.DataMember = "modelosVehiculo";
            this.modelosVehiculoBindingSource1.DataSource = this.ges_v01DataSet22NuevoProyecto;
            // 
            // modelosVehiculoTableAdapter1
            // 
            this.modelosVehiculoTableAdapter1.ClearBeforeFill = true;
            // 
            // SeccionesVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 495);
            this.Controls.Add(this.cbCodProyecto);
            this.Controls.Add(this.btnVerTod);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModSecVeh);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegCodSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerSec);
            this.Controls.Add(this.txtDescSec);
            this.Controls.Add(this.txtCodSec);
            this.Controls.Add(this.dgvSeccionesVehiculo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeccionesVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionesVehiculo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SeccionesVehiculo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SeccionesVehiculo_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccionesVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secionesVehiulobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelosVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVerSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet22NuevoProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosVehiculoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerSec;
        private System.Windows.Forms.TextBox txtDescSec;
        private System.Windows.Forms.TextBox txtCodSec;
        private System.Windows.Forms.DataGridView dgvSeccionesVehiculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource secionesVehiulobindingSource;
        private ges_v01DataSet2 ges_v01DataSet2;
        private ges_v01DataSet2TableAdapters.seccionesVehiculoTableAdapter seccionesVehiculoTableAdapter;
        private System.Windows.Forms.Button btnRegCodSec;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModSecVeh;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVerTod;
        private System.Windows.Forms.ComboBox cbCodProyecto;
        private ges_v01DataSet6 ges_v01DataSet6;
        private System.Windows.Forms.BindingSource modelosVehiculoBindingSource;
        private ges_v01DataSet6TableAdapters.modelosVehiculoTableAdapter modelosVehiculoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProviderCodSeccion;
        private System.Windows.Forms.ErrorProvider errorProviderVerSec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descSeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verSeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
        private ges_v01DataSet22NuevoProyecto ges_v01DataSet22NuevoProyecto;
        private System.Windows.Forms.BindingSource modelosVehiculoBindingSource1;
        private ges_v01DataSet22NuevoProyectoTableAdapters.modelosVehiculoTableAdapter modelosVehiculoTableAdapter1;
    }
}