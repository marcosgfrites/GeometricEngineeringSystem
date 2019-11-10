namespace PrimerasHU_GES
{
    partial class CalculoMarcos
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_muestras = new System.Windows.Forms.DataGridView();
            this.dgv_listaPuntos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_muestra = new System.Windows.Forms.Label();
            this.dgv_nombrePuntos = new System.Windows.Forms.DataGridView();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.dgv_calculos = new System.Windows.Forms.DataGridView();
            this.nombrePunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangoFlotante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpkInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpkSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_datosPunto = new System.Windows.Forms.DataGridView();
            this.pBar_calcular = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_calculos = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cpkRojo = new System.Windows.Forms.TextBox();
            this.txt_cpkVerde = new System.Windows.Forms.TextBox();
            this.txt_cpkAmarillo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_puntosF = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_muestraF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidadF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cpRojo = new System.Windows.Forms.TextBox();
            this.txt_cpVerde = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cpAmarillo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nombrePuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosPunto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_calculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puntosF)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PrimerasHU_GES.Properties.Resources.LOGOENCABEZADO_Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "GESTOR DE CÁLCULOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 49);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
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
            this.btn_Salir.Location = new System.Drawing.Point(1259, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione la \'Muestra\' a trabajar:";
            // 
            // dgv_muestras
            // 
            this.dgv_muestras.AllowUserToAddRows = false;
            this.dgv_muestras.AllowUserToDeleteRows = false;
            this.dgv_muestras.AllowUserToResizeColumns = false;
            this.dgv_muestras.AllowUserToResizeRows = false;
            this.dgv_muestras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_muestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestras.Location = new System.Drawing.Point(6, 19);
            this.dgv_muestras.MultiSelect = false;
            this.dgv_muestras.Name = "dgv_muestras";
            this.dgv_muestras.ReadOnly = true;
            this.dgv_muestras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_muestras.Size = new System.Drawing.Size(386, 80);
            this.dgv_muestras.TabIndex = 6;
            this.dgv_muestras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_muestras_CellContentClick);
            // 
            // dgv_listaPuntos
            // 
            this.dgv_listaPuntos.AllowUserToAddRows = false;
            this.dgv_listaPuntos.AllowUserToDeleteRows = false;
            this.dgv_listaPuntos.AllowUserToResizeColumns = false;
            this.dgv_listaPuntos.AllowUserToResizeRows = false;
            this.dgv_listaPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listaPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaPuntos.Location = new System.Drawing.Point(6, 144);
            this.dgv_listaPuntos.MultiSelect = false;
            this.dgv_listaPuntos.Name = "dgv_listaPuntos";
            this.dgv_listaPuntos.ReadOnly = true;
            this.dgv_listaPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaPuntos.Size = new System.Drawing.Size(386, 439);
            this.dgv_listaPuntos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntos relacionados a la \'Muestra\' seleccionada:";
            // 
            // lbl_muestra
            // 
            this.lbl_muestra.AutoSize = true;
            this.lbl_muestra.Location = new System.Drawing.Point(246, 128);
            this.lbl_muestra.Name = "lbl_muestra";
            this.lbl_muestra.Size = new System.Drawing.Size(0, 13);
            this.lbl_muestra.TabIndex = 11;
            this.lbl_muestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_nombrePuntos
            // 
            this.dgv_nombrePuntos.AllowUserToAddRows = false;
            this.dgv_nombrePuntos.AllowUserToDeleteRows = false;
            this.dgv_nombrePuntos.AllowUserToResizeColumns = false;
            this.dgv_nombrePuntos.AllowUserToResizeRows = false;
            this.dgv_nombrePuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nombrePuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nombrePuntos.Location = new System.Drawing.Point(6, 589);
            this.dgv_nombrePuntos.MultiSelect = false;
            this.dgv_nombrePuntos.Name = "dgv_nombrePuntos";
            this.dgv_nombrePuntos.ReadOnly = true;
            this.dgv_nombrePuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nombrePuntos.Size = new System.Drawing.Size(34, 41);
            this.dgv_nombrePuntos.TabIndex = 12;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Black;
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(317, 599);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 20;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // dgv_calculos
            // 
            this.dgv_calculos.AllowUserToAddRows = false;
            this.dgv_calculos.AllowUserToDeleteRows = false;
            this.dgv_calculos.AllowUserToResizeColumns = false;
            this.dgv_calculos.AllowUserToResizeRows = false;
            this.dgv_calculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_calculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePunto,
            this.rangoFlotante,
            this.media,
            this.sigma,
            this.cp,
            this.cpkInf,
            this.cpkSup,
            this.cpk});
            this.dgv_calculos.Location = new System.Drawing.Point(432, 19);
            this.dgv_calculos.MultiSelect = false;
            this.dgv_calculos.Name = "dgv_calculos";
            this.dgv_calculos.ReadOnly = true;
            this.dgv_calculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_calculos.Size = new System.Drawing.Size(847, 438);
            this.dgv_calculos.TabIndex = 21;
            this.dgv_calculos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_calculos_RowsAdded);
            // 
            // nombrePunto
            // 
            this.nombrePunto.HeaderText = "Nombre del Punto";
            this.nombrePunto.Name = "nombrePunto";
            this.nombrePunto.ReadOnly = true;
            // 
            // rangoFlotante
            // 
            this.rangoFlotante.HeaderText = "Rango Flotante";
            this.rangoFlotante.Name = "rangoFlotante";
            this.rangoFlotante.ReadOnly = true;
            // 
            // media
            // 
            this.media.HeaderText = "Media";
            this.media.Name = "media";
            this.media.ReadOnly = true;
            // 
            // sigma
            // 
            this.sigma.HeaderText = "Sigma";
            this.sigma.Name = "sigma";
            this.sigma.ReadOnly = true;
            // 
            // cp
            // 
            this.cp.HeaderText = "Cp";
            this.cp.Name = "cp";
            this.cp.ReadOnly = true;
            // 
            // cpkInf
            // 
            this.cpkInf.HeaderText = "Cpk (Inferior)";
            this.cpkInf.Name = "cpkInf";
            this.cpkInf.ReadOnly = true;
            // 
            // cpkSup
            // 
            this.cpkSup.HeaderText = "Cpk (Superior)";
            this.cpkSup.Name = "cpkSup";
            this.cpkSup.ReadOnly = true;
            // 
            // cpk
            // 
            this.cpk.HeaderText = "Cpk";
            this.cpk.Name = "cpk";
            this.cpk.ReadOnly = true;
            // 
            // dgv_datosPunto
            // 
            this.dgv_datosPunto.AllowUserToAddRows = false;
            this.dgv_datosPunto.AllowUserToDeleteRows = false;
            this.dgv_datosPunto.AllowUserToResizeColumns = false;
            this.dgv_datosPunto.AllowUserToResizeRows = false;
            this.dgv_datosPunto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datosPunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datosPunto.Location = new System.Drawing.Point(46, 589);
            this.dgv_datosPunto.MultiSelect = false;
            this.dgv_datosPunto.Name = "dgv_datosPunto";
            this.dgv_datosPunto.ReadOnly = true;
            this.dgv_datosPunto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datosPunto.Size = new System.Drawing.Size(34, 41);
            this.dgv_datosPunto.TabIndex = 22;
            // 
            // pBar_calcular
            // 
            this.pBar_calcular.Location = new System.Drawing.Point(86, 599);
            this.pBar_calcular.Name = "pBar_calcular";
            this.pBar_calcular.Size = new System.Drawing.Size(225, 23);
            this.pBar_calcular.Step = 1;
            this.pBar_calcular.TabIndex = 23;
            this.pBar_calcular.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1295, 662);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.panel_calculos);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbl_muestra);
            this.tabPage2.Controls.Add(this.pBar_calcular);
            this.tabPage2.Controls.Add(this.dgv_muestras);
            this.tabPage2.Controls.Add(this.dgv_datosPunto);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgv_calculos);
            this.tabPage2.Controls.Add(this.dgv_listaPuntos);
            this.tabPage2.Controls.Add(this.btn_calcular);
            this.tabPage2.Controls.Add(this.dgv_nombrePuntos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1287, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cálculos de Muestra";
            // 
            // panel_calculos
            // 
            this.panel_calculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_calculos.Controls.Add(this.label8);
            this.panel_calculos.Controls.Add(this.label10);
            this.panel_calculos.Controls.Add(this.label11);
            this.panel_calculos.Controls.Add(this.txt_cpkRojo);
            this.panel_calculos.Controls.Add(this.txt_cpkVerde);
            this.panel_calculos.Controls.Add(this.txt_cpkAmarillo);
            this.panel_calculos.Controls.Add(this.label7);
            this.panel_calculos.Controls.Add(this.label6);
            this.panel_calculos.Controls.Add(this.dgv_puntosF);
            this.panel_calculos.Controls.Add(this.txt_muestraF);
            this.panel_calculos.Controls.Add(this.label3);
            this.panel_calculos.Controls.Add(this.txt_cantidadF);
            this.panel_calculos.Controls.Add(this.label5);
            this.panel_calculos.Controls.Add(this.txt_cpRojo);
            this.panel_calculos.Controls.Add(this.txt_cpVerde);
            this.panel_calculos.Controls.Add(this.label12);
            this.panel_calculos.Controls.Add(this.txt_cpAmarillo);
            this.panel_calculos.Controls.Add(this.label9);
            this.panel_calculos.Location = new System.Drawing.Point(432, 463);
            this.panel_calculos.Name = "panel_calculos";
            this.panel_calculos.Size = new System.Drawing.Size(847, 159);
            this.panel_calculos.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "1.00 > CPK >= 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "1.33 > CPK >= 1.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "CPK >= 1.33";
            // 
            // txt_cpkRojo
            // 
            this.txt_cpkRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_cpkRojo.Enabled = false;
            this.txt_cpkRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpkRojo.ForeColor = System.Drawing.Color.Black;
            this.txt_cpkRojo.Location = new System.Drawing.Point(377, 130);
            this.txt_cpkRojo.Name = "txt_cpkRojo";
            this.txt_cpkRojo.Size = new System.Drawing.Size(149, 21);
            this.txt_cpkRojo.TabIndex = 25;
            this.txt_cpkRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cpkVerde
            // 
            this.txt_cpkVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_cpkVerde.Enabled = false;
            this.txt_cpkVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpkVerde.ForeColor = System.Drawing.Color.Black;
            this.txt_cpkVerde.Location = new System.Drawing.Point(377, 76);
            this.txt_cpkVerde.Name = "txt_cpkVerde";
            this.txt_cpkVerde.Size = new System.Drawing.Size(149, 21);
            this.txt_cpkVerde.TabIndex = 24;
            this.txt_cpkVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cpkAmarillo
            // 
            this.txt_cpkAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_cpkAmarillo.Enabled = false;
            this.txt_cpkAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpkAmarillo.ForeColor = System.Drawing.Color.Black;
            this.txt_cpkAmarillo.Location = new System.Drawing.Point(377, 103);
            this.txt_cpkAmarillo.Name = "txt_cpkAmarillo";
            this.txt_cpkAmarillo.Size = new System.Drawing.Size(149, 21);
            this.txt_cpkAmarillo.TabIndex = 22;
            this.txt_cpkAmarillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "1.00 > CP >= 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "1.33 > CP >= 1.00";
            // 
            // dgv_puntosF
            // 
            this.dgv_puntosF.AllowUserToAddRows = false;
            this.dgv_puntosF.AllowUserToDeleteRows = false;
            this.dgv_puntosF.AllowUserToResizeColumns = false;
            this.dgv_puntosF.AllowUserToResizeRows = false;
            this.dgv_puntosF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_puntosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puntosF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_puntosF.Location = new System.Drawing.Point(607, 20);
            this.dgv_puntosF.Name = "dgv_puntosF";
            this.dgv_puntosF.ReadOnly = true;
            this.dgv_puntosF.Size = new System.Drawing.Size(233, 127);
            this.dgv_puntosF.TabIndex = 19;
            this.dgv_puntosF.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Puntos F (Semáforo)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txt_muestraF
            // 
            this.txt_muestraF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_muestraF.Enabled = false;
            this.txt_muestraF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_muestraF.ForeColor = System.Drawing.Color.Black;
            this.txt_muestraF.Location = new System.Drawing.Point(111, 19);
            this.txt_muestraF.Name = "txt_muestraF";
            this.txt_muestraF.Size = new System.Drawing.Size(149, 21);
            this.txt_muestraF.TabIndex = 18;
            this.txt_muestraF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "> MUESTRA NRO.:";
            // 
            // txt_cantidadF
            // 
            this.txt_cantidadF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_cantidadF.Enabled = false;
            this.txt_cantidadF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadF.ForeColor = System.Drawing.Color.Black;
            this.txt_cantidadF.Location = new System.Drawing.Point(436, 20);
            this.txt_cantidadF.Name = "txt_cantidadF";
            this.txt_cantidadF.Size = new System.Drawing.Size(149, 21);
            this.txt_cantidadF.TabIndex = 16;
            this.txt_cantidadF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "> CANTIDAD DE PUNTOS \'F\':";
            // 
            // txt_cpRojo
            // 
            this.txt_cpRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_cpRojo.Enabled = false;
            this.txt_cpRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpRojo.ForeColor = System.Drawing.Color.Black;
            this.txt_cpRojo.Location = new System.Drawing.Point(102, 130);
            this.txt_cpRojo.Name = "txt_cpRojo";
            this.txt_cpRojo.Size = new System.Drawing.Size(149, 21);
            this.txt_cpRojo.TabIndex = 6;
            this.txt_cpRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cpVerde
            // 
            this.txt_cpVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_cpVerde.Enabled = false;
            this.txt_cpVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpVerde.ForeColor = System.Drawing.Color.Black;
            this.txt_cpVerde.Location = new System.Drawing.Point(102, 76);
            this.txt_cpVerde.Name = "txt_cpVerde";
            this.txt_cpVerde.Size = new System.Drawing.Size(149, 21);
            this.txt_cpVerde.TabIndex = 4;
            this.txt_cpVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "CP >= 1.33";
            // 
            // txt_cpAmarillo
            // 
            this.txt_cpAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_cpAmarillo.Enabled = false;
            this.txt_cpAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpAmarillo.ForeColor = System.Drawing.Color.Black;
            this.txt_cpAmarillo.Location = new System.Drawing.Point(102, 103);
            this.txt_cpAmarillo.Name = "txt_cpAmarillo";
            this.txt_cpAmarillo.Size = new System.Drawing.Size(149, 21);
            this.txt_cpAmarillo.TabIndex = 2;
            this.txt_cpAmarillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(354, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "CÁLCULOS ESTADÍSTICOS (Puntos F - Semáforo)";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1287, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cálculos Personalizados";
            // 
            // CalculoMarcos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1310, 718);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculoMarcos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculoMarcos";
            this.Load += new System.EventHandler(this.CalculoMarcos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nombrePuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosPunto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_calculos.ResumeLayout(false);
            this.panel_calculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puntosF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_muestras;
        private System.Windows.Forms.DataGridView dgv_listaPuntos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_muestra;
        private System.Windows.Forms.DataGridView dgv_nombrePuntos;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.DataGridView dgv_calculos;
        private System.Windows.Forms.DataGridView dgv_datosPunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangoFlotante;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpkInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpkSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpk;
        private System.Windows.Forms.ProgressBar pBar_calcular;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_calculos;
        private System.Windows.Forms.TextBox txt_cpRojo;
        private System.Windows.Forms.TextBox txt_cpVerde;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cpAmarillo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_muestraF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidadF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_puntosF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cpkRojo;
        private System.Windows.Forms.TextBox txt_cpkVerde;
        private System.Windows.Forms.TextBox txt_cpkAmarillo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}