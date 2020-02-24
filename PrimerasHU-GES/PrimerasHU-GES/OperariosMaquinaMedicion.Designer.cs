namespace PrimerasHU_GES
{
    partial class OperariosMaquinaMedicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperariosMaquinaMedicion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonVerOperarios = new System.Windows.Forms.Button();
            this.btnEliminarOperario = new System.Windows.Forms.Button();
            this.btnModOperario = new System.Windows.Forms.Button();
            this.btnLimpiarOperario = new System.Windows.Forms.Button();
            this.btnRegOperario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreOperario = new System.Windows.Forms.TextBox();
            this.txtCodigoOperario = new System.Windows.Forms.TextBox();
            this.dgvOperarios = new System.Windows.Forms.DataGridView();
            this.codOperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomOperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operariosMaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet8 = new PrimerasHU_GES.ges_v01DataSet8();
            this.operariosMaquinaTableAdapter = new PrimerasHU_GES.ges_v01DataSet8TableAdapters.operariosMaquinaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operariosMaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet8)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(738, 49);
            this.panel1.TabIndex = 109;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "GESTOR DE OPERARIOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(652, 42);
            this.label6.TabIndex = 116;
            this.label6.Text = "Operarios de Maquinas de Medicion";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvOperarios);
            this.panel2.Location = new System.Drawing.Point(49, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 463);
            this.panel2.TabIndex = 115;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.botonVerOperarios);
            this.panel4.Controls.Add(this.btnEliminarOperario);
            this.panel4.Controls.Add(this.btnModOperario);
            this.panel4.Controls.Add(this.btnLimpiarOperario);
            this.panel4.Controls.Add(this.btnRegOperario);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtNombreOperario);
            this.panel4.Controls.Add(this.txtCodigoOperario);
            this.panel4.Location = new System.Drawing.Point(25, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 423);
            this.panel4.TabIndex = 105;
            // 
            // botonVerOperarios
            // 
            this.botonVerOperarios.BackColor = System.Drawing.Color.Black;
            this.botonVerOperarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVerOperarios.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerOperarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.botonVerOperarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerOperarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botonVerOperarios.ForeColor = System.Drawing.Color.White;
            this.botonVerOperarios.Location = new System.Drawing.Point(25, 354);
            this.botonVerOperarios.Name = "botonVerOperarios";
            this.botonVerOperarios.Size = new System.Drawing.Size(215, 36);
            this.botonVerOperarios.TabIndex = 85;
            this.botonVerOperarios.Text = "Ver Operarios en Panel";
            this.botonVerOperarios.UseVisualStyleBackColor = false;
            this.botonVerOperarios.Click += new System.EventHandler(this.BotonVerOperarios_Click);
            // 
            // btnEliminarOperario
            // 
            this.btnEliminarOperario.BackColor = System.Drawing.Color.Black;
            this.btnEliminarOperario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarOperario.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEliminarOperario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarOperario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarOperario.Location = new System.Drawing.Point(25, 312);
            this.btnEliminarOperario.Name = "btnEliminarOperario";
            this.btnEliminarOperario.Size = new System.Drawing.Size(215, 36);
            this.btnEliminarOperario.TabIndex = 83;
            this.btnEliminarOperario.Text = "Eliminar Operario";
            this.btnEliminarOperario.UseVisualStyleBackColor = false;
            this.btnEliminarOperario.Click += new System.EventHandler(this.BtnEliminarOperario_Click);
            // 
            // btnModOperario
            // 
            this.btnModOperario.BackColor = System.Drawing.Color.Black;
            this.btnModOperario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModOperario.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnModOperario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModOperario.ForeColor = System.Drawing.Color.White;
            this.btnModOperario.Location = new System.Drawing.Point(25, 228);
            this.btnModOperario.Name = "btnModOperario";
            this.btnModOperario.Size = new System.Drawing.Size(215, 36);
            this.btnModOperario.TabIndex = 82;
            this.btnModOperario.Text = "Modificar Operario";
            this.btnModOperario.UseVisualStyleBackColor = false;
            this.btnModOperario.Click += new System.EventHandler(this.BtnModOperario_Click);
            // 
            // btnLimpiarOperario
            // 
            this.btnLimpiarOperario.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarOperario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarOperario.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarOperario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiarOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarOperario.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarOperario.Location = new System.Drawing.Point(25, 270);
            this.btnLimpiarOperario.Name = "btnLimpiarOperario";
            this.btnLimpiarOperario.Size = new System.Drawing.Size(215, 36);
            this.btnLimpiarOperario.TabIndex = 81;
            this.btnLimpiarOperario.Text = "Limpíar seleccion";
            this.btnLimpiarOperario.UseVisualStyleBackColor = false;
            this.btnLimpiarOperario.Click += new System.EventHandler(this.BtnLimpiarOperario_Click);
            // 
            // btnRegOperario
            // 
            this.btnRegOperario.BackColor = System.Drawing.Color.Black;
            this.btnRegOperario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegOperario.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegOperario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegOperario.ForeColor = System.Drawing.Color.White;
            this.btnRegOperario.Location = new System.Drawing.Point(25, 186);
            this.btnRegOperario.Name = "btnRegOperario";
            this.btnRegOperario.Size = new System.Drawing.Size(215, 36);
            this.btnRegOperario.TabIndex = 80;
            this.btnRegOperario.Text = "Registrar Operario";
            this.btnRegOperario.UseVisualStyleBackColor = false;
            this.btnRegOperario.Click += new System.EventHandler(this.BtnRegOperario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nombre de Operario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Codigo de Operario:";
            // 
            // txtNombreOperario
            // 
            this.txtNombreOperario.Location = new System.Drawing.Point(25, 127);
            this.txtNombreOperario.Name = "txtNombreOperario";
            this.txtNombreOperario.Size = new System.Drawing.Size(215, 20);
            this.txtNombreOperario.TabIndex = 77;
            this.txtNombreOperario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigoOperario
            // 
            this.txtCodigoOperario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoOperario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoOperario.Enabled = false;
            this.txtCodigoOperario.Location = new System.Drawing.Point(27, 62);
            this.txtCodigoOperario.Name = "txtCodigoOperario";
            this.txtCodigoOperario.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoOperario.TabIndex = 76;
            this.txtCodigoOperario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvOperarios
            // 
            this.dgvOperarios.AllowUserToAddRows = false;
            this.dgvOperarios.AllowUserToDeleteRows = false;
            this.dgvOperarios.AutoGenerateColumns = false;
            this.dgvOperarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codOperDataGridViewTextBoxColumn,
            this.nomOperDataGridViewTextBoxColumn});
            this.dgvOperarios.DataSource = this.operariosMaquinaBindingSource;
            this.dgvOperarios.Location = new System.Drawing.Point(315, 14);
            this.dgvOperarios.Name = "dgvOperarios";
            this.dgvOperarios.ReadOnly = true;
            this.dgvOperarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperarios.Size = new System.Drawing.Size(249, 423);
            this.dgvOperarios.TabIndex = 108;
            this.dgvOperarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOperarios_CellClick);
            // 
            // codOperDataGridViewTextBoxColumn
            // 
            this.codOperDataGridViewTextBoxColumn.DataPropertyName = "codOper";
            this.codOperDataGridViewTextBoxColumn.HeaderText = "Codigo Operario";
            this.codOperDataGridViewTextBoxColumn.Name = "codOperDataGridViewTextBoxColumn";
            this.codOperDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomOperDataGridViewTextBoxColumn
            // 
            this.nomOperDataGridViewTextBoxColumn.DataPropertyName = "nomOper";
            this.nomOperDataGridViewTextBoxColumn.HeaderText = "Nombre Operario";
            this.nomOperDataGridViewTextBoxColumn.Name = "nomOperDataGridViewTextBoxColumn";
            this.nomOperDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operariosMaquinaBindingSource
            // 
            this.operariosMaquinaBindingSource.DataMember = "operariosMaquina";
            this.operariosMaquinaBindingSource.DataSource = this.ges_v01DataSet8;
            // 
            // ges_v01DataSet8
            // 
            this.ges_v01DataSet8.DataSetName = "ges_v01DataSet8";
            this.ges_v01DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operariosMaquinaTableAdapter
            // 
            this.operariosMaquinaTableAdapter.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(636, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.btn_Salir.Location = new System.Drawing.Point(687, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // OperariosMaquinaMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperariosMaquinaMedicion";
            this.Text = "OperariosMaquinaMedicion";
            this.Load += new System.EventHandler(this.OperariosMaquinaMedicion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OperariosMaquinaMedicion_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operariosMaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEliminarOperario;
        private System.Windows.Forms.Button btnModOperario;
        private System.Windows.Forms.Button btnLimpiarOperario;
        private System.Windows.Forms.Button btnRegOperario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreOperario;
        private System.Windows.Forms.TextBox txtCodigoOperario;
        private System.Windows.Forms.DataGridView dgvOperarios;
        private ges_v01DataSet8 ges_v01DataSet8;
        private System.Windows.Forms.BindingSource operariosMaquinaBindingSource;
        private ges_v01DataSet8TableAdapters.operariosMaquinaTableAdapter operariosMaquinaTableAdapter;
        private System.Windows.Forms.Button botonVerOperarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomOperDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
    }
}