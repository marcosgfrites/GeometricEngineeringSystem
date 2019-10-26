namespace PrimerasHU_GES
{
    partial class MuestraMarcos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_previsual = new System.Windows.Forms.Button();
            this.btn_limpiarMuestra = new System.Windows.Forms.Button();
            this.txt_obserMuestra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidadDmo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ultDmo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fechaMuestra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codMuestra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_docDmo = new System.Windows.Forms.DataGridView();
            this.ges_v01DataSetCodigosDmo = new PrimerasHU_GES.ges_v01DataSetCodigosDmo();
            this.documentosDmoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentosDmoTableAdapter = new PrimerasHU_GES.ges_v01DataSetCodigosDmoTableAdapters.documentosDmoTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_cantSolicitada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantEncontrada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_muestras = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docDmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetCodigosDmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDmoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 49);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "GESTOR DE MUESTRAS";
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
            this.btn_Salir.Location = new System.Drawing.Point(546, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btn_previsual);
            this.panel2.Controls.Add(this.btn_limpiarMuestra);
            this.panel2.Controls.Add(this.txt_obserMuestra);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_cantidadDmo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ultDmo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtp_fechaMuestra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_codMuestra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 242);
            this.panel2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "PASO 1 >>";
            // 
            // btn_previsual
            // 
            this.btn_previsual.BackColor = System.Drawing.Color.Black;
            this.btn_previsual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previsual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_previsual.FlatAppearance.BorderSize = 0;
            this.btn_previsual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_previsual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previsual.ForeColor = System.Drawing.Color.White;
            this.btn_previsual.Location = new System.Drawing.Point(153, 208);
            this.btn_previsual.Name = "btn_previsual";
            this.btn_previsual.Size = new System.Drawing.Size(75, 23);
            this.btn_previsual.TabIndex = 11;
            this.btn_previsual.Text = "Previsualizar";
            this.btn_previsual.UseVisualStyleBackColor = false;
            this.btn_previsual.Click += new System.EventHandler(this.Btn_previsual_Click);
            // 
            // btn_limpiarMuestra
            // 
            this.btn_limpiarMuestra.BackColor = System.Drawing.Color.Black;
            this.btn_limpiarMuestra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarMuestra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_limpiarMuestra.FlatAppearance.BorderSize = 0;
            this.btn_limpiarMuestra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_limpiarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarMuestra.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarMuestra.Location = new System.Drawing.Point(234, 208);
            this.btn_limpiarMuestra.Name = "btn_limpiarMuestra";
            this.btn_limpiarMuestra.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiarMuestra.TabIndex = 10;
            this.btn_limpiarMuestra.Text = "Limpiar";
            this.btn_limpiarMuestra.UseVisualStyleBackColor = false;
            this.btn_limpiarMuestra.Click += new System.EventHandler(this.Btn_limpiarMuestra_Click);
            // 
            // txt_obserMuestra
            // 
            this.txt_obserMuestra.Location = new System.Drawing.Point(108, 136);
            this.txt_obserMuestra.Multiline = true;
            this.txt_obserMuestra.Name = "txt_obserMuestra";
            this.txt_obserMuestra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_obserMuestra.Size = new System.Drawing.Size(202, 65);
            this.txt_obserMuestra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Observaciones:";
            // 
            // txt_cantidadDmo
            // 
            this.txt_cantidadDmo.Location = new System.Drawing.Point(108, 105);
            this.txt_cantidadDmo.Name = "txt_cantidadDmo";
            this.txt_cantidadDmo.Size = new System.Drawing.Size(42, 20);
            this.txt_cantidadDmo.TabIndex = 7;
            this.txt_cantidadDmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantidadDmo.TextChanged += new System.EventHandler(this.txt_cantidadDmo_TextChanged);
            this.txt_cantidadDmo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cantidadDmo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de DMO:";
            // 
            // txt_ultDmo
            // 
            this.txt_ultDmo.Enabled = false;
            this.txt_ultDmo.Location = new System.Drawing.Point(108, 71);
            this.txt_ultDmo.Name = "txt_ultDmo";
            this.txt_ultDmo.Size = new System.Drawing.Size(202, 20);
            this.txt_ultDmo.TabIndex = 5;
            this.txt_ultDmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Últ. DMO:";
            // 
            // dtp_fechaMuestra
            // 
            this.dtp_fechaMuestra.Enabled = false;
            this.dtp_fechaMuestra.Location = new System.Drawing.Point(110, 38);
            this.dtp_fechaMuestra.Name = "dtp_fechaMuestra";
            this.dtp_fechaMuestra.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaMuestra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Registro:";
            // 
            // txt_codMuestra
            // 
            this.txt_codMuestra.Enabled = false;
            this.txt_codMuestra.Location = new System.Drawing.Point(108, 7);
            this.txt_codMuestra.Name = "txt_codMuestra";
            this.txt_codMuestra.Size = new System.Drawing.Size(42, 20);
            this.txt_codMuestra.TabIndex = 1;
            this.txt_codMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // dgv_docDmo
            // 
            this.dgv_docDmo.AllowUserToAddRows = false;
            this.dgv_docDmo.AllowUserToDeleteRows = false;
            this.dgv_docDmo.AllowUserToResizeColumns = false;
            this.dgv_docDmo.AllowUserToResizeRows = false;
            this.dgv_docDmo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_docDmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docDmo.Location = new System.Drawing.Point(343, 75);
            this.dgv_docDmo.MultiSelect = false;
            this.dgv_docDmo.Name = "dgv_docDmo";
            this.dgv_docDmo.ReadOnly = true;
            this.dgv_docDmo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_docDmo.Size = new System.Drawing.Size(240, 224);
            this.dgv_docDmo.TabIndex = 3;
            // 
            // ges_v01DataSetCodigosDmo
            // 
            this.ges_v01DataSetCodigosDmo.DataSetName = "ges_v01DataSetCodigosDmo";
            this.ges_v01DataSetCodigosDmo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentosDmoBindingSource
            // 
            this.documentosDmoBindingSource.DataMember = "documentosDmo";
            this.documentosDmoBindingSource.DataSource = this.ges_v01DataSetCodigosDmo;
            // 
            // documentosDmoTableAdapter
            // 
            this.documentosDmoTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Listado de documentos DMO a utilizar";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Black;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Enabled = false;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(122, 306);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(212, 23);
            this.btn_registrar.TabIndex = 12;
            this.btn_registrar.Text = "Registrar Muestra/Detalle de Muestra";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // txt_cantSolicitada
            // 
            this.txt_cantSolicitada.Enabled = false;
            this.txt_cantSolicitada.Location = new System.Drawing.Point(409, 308);
            this.txt_cantSolicitada.Name = "txt_cantSolicitada";
            this.txt_cantSolicitada.Size = new System.Drawing.Size(42, 20);
            this.txt_cantSolicitada.TabIndex = 14;
            this.txt_cantSolicitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Solicitados:";
            // 
            // txt_cantEncontrada
            // 
            this.txt_cantEncontrada.Enabled = false;
            this.txt_cantEncontrada.Location = new System.Drawing.Point(541, 308);
            this.txt_cantEncontrada.Name = "txt_cantEncontrada";
            this.txt_cantEncontrada.Size = new System.Drawing.Size(42, 20);
            this.txt_cantEncontrada.TabIndex = 16;
            this.txt_cantEncontrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Encontrados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "/";
            // 
            // dgv_muestras
            // 
            this.dgv_muestras.AllowUserToAddRows = false;
            this.dgv_muestras.AllowUserToDeleteRows = false;
            this.dgv_muestras.AllowUserToResizeColumns = false;
            this.dgv_muestras.AllowUserToResizeRows = false;
            this.dgv_muestras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_muestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestras.Location = new System.Drawing.Point(13, 355);
            this.dgv_muestras.Name = "dgv_muestras";
            this.dgv_muestras.ReadOnly = true;
            this.dgv_muestras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_muestras.Size = new System.Drawing.Size(570, 233);
            this.dgv_muestras.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Listado de Muestras registradas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "PASO 2 >>";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(495, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MuestraMarcos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(597, 600);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_muestras);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_cantEncontrada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cantSolicitada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_docDmo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuestraMarcos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuestraMarcos";
            this.Load += new System.EventHandler(this.MuestraMarcos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MuestraMarcos_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docDmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetCodigosDmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDmoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidadDmo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ultDmo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fechaMuestra;
        private System.Windows.Forms.TextBox txt_obserMuestra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_limpiarMuestra;
        private System.Windows.Forms.Button btn_previsual;
        private System.Windows.Forms.DataGridView dgv_docDmo;
        private ges_v01DataSetCodigosDmo ges_v01DataSetCodigosDmo;
        private System.Windows.Forms.BindingSource documentosDmoBindingSource;
        private ges_v01DataSetCodigosDmoTableAdapters.documentosDmoTableAdapter documentosDmoTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_cantEncontrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cantSolicitada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_muestras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}