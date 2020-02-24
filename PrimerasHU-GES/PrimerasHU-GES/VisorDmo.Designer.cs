namespace PrimerasHU_GES
{
    partial class VisorDmo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorDmo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_documentosDmo = new System.Windows.Forms.DataGridView();
            this.btn_actualizarDocumentosDmo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p_documentosDmo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_coordenada = new System.Windows.Forms.ComboBox();
            this.check_coordenada = new System.Windows.Forms.CheckBox();
            this.check_dmo = new System.Windows.Forms.CheckBox();
            this.cb_dmo = new System.Windows.Forms.ComboBox();
            this.documentosDmoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DocumentosDmo2 = new PrimerasHU_GES.ges_v01DocumentosDmo2();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_mediciones = new System.Windows.Forms.DataGridView();
            this.btn_actualizarMediciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ges_v01DocumentosDmo = new PrimerasHU_GES.ges_v01DocumentosDmo();
            this.detallesDocumentoDmoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesDocumentoDmoTableAdapter = new PrimerasHU_GES.ges_v01DocumentosDmoTableAdapters.detallesDocumentoDmoTableAdapter();
            this.documentosDmoTableAdapter = new PrimerasHU_GES.ges_v01DocumentosDmo2TableAdapters.documentosDmoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documentosDmo)).BeginInit();
            this.p_documentosDmo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDmoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DocumentosDmo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mediciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DocumentosDmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDocumentoDmoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 49);
            this.panel1.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(95, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(394, 22);
            this.label22.TabIndex = 4;
            this.label22.Text = "VISUALIZACIÓN DE DATOS DE MEDICIÓN";
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
            // dgv_documentosDmo
            // 
            this.dgv_documentosDmo.AllowUserToAddRows = false;
            this.dgv_documentosDmo.AllowUserToDeleteRows = false;
            this.dgv_documentosDmo.AllowUserToResizeColumns = false;
            this.dgv_documentosDmo.AllowUserToResizeRows = false;
            this.dgv_documentosDmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_documentosDmo.Location = new System.Drawing.Point(16, 16);
            this.dgv_documentosDmo.MultiSelect = false;
            this.dgv_documentosDmo.Name = "dgv_documentosDmo";
            this.dgv_documentosDmo.ReadOnly = true;
            this.dgv_documentosDmo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_documentosDmo.Size = new System.Drawing.Size(643, 115);
            this.dgv_documentosDmo.TabIndex = 46;
            // 
            // btn_actualizarDocumentosDmo
            // 
            this.btn_actualizarDocumentosDmo.BackColor = System.Drawing.Color.Black;
            this.btn_actualizarDocumentosDmo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_actualizarDocumentosDmo.FlatAppearance.BorderSize = 0;
            this.btn_actualizarDocumentosDmo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_actualizarDocumentosDmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarDocumentosDmo.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarDocumentosDmo.Location = new System.Drawing.Point(543, 137);
            this.btn_actualizarDocumentosDmo.Name = "btn_actualizarDocumentosDmo";
            this.btn_actualizarDocumentosDmo.Size = new System.Drawing.Size(116, 23);
            this.btn_actualizarDocumentosDmo.TabIndex = 47;
            this.btn_actualizarDocumentosDmo.Text = "Actualizar listado...";
            this.btn_actualizarDocumentosDmo.UseVisualStyleBackColor = false;
            this.btn_actualizarDocumentosDmo.Click += new System.EventHandler(this.Btn_actualizarDocumentosDmo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Documentos DMO";
            // 
            // p_documentosDmo
            // 
            this.p_documentosDmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_documentosDmo.Controls.Add(this.dgv_documentosDmo);
            this.p_documentosDmo.Controls.Add(this.btn_actualizarDocumentosDmo);
            this.p_documentosDmo.Location = new System.Drawing.Point(22, 71);
            this.p_documentosDmo.Name = "p_documentosDmo";
            this.p_documentosDmo.Size = new System.Drawing.Size(677, 175);
            this.p_documentosDmo.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cb_coordenada);
            this.panel3.Controls.Add(this.check_coordenada);
            this.panel3.Controls.Add(this.check_dmo);
            this.panel3.Controls.Add(this.cb_dmo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgv_mediciones);
            this.panel3.Controls.Add(this.btn_actualizarMediciones);
            this.panel3.Location = new System.Drawing.Point(22, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 413);
            this.panel3.TabIndex = 50;
            // 
            // cb_coordenada
            // 
            this.cb_coordenada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_coordenada.FormattingEnabled = true;
            this.cb_coordenada.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cb_coordenada.Location = new System.Drawing.Point(354, 24);
            this.cb_coordenada.Name = "cb_coordenada";
            this.cb_coordenada.Size = new System.Drawing.Size(121, 21);
            this.cb_coordenada.TabIndex = 55;
            // 
            // check_coordenada
            // 
            this.check_coordenada.AutoSize = true;
            this.check_coordenada.Location = new System.Drawing.Point(261, 26);
            this.check_coordenada.Name = "check_coordenada";
            this.check_coordenada.Size = new System.Drawing.Size(87, 17);
            this.check_coordenada.TabIndex = 54;
            this.check_coordenada.Text = "Coordenada:";
            this.check_coordenada.UseVisualStyleBackColor = true;
            this.check_coordenada.CheckedChanged += new System.EventHandler(this.Check_coordenada_CheckedChanged);
            // 
            // check_dmo
            // 
            this.check_dmo.AutoSize = true;
            this.check_dmo.Location = new System.Drawing.Point(16, 26);
            this.check_dmo.Name = "check_dmo";
            this.check_dmo.Size = new System.Drawing.Size(54, 17);
            this.check_dmo.TabIndex = 53;
            this.check_dmo.Text = "DMO:";
            this.check_dmo.UseVisualStyleBackColor = true;
            this.check_dmo.CheckedChanged += new System.EventHandler(this.Check_dmo_CheckedChanged);
            // 
            // cb_dmo
            // 
            this.cb_dmo.DataSource = this.documentosDmoBindingSource;
            this.cb_dmo.DisplayMember = "codDmo";
            this.cb_dmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dmo.FormattingEnabled = true;
            this.cb_dmo.Location = new System.Drawing.Point(76, 24);
            this.cb_dmo.Name = "cb_dmo";
            this.cb_dmo.Size = new System.Drawing.Size(167, 21);
            this.cb_dmo.TabIndex = 52;
            this.cb_dmo.ValueMember = "codDmo";
            // 
            // documentosDmoBindingSource
            // 
            this.documentosDmoBindingSource.DataMember = "documentosDmo";
            this.documentosDmoBindingSource.DataSource = this.ges_v01DocumentosDmo2;
            // 
            // ges_v01DocumentosDmo2
            // 
            this.ges_v01DocumentosDmo2.DataSetName = "ges_v01DocumentosDmo2";
            this.ges_v01DocumentosDmo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Filtrar por:";
            // 
            // dgv_mediciones
            // 
            this.dgv_mediciones.AllowUserToAddRows = false;
            this.dgv_mediciones.AllowUserToDeleteRows = false;
            this.dgv_mediciones.AllowUserToResizeColumns = false;
            this.dgv_mediciones.AllowUserToResizeRows = false;
            this.dgv_mediciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mediciones.Location = new System.Drawing.Point(16, 53);
            this.dgv_mediciones.MultiSelect = false;
            this.dgv_mediciones.Name = "dgv_mediciones";
            this.dgv_mediciones.ReadOnly = true;
            this.dgv_mediciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mediciones.Size = new System.Drawing.Size(643, 316);
            this.dgv_mediciones.TabIndex = 48;
            // 
            // btn_actualizarMediciones
            // 
            this.btn_actualizarMediciones.BackColor = System.Drawing.Color.Black;
            this.btn_actualizarMediciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_actualizarMediciones.FlatAppearance.BorderSize = 0;
            this.btn_actualizarMediciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.btn_actualizarMediciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarMediciones.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarMediciones.Location = new System.Drawing.Point(543, 375);
            this.btn_actualizarMediciones.Name = "btn_actualizarMediciones";
            this.btn_actualizarMediciones.Size = new System.Drawing.Size(116, 23);
            this.btn_actualizarMediciones.TabIndex = 49;
            this.btn_actualizarMediciones.Text = "Actualizar listado...";
            this.btn_actualizarMediciones.UseVisualStyleBackColor = false;
            this.btn_actualizarMediciones.Click += new System.EventHandler(this.Btn_actualizarMediciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mediciones";
            // 
            // ges_v01DocumentosDmo
            // 
            this.ges_v01DocumentosDmo.DataSetName = "ges_v01DocumentosDmo";
            this.ges_v01DocumentosDmo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallesDocumentoDmoBindingSource
            // 
            this.detallesDocumentoDmoBindingSource.DataMember = "detallesDocumentoDmo";
            this.detallesDocumentoDmoBindingSource.DataSource = this.ges_v01DocumentosDmo;
            // 
            // detallesDocumentoDmoTableAdapter
            // 
            this.detallesDocumentoDmoTableAdapter.ClearBeforeFill = true;
            // 
            // documentosDmoTableAdapter
            // 
            this.documentosDmoTableAdapter.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(620, 0);
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
            this.btn_Salir.Location = new System.Drawing.Point(671, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // VisorDmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(722, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.p_documentosDmo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisorDmo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorDmo";
            this.Load += new System.EventHandler(this.VisorDmo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documentosDmo)).EndInit();
            this.p_documentosDmo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDmoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DocumentosDmo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mediciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DocumentosDmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDocumentoDmoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_documentosDmo;
        private System.Windows.Forms.Button btn_actualizarDocumentosDmo;
        private System.Windows.Forms.Panel p_documentosDmo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_mediciones;
        private System.Windows.Forms.Button btn_actualizarMediciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_dmo;
        private ges_v01DocumentosDmo ges_v01DocumentosDmo;
        private System.Windows.Forms.BindingSource detallesDocumentoDmoBindingSource;
        private ges_v01DocumentosDmoTableAdapters.detallesDocumentoDmoTableAdapter detallesDocumentoDmoTableAdapter;
        private ges_v01DocumentosDmo2 ges_v01DocumentosDmo2;
        private System.Windows.Forms.BindingSource documentosDmoBindingSource;
        private ges_v01DocumentosDmo2TableAdapters.documentosDmoTableAdapter documentosDmoTableAdapter;
        private System.Windows.Forms.CheckBox check_dmo;
        private System.Windows.Forms.ComboBox cb_coordenada;
        private System.Windows.Forms.CheckBox check_coordenada;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Salir;
    }
}