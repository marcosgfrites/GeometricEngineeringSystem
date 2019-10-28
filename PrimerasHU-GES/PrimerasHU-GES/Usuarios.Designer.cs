namespace PrimerasHU_GES
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCodTipoUsu = new System.Windows.Forms.ComboBox();
            this.tiposUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet15 = new PrimerasHU_GES.ges_v01DataSet15();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVerUsuarios = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.botonModificarUsuario = new System.Windows.Forms.Button();
            this.botonLimpiarSeleccion = new System.Windows.Forms.Button();
            this.botonRegistrarUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet11 = new PrimerasHU_GES.ges_v01DataSet11();
            this.usuariosTableAdapter = new PrimerasHU_GES.ges_v01DataSet11TableAdapters.usuariosTableAdapter();
            this.ges_v01DataSet13 = new PrimerasHU_GES.ges_v01DataSet13();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new PrimerasHU_GES.ges_v01DataSet13TableAdapters.usuariosTableAdapter();
            this.tiposUsuarioTableAdapter = new PrimerasHU_GES.ges_v01DataSet15TableAdapters.tiposUsuarioTableAdapter();
            this.nomUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechoraUltSesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet15)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 49);
            this.panel1.TabIndex = 110;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(866, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PrimerasHU_GES.Properties.Resources.LOGOENCABEZADO_Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "GESTOR DE USUARIOS";
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
            this.btn_Salir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(930, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(64, 49);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Volver atrás";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvUsuarios);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 597);
            this.panel2.TabIndex = 116;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbCodTipoUsu);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtClaveUsuario);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtEstado);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.botonVerUsuarios);
            this.panel4.Controls.Add(this.botonEliminarUsuario);
            this.panel4.Controls.Add(this.botonModificarUsuario);
            this.panel4.Controls.Add(this.botonLimpiarSeleccion);
            this.panel4.Controls.Add(this.botonRegistrarUsuario);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtNombreUsuario);
            this.panel4.Controls.Add(this.txtCodigoUsuario);
            this.panel4.Location = new System.Drawing.Point(13, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 568);
            this.panel4.TabIndex = 105;
            // 
            // cbCodTipoUsu
            // 
            this.cbCodTipoUsu.DataSource = this.tiposUsuarioBindingSource;
            this.cbCodTipoUsu.DisplayMember = "descTipoUsu";
            this.cbCodTipoUsu.FormattingEnabled = true;
            this.cbCodTipoUsu.Location = new System.Drawing.Point(155, 53);
            this.cbCodTipoUsu.Name = "cbCodTipoUsu";
            this.cbCodTipoUsu.Size = new System.Drawing.Size(123, 21);
            this.cbCodTipoUsu.TabIndex = 117;
            this.cbCodTipoUsu.ValueMember = "descTipoUsu";
            // 
            // tiposUsuarioBindingSource
            // 
            this.tiposUsuarioBindingSource.DataMember = "tiposUsuario";
            this.tiposUsuarioBindingSource.DataSource = this.ges_v01DataSet15;
            // 
            // ges_v01DataSet15
            // 
            this.ges_v01DataSet15.DataSetName = "ges_v01DataSet15";
            this.ges_v01DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(41, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 52);
            this.panel3.TabIndex = 94;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Fecha y hora de la ultima Sesion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Clave de Usuario:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(155, 131);
            this.txtClaveUsuario.MaxLength = 16;
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtClaveUsuario.TabIndex = 80;
            this.txtClaveUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClaveUsuario.TextChanged += new System.EventHandler(this.TxtClaveUsuario_TextChanged);
            this.txtClaveUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtClaveUsuario_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEstado.Location = new System.Drawing.Point(155, 79);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 20);
            this.txtEstado.TabIndex = 78;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tipo de Usuario:";
            // 
            // botonVerUsuarios
            // 
            this.botonVerUsuarios.BackColor = System.Drawing.Color.Black;
            this.botonVerUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVerUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerUsuarios.ForeColor = System.Drawing.Color.White;
            this.botonVerUsuarios.Location = new System.Drawing.Point(20, 495);
            this.botonVerUsuarios.Name = "botonVerUsuarios";
            this.botonVerUsuarios.Size = new System.Drawing.Size(258, 52);
            this.botonVerUsuarios.TabIndex = 85;
            this.botonVerUsuarios.Text = "Ver Usuarios en el Panel    - - >";
            this.botonVerUsuarios.UseVisualStyleBackColor = false;
            this.botonVerUsuarios.Click += new System.EventHandler(this.BotonVerUsuarios_Click);
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.BackColor = System.Drawing.Color.Black;
            this.botonEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.botonEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.botonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.botonEliminarUsuario.Location = new System.Drawing.Point(20, 437);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(258, 52);
            this.botonEliminarUsuario.TabIndex = 83;
            this.botonEliminarUsuario.Text = "Eliminar Usuario";
            this.botonEliminarUsuario.UseVisualStyleBackColor = false;
            this.botonEliminarUsuario.Click += new System.EventHandler(this.BotonEliminarUsuario_Click);
            // 
            // botonModificarUsuario
            // 
            this.botonModificarUsuario.BackColor = System.Drawing.Color.Black;
            this.botonModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.botonModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.botonModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.botonModificarUsuario.Location = new System.Drawing.Point(20, 321);
            this.botonModificarUsuario.Name = "botonModificarUsuario";
            this.botonModificarUsuario.Size = new System.Drawing.Size(258, 52);
            this.botonModificarUsuario.TabIndex = 82;
            this.botonModificarUsuario.Text = "Modificar Usuario";
            this.botonModificarUsuario.UseVisualStyleBackColor = false;
            this.botonModificarUsuario.Click += new System.EventHandler(this.BotonModificarUsuario_Click);
            // 
            // botonLimpiarSeleccion
            // 
            this.botonLimpiarSeleccion.BackColor = System.Drawing.Color.Black;
            this.botonLimpiarSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLimpiarSeleccion.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonLimpiarSeleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonLimpiarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLimpiarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonLimpiarSeleccion.ForeColor = System.Drawing.Color.White;
            this.botonLimpiarSeleccion.Location = new System.Drawing.Point(20, 379);
            this.botonLimpiarSeleccion.Name = "botonLimpiarSeleccion";
            this.botonLimpiarSeleccion.Size = new System.Drawing.Size(258, 52);
            this.botonLimpiarSeleccion.TabIndex = 81;
            this.botonLimpiarSeleccion.Text = "Limpiar Panel";
            this.botonLimpiarSeleccion.UseVisualStyleBackColor = false;
            this.botonLimpiarSeleccion.Click += new System.EventHandler(this.BotonLimpiarSeleccion_Click);
            // 
            // botonRegistrarUsuario
            // 
            this.botonRegistrarUsuario.BackColor = System.Drawing.Color.Black;
            this.botonRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegistrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.botonRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.botonRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.botonRegistrarUsuario.Location = new System.Drawing.Point(20, 263);
            this.botonRegistrarUsuario.Name = "botonRegistrarUsuario";
            this.botonRegistrarUsuario.Size = new System.Drawing.Size(258, 52);
            this.botonRegistrarUsuario.TabIndex = 80;
            this.botonRegistrarUsuario.Text = "Registrar Usuario";
            this.botonRegistrarUsuario.UseVisualStyleBackColor = false;
            this.botonRegistrarUsuario.Click += new System.EventHandler(this.BotonRegistrarUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Codigo de Usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(155, 105);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtNombreUsuario.TabIndex = 79;
            this.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoUsuario.Enabled = false;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(155, 27);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoUsuario.TabIndex = 76;
            this.txtCodigoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomUsuDataGridViewTextBoxColumn,
            this.codUsuDataGridViewTextBoxColumn,
            this.claveUsuDataGridViewTextBoxColumn,
            this.codEstadoDataGridViewTextBoxColumn,
            this.codTipoUsuDataGridViewTextBoxColumn,
            this.fechoraUltSesionDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuariosBindingSource;
            this.dgvUsuarios.Location = new System.Drawing.Point(313, 14);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(647, 568);
            this.dgvUsuarios.TabIndex = 108;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.ges_v01DataSet11;
            // 
            // ges_v01DataSet11
            // 
            this.ges_v01DataSet11.DataSetName = "ges_v01DataSet11";
            this.ges_v01DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ges_v01DataSet13
            // 
            this.ges_v01DataSet13.DataSetName = "ges_v01DataSet13";
            this.ges_v01DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.ges_v01DataSet13;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // tiposUsuarioTableAdapter
            // 
            this.tiposUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // nomUsuDataGridViewTextBoxColumn
            // 
            this.nomUsuDataGridViewTextBoxColumn.DataPropertyName = "nomUsu";
            this.nomUsuDataGridViewTextBoxColumn.HeaderText = "Nombre de Usuario";
            this.nomUsuDataGridViewTextBoxColumn.Name = "nomUsuDataGridViewTextBoxColumn";
            this.nomUsuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codUsuDataGridViewTextBoxColumn
            // 
            this.codUsuDataGridViewTextBoxColumn.DataPropertyName = "codUsu";
            this.codUsuDataGridViewTextBoxColumn.HeaderText = "Codigo de Usuario";
            this.codUsuDataGridViewTextBoxColumn.Name = "codUsuDataGridViewTextBoxColumn";
            this.codUsuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claveUsuDataGridViewTextBoxColumn
            // 
            this.claveUsuDataGridViewTextBoxColumn.DataPropertyName = "claveUsu";
            this.claveUsuDataGridViewTextBoxColumn.HeaderText = "Clave de Usuario";
            this.claveUsuDataGridViewTextBoxColumn.Name = "claveUsuDataGridViewTextBoxColumn";
            this.claveUsuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codEstadoDataGridViewTextBoxColumn
            // 
            this.codEstadoDataGridViewTextBoxColumn.DataPropertyName = "codEstado";
            this.codEstadoDataGridViewTextBoxColumn.HeaderText = "Codigo de  Estado";
            this.codEstadoDataGridViewTextBoxColumn.Name = "codEstadoDataGridViewTextBoxColumn";
            this.codEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTipoUsuDataGridViewTextBoxColumn
            // 
            this.codTipoUsuDataGridViewTextBoxColumn.DataPropertyName = "codTipoUsu";
            this.codTipoUsuDataGridViewTextBoxColumn.HeaderText = "Codigo de Tipo de Usuario";
            this.codTipoUsuDataGridViewTextBoxColumn.Name = "codTipoUsuDataGridViewTextBoxColumn";
            this.codTipoUsuDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTipoUsuDataGridViewTextBoxColumn.Width = 70;
            // 
            // fechoraUltSesionDataGridViewTextBoxColumn
            // 
            this.fechoraUltSesionDataGridViewTextBoxColumn.DataPropertyName = "fechoraUltSesion";
            this.fechoraUltSesionDataGridViewTextBoxColumn.HeaderText = "fecha y hora de la Ultima Sesion";
            this.fechoraUltSesionDataGridViewTextBoxColumn.Name = "fechoraUltSesionDataGridViewTextBoxColumn";
            this.fechoraUltSesionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(994, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Usuarios_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet15)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVerUsuarios;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.Button botonModificarUsuario;
        private System.Windows.Forms.Button botonLimpiarSeleccion;
        private System.Windows.Forms.Button botonRegistrarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private ges_v01DataSet11 ges_v01DataSet11;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ges_v01DataSet11TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCodTipoUsu;
        private ges_v01DataSet13 ges_v01DataSet13;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private ges_v01DataSet13TableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private ges_v01DataSet15 ges_v01DataSet15;
        private System.Windows.Forms.BindingSource tiposUsuarioBindingSource;
        private ges_v01DataSet15TableAdapters.tiposUsuarioTableAdapter tiposUsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechoraUltSesionDataGridViewTextBoxColumn;
    }
}