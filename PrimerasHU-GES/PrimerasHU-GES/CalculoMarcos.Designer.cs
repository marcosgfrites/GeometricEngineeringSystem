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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nombrePuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosPunto)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1300, 49);
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
            this.btn_Salir.Location = new System.Drawing.Point(1249, 0);
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
            this.label2.Location = new System.Drawing.Point(12, 61);
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
            this.dgv_muestras.Location = new System.Drawing.Point(15, 77);
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
            this.dgv_listaPuntos.Location = new System.Drawing.Point(15, 202);
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
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntos relacionados a la \'Muestra\' seleccionada:";
            // 
            // lbl_muestra
            // 
            this.lbl_muestra.AutoSize = true;
            this.lbl_muestra.Location = new System.Drawing.Point(255, 186);
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
            this.dgv_nombrePuntos.Location = new System.Drawing.Point(15, 647);
            this.dgv_nombrePuntos.MultiSelect = false;
            this.dgv_nombrePuntos.Name = "dgv_nombrePuntos";
            this.dgv_nombrePuntos.ReadOnly = true;
            this.dgv_nombrePuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nombrePuntos.Size = new System.Drawing.Size(131, 41);
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
            this.btn_calcular.Location = new System.Drawing.Point(326, 657);
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
            this.dgv_calculos.Location = new System.Drawing.Point(441, 77);
            this.dgv_calculos.MultiSelect = false;
            this.dgv_calculos.Name = "dgv_calculos";
            this.dgv_calculos.ReadOnly = true;
            this.dgv_calculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_calculos.Size = new System.Drawing.Size(847, 362);
            this.dgv_calculos.TabIndex = 21;
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
            this.dgv_datosPunto.Location = new System.Drawing.Point(441, 445);
            this.dgv_datosPunto.MultiSelect = false;
            this.dgv_datosPunto.Name = "dgv_datosPunto";
            this.dgv_datosPunto.ReadOnly = true;
            this.dgv_datosPunto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datosPunto.Size = new System.Drawing.Size(832, 222);
            this.dgv_datosPunto.TabIndex = 22;
            // 
            // CalculoMarcos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.dgv_datosPunto);
            this.Controls.Add(this.dgv_calculos);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.dgv_nombrePuntos);
            this.Controls.Add(this.lbl_muestra);
            this.Controls.Add(this.dgv_listaPuntos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_muestras);
            this.Controls.Add(this.label2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}