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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomIndi = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtIndicadores = new System.Windows.Forms.DataGridView();
            this.ges_v01DataSet18 = new PrimerasHU_GES.ges_v01DataSet18();
            this.indicadoresCalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indicadoresCalidadTableAdapter = new PrimerasHU_GES.ges_v01DataSet18TableAdapters.indicadoresCalidadTableAdapter();
            this.codIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechoraModIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIndicadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtIndicadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicadoresCalidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Indicador";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(66, 370);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 34);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(35, 296);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtNomIndi
            // 
            this.txtNomIndi.Location = new System.Drawing.Point(35, 142);
            this.txtNomIndi.Name = "txtNomIndi";
            this.txtNomIndi.Size = new System.Drawing.Size(200, 20);
            this.txtNomIndi.TabIndex = 4;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(35, 218);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de modificacion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor del Indicador ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registro de indicadores de calidad";
            // 
            // dtIndicadores
            // 
            this.dtIndicadores.AllowUserToAddRows = false;
            this.dtIndicadores.AllowUserToDeleteRows = false;
            this.dtIndicadores.AutoGenerateColumns = false;
            this.dtIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIndicadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codIndicadorDataGridViewTextBoxColumn,
            this.fechoraModIndicadorDataGridViewTextBoxColumn,
            this.nomIndicadorDataGridViewTextBoxColumn,
            this.valorIndicadorDataGridViewTextBoxColumn});
            this.dtIndicadores.DataSource = this.indicadoresCalidadBindingSource;
            this.dtIndicadores.Location = new System.Drawing.Point(330, 142);
            this.dtIndicadores.Name = "dtIndicadores";
            this.dtIndicadores.ReadOnly = true;
            this.dtIndicadores.Size = new System.Drawing.Size(422, 174);
            this.dtIndicadores.TabIndex = 10;
            // 
            // ges_v01DataSet18
            // 
            this.ges_v01DataSet18.DataSetName = "ges_v01DataSet18";
            this.ges_v01DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // indicadoresCalidadBindingSource
            // 
            this.indicadoresCalidadBindingSource.DataMember = "indicadoresCalidad";
            this.indicadoresCalidadBindingSource.DataSource = this.ges_v01DataSet18;
            // 
            // indicadoresCalidadTableAdapter
            // 
            this.indicadoresCalidadTableAdapter.ClearBeforeFill = true;
            // 
            // codIndicadorDataGridViewTextBoxColumn
            // 
            this.codIndicadorDataGridViewTextBoxColumn.DataPropertyName = "codIndicador";
            this.codIndicadorDataGridViewTextBoxColumn.HeaderText = "codIndicador";
            this.codIndicadorDataGridViewTextBoxColumn.Name = "codIndicadorDataGridViewTextBoxColumn";
            this.codIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechoraModIndicadorDataGridViewTextBoxColumn
            // 
            this.fechoraModIndicadorDataGridViewTextBoxColumn.DataPropertyName = "fechoraModIndicador";
            this.fechoraModIndicadorDataGridViewTextBoxColumn.HeaderText = "fechoraModIndicador";
            this.fechoraModIndicadorDataGridViewTextBoxColumn.Name = "fechoraModIndicadorDataGridViewTextBoxColumn";
            this.fechoraModIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomIndicadorDataGridViewTextBoxColumn
            // 
            this.nomIndicadorDataGridViewTextBoxColumn.DataPropertyName = "nomIndicador";
            this.nomIndicadorDataGridViewTextBoxColumn.HeaderText = "nomIndicador";
            this.nomIndicadorDataGridViewTextBoxColumn.Name = "nomIndicadorDataGridViewTextBoxColumn";
            this.nomIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorIndicadorDataGridViewTextBoxColumn
            // 
            this.valorIndicadorDataGridViewTextBoxColumn.DataPropertyName = "valorIndicador";
            this.valorIndicadorDataGridViewTextBoxColumn.HeaderText = "valorIndicador";
            this.valorIndicadorDataGridViewTextBoxColumn.Name = "valorIndicadorDataGridViewTextBoxColumn";
            this.valorIndicadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IndicadoresCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtIndicadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtNomIndi);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "IndicadoresCalidad";
            this.Text = "IndicadoresCalidad";
            this.Load += new System.EventHandler(this.IndicadoresCalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIndicadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicadoresCalidadBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtIndicadores;
        private ges_v01DataSet18 ges_v01DataSet18;
        private System.Windows.Forms.BindingSource indicadoresCalidadBindingSource;
        private ges_v01DataSet18TableAdapters.indicadoresCalidadTableAdapter indicadoresCalidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechoraModIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomIndicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorIndicadorDataGridViewTextBoxColumn;
    }
}