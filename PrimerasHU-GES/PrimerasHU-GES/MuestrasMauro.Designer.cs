namespace PrimerasHU_GES
{
    partial class MuestrasMauro
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_docDmo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_previsual = new System.Windows.Forms.Button();
            this.btn_limpiarMuestra = new System.Windows.Forms.Button();
            this.txt_obserMuestra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidadDmo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ultDmo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codMuestra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.documentosDmoTableAdapter = new PrimerasHU_GES.ges_v01DataSetCodigosDmoTableAdapters.documentosDmoTableAdapter();
            this.documentosDmoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSetCodigosDmo = new PrimerasHU_GES.ges_v01DataSetCodigosDmo();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docDmo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDmoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetCodigosDmo)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Listado de documentos DMO a utilizar";
            // 
            // dgv_docDmo
            // 
            this.dgv_docDmo.AllowUserToAddRows = false;
            this.dgv_docDmo.AllowUserToDeleteRows = false;
            this.dgv_docDmo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_docDmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docDmo.Location = new System.Drawing.Point(343, 81);
            this.dgv_docDmo.MultiSelect = false;
            this.dgv_docDmo.Name = "dgv_docDmo";
            this.dgv_docDmo.ReadOnly = true;
            this.dgv_docDmo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_docDmo.Size = new System.Drawing.Size(240, 363);
            this.dgv_docDmo.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_previsual);
            this.panel2.Controls.Add(this.btn_limpiarMuestra);
            this.panel2.Controls.Add(this.txt_obserMuestra);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_cantidadDmo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ultDmo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_codMuestra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 381);
            this.panel2.TabIndex = 6;
            // 
            // btn_previsual
            // 
            this.btn_previsual.Location = new System.Drawing.Point(153, 208);
            this.btn_previsual.Name = "btn_previsual";
            this.btn_previsual.Size = new System.Drawing.Size(75, 23);
            this.btn_previsual.TabIndex = 11;
            this.btn_previsual.Text = "Previsualizar";
            this.btn_previsual.UseVisualStyleBackColor = true;
            // 
            // btn_limpiarMuestra
            // 
            this.btn_limpiarMuestra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarMuestra.Location = new System.Drawing.Point(234, 208);
            this.btn_limpiarMuestra.Name = "btn_limpiarMuestra";
            this.btn_limpiarMuestra.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiarMuestra.TabIndex = 10;
            this.btn_limpiarMuestra.Text = "Limpiar";
            this.btn_limpiarMuestra.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
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
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 5;
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
            this.btn_Salir.Location = new System.Drawing.Point(749, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // documentosDmoTableAdapter
            // 
            this.documentosDmoTableAdapter.ClearBeforeFill = true;
            // 
            // documentosDmoBindingSource
            // 
            this.documentosDmoBindingSource.DataMember = "documentosDmo";
            // 
            // ges_v01DataSetCodigosDmo
            // 
            this.ges_v01DataSetCodigosDmo.DataSetName = "ges_v01DataSetCodigosDmo";
            this.ges_v01DataSetCodigosDmo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MuestrasMauro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_docDmo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuestrasMauro";
            this.Text = "MuestrasMauro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docDmo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDmoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSetCodigosDmo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_docDmo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_previsual;
        private System.Windows.Forms.Button btn_limpiarMuestra;
        private System.Windows.Forms.TextBox txt_obserMuestra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidadDmo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ultDmo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private ges_v01DataSetCodigosDmoTableAdapters.documentosDmoTableAdapter documentosDmoTableAdapter;
        private System.Windows.Forms.BindingSource documentosDmoBindingSource;
        private ges_v01DataSetCodigosDmo ges_v01DataSetCodigosDmo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}