namespace PrimerasHU_GES
{
    partial class Programas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_programas = new System.Windows.Forms.DataGridView();
            this.codProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaquinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecActualizProgramaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSetProgramas = new PrimerasHU_GES.ges_v01DataSetProgramas();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_revision = new System.Windows.Forms.NumericUpDown();
            this.cb_maquina = new System.Windows.Forms.ComboBox();
            this.maquinasMedicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSetMaquinas = new PrimerasHU_GES.ges_v01DataSetMaquinas();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maquinasMedicionTableAdapter = new PrimerasHU_GES.ges_v01DataSetMaquinasTableAdapters.maquinasMedicionTableAdapter();
            this.programasTableAdapter = new PrimerasHU_GES.ges_v01DataSetProgramasTableAdapters.programasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_programas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetProgramas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_revision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasMedicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetMaquinas)).BeginInit();
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
            this.pictureBox1.Size = new System.Drawing.Size(64, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 49);
            this.panel1.TabIndex = 137;
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
            this.button1.Location = new System.Drawing.Point(668, 0);
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
            this.btn_Salir.Location = new System.Drawing.Point(719, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "GESTOR DE PROGRAMAS";
            // 
            // dgv_programas
            // 
            this.dgv_programas.AllowUserToAddRows = false;
            this.dgv_programas.AllowUserToDeleteRows = false;
            this.dgv_programas.AllowUserToResizeColumns = false;
            this.dgv_programas.AllowUserToResizeRows = false;
            this.dgv_programas.AutoGenerateColumns = false;
            this.dgv_programas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_programas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_programas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_programas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProgramaDataGridViewTextBoxColumn,
            this.codMaquinaDataGridViewTextBoxColumn,
            this.descProgramaDataGridViewTextBoxColumn,
            this.revProgramaDataGridViewTextBoxColumn,
            this.fecActualizProgramaDataGridViewTextBoxColumn});
            this.dgv_programas.DataSource = this.programasBindingSource;
            this.dgv_programas.Location = new System.Drawing.Point(330, 55);
            this.dgv_programas.MultiSelect = false;
            this.dgv_programas.Name = "dgv_programas";
            this.dgv_programas.ReadOnly = true;
            this.dgv_programas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_programas.Size = new System.Drawing.Size(428, 192);
            this.dgv_programas.TabIndex = 138;
            this.dgv_programas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_programas_CellContentClick);
            // 
            // codProgramaDataGridViewTextBoxColumn
            // 
            this.codProgramaDataGridViewTextBoxColumn.DataPropertyName = "codPrograma";
            this.codProgramaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codProgramaDataGridViewTextBoxColumn.Name = "codProgramaDataGridViewTextBoxColumn";
            this.codProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProgramaDataGridViewTextBoxColumn.Width = 65;
            // 
            // codMaquinaDataGridViewTextBoxColumn
            // 
            this.codMaquinaDataGridViewTextBoxColumn.DataPropertyName = "codMaquina";
            this.codMaquinaDataGridViewTextBoxColumn.HeaderText = "Cód. Máquina de Medición";
            this.codMaquinaDataGridViewTextBoxColumn.Name = "codMaquinaDataGridViewTextBoxColumn";
            this.codMaquinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMaquinaDataGridViewTextBoxColumn.Width = 106;
            // 
            // descProgramaDataGridViewTextBoxColumn
            // 
            this.descProgramaDataGridViewTextBoxColumn.DataPropertyName = "descPrograma";
            this.descProgramaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.descProgramaDataGridViewTextBoxColumn.Name = "descProgramaDataGridViewTextBoxColumn";
            this.descProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descProgramaDataGridViewTextBoxColumn.Width = 69;
            // 
            // revProgramaDataGridViewTextBoxColumn
            // 
            this.revProgramaDataGridViewTextBoxColumn.DataPropertyName = "revPrograma";
            this.revProgramaDataGridViewTextBoxColumn.HeaderText = "Revisión";
            this.revProgramaDataGridViewTextBoxColumn.Name = "revProgramaDataGridViewTextBoxColumn";
            this.revProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            this.revProgramaDataGridViewTextBoxColumn.Width = 73;
            // 
            // fecActualizProgramaDataGridViewTextBoxColumn
            // 
            this.fecActualizProgramaDataGridViewTextBoxColumn.DataPropertyName = "fecActualizPrograma";
            this.fecActualizProgramaDataGridViewTextBoxColumn.HeaderText = "Fecha Crea./Modif.";
            this.fecActualizProgramaDataGridViewTextBoxColumn.Name = "fecActualizProgramaDataGridViewTextBoxColumn";
            this.fecActualizProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fecActualizProgramaDataGridViewTextBoxColumn.Width = 114;
            // 
            // programasBindingSource
            // 
            this.programasBindingSource.DataMember = "programas";
            this.programasBindingSource.DataSource = this.ges_v01DataSetProgramas;
            // 
            // ges_v01DataSetProgramas
            // 
            this.ges_v01DataSetProgramas.DataSetName = "ges_v01DataSetProgramas";
            this.ges_v01DataSetProgramas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Black;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(576, 264);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(180, 23);
            this.btn_limpiar.TabIndex = 146;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Black;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(387, 264);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(180, 23);
            this.btn_eliminar.TabIndex = 145;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Black;
            this.btn_modificar.Enabled = false;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(201, 264);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(180, 23);
            this.btn_modificar.TabIndex = 144;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Black;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(12, 264);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(180, 23);
            this.btn_registrar.TabIndex = 143;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nud_revision);
            this.panel2.Controls.Add(this.cb_maquina);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.txt_codigo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 192);
            this.panel2.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Revisión:";
            // 
            // nud_revision
            // 
            this.nud_revision.Location = new System.Drawing.Point(17, 154);
            this.nud_revision.Name = "nud_revision";
            this.nud_revision.Size = new System.Drawing.Size(274, 20);
            this.nud_revision.TabIndex = 6;
            this.nud_revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_maquina
            // 
            this.cb_maquina.DataSource = this.maquinasMedicionBindingSource;
            this.cb_maquina.DisplayMember = "nombreMaquina";
            this.cb_maquina.FormattingEnabled = true;
            this.cb_maquina.Location = new System.Drawing.Point(17, 114);
            this.cb_maquina.Name = "cb_maquina";
            this.cb_maquina.Size = new System.Drawing.Size(274, 21);
            this.cb_maquina.TabIndex = 5;
            this.cb_maquina.ValueMember = "codMaquina";
            // 
            // maquinasMedicionBindingSource
            // 
            this.maquinasMedicionBindingSource.DataMember = "maquinasMedicion";
            this.maquinasMedicionBindingSource.DataSource = this.ges_v01DataSetMaquinas;
            // 
            // ges_v01DataSetMaquinas
            // 
            this.ges_v01DataSetMaquinas.DataSetName = "ges_v01DataSetMaquinas";
            this.ges_v01DataSetMaquinas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Máquina:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(17, 70);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(274, 20);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(17, 30);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(274, 20);
            this.txt_codigo.TabIndex = 2;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre/Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // maquinasMedicionTableAdapter
            // 
            this.maquinasMedicionTableAdapter.ClearBeforeFill = true;
            // 
            // programasTableAdapter
            // 
            this.programasTableAdapter.ClearBeforeFill = true;
            // 
            // Programas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.dgv_programas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Programas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programas";
            this.Load += new System.EventHandler(this.Programas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Programas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_programas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetProgramas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_revision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasMedicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetMaquinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_programas;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_revision;
        private System.Windows.Forms.ComboBox cb_maquina;
        private System.Windows.Forms.Label label4;
        private ges_v01DataSetMaquinas ges_v01DataSetMaquinas;
        private System.Windows.Forms.BindingSource maquinasMedicionBindingSource;
        private ges_v01DataSetMaquinasTableAdapters.maquinasMedicionTableAdapter maquinasMedicionTableAdapter;
        private ges_v01DataSetProgramas ges_v01DataSetProgramas;
        private System.Windows.Forms.BindingSource programasBindingSource;
        private ges_v01DataSetProgramasTableAdapters.programasTableAdapter programasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaquinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecActualizProgramaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
    }
}