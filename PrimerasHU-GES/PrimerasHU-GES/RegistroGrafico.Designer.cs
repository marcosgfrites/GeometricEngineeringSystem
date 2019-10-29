namespace PrimerasHU_GES
{
    partial class RegistroGrafico
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_regGraficoMuestra = new System.Windows.Forms.TextBox();
            this.cb_regGraficoTipoG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreGrafico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descGrafico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_regGrafico = new System.Windows.Forms.PictureBox();
            this.ges_v01DataSet18TiposGraficos = new PrimerasHU_GES.ges_v01DataSet18TiposGraficos();
            this.tiposGraficoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposGraficoTableAdapter = new PrimerasHU_GES.ges_v01DataSet18TiposGraficosTableAdapters.tiposGraficoTableAdapter();
            this.btn_registrarGrafico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18TiposGraficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposGraficoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Muestra:";
            // 
            // txt_regGraficoMuestra
            // 
            this.txt_regGraficoMuestra.Enabled = false;
            this.txt_regGraficoMuestra.Location = new System.Drawing.Point(447, 63);
            this.txt_regGraficoMuestra.Name = "txt_regGraficoMuestra";
            this.txt_regGraficoMuestra.Size = new System.Drawing.Size(121, 20);
            this.txt_regGraficoMuestra.TabIndex = 2;
            this.txt_regGraficoMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_regGraficoTipoG
            // 
            this.cb_regGraficoTipoG.DataSource = this.tiposGraficoBindingSource;
            this.cb_regGraficoTipoG.DisplayMember = "descTiposGraf";
            this.cb_regGraficoTipoG.Enabled = false;
            this.cb_regGraficoTipoG.FormattingEnabled = true;
            this.cb_regGraficoTipoG.Location = new System.Drawing.Point(447, 102);
            this.cb_regGraficoTipoG.Name = "cb_regGraficoTipoG";
            this.cb_regGraficoTipoG.Size = new System.Drawing.Size(121, 21);
            this.cb_regGraficoTipoG.TabIndex = 3;
            this.cb_regGraficoTipoG.ValueMember = "codTiposGraf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Gráfico:";
            // 
            // txt_nombreGrafico
            // 
            this.txt_nombreGrafico.Location = new System.Drawing.Point(447, 142);
            this.txt_nombreGrafico.Name = "txt_nombreGrafico";
            this.txt_nombreGrafico.Size = new System.Drawing.Size(121, 20);
            this.txt_nombreGrafico.TabIndex = 6;
            this.txt_nombreGrafico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de Gráfico:";
            // 
            // txt_descGrafico
            // 
            this.txt_descGrafico.Location = new System.Drawing.Point(447, 181);
            this.txt_descGrafico.Multiline = true;
            this.txt_descGrafico.Name = "txt_descGrafico";
            this.txt_descGrafico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_descGrafico.Size = new System.Drawing.Size(141, 127);
            this.txt_descGrafico.TabIndex = 8;
            this.txt_descGrafico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comentarios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(429, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "REGISTRO DE GRÁFICO DE MUESTRA";
            // 
            // pb_regGrafico
            // 
            this.pb_regGrafico.Location = new System.Drawing.Point(12, 47);
            this.pb_regGrafico.Name = "pb_regGrafico";
            this.pb_regGrafico.Size = new System.Drawing.Size(425, 425);
            this.pb_regGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_regGrafico.TabIndex = 0;
            this.pb_regGrafico.TabStop = false;
            // 
            // ges_v01DataSet18TiposGraficos
            // 
            this.ges_v01DataSet18TiposGraficos.DataSetName = "ges_v01DataSet18TiposGraficos";
            this.ges_v01DataSet18TiposGraficos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposGraficoBindingSource
            // 
            this.tiposGraficoBindingSource.DataMember = "tiposGrafico";
            this.tiposGraficoBindingSource.DataSource = this.ges_v01DataSet18TiposGraficos;
            // 
            // tiposGraficoTableAdapter
            // 
            this.tiposGraficoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_registrarGrafico
            // 
            this.btn_registrarGrafico.BackColor = System.Drawing.Color.Black;
            this.btn_registrarGrafico.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_registrarGrafico.FlatAppearance.BorderSize = 0;
            this.btn_registrarGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_registrarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarGrafico.ForeColor = System.Drawing.Color.White;
            this.btn_registrarGrafico.Location = new System.Drawing.Point(447, 314);
            this.btn_registrarGrafico.Name = "btn_registrarGrafico";
            this.btn_registrarGrafico.Size = new System.Drawing.Size(111, 23);
            this.btn_registrarGrafico.TabIndex = 34;
            this.btn_registrarGrafico.Text = "Registro de Gráfico";
            this.btn_registrarGrafico.UseVisualStyleBackColor = false;
            this.btn_registrarGrafico.Click += new System.EventHandler(this.btn_registrarGrafico_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(477, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Salir del Registro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(601, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_registrarGrafico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descGrafico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombreGrafico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_regGraficoTipoG);
            this.Controls.Add(this.txt_regGraficoMuestra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_regGrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroGrafico";
            this.Load += new System.EventHandler(this.RegistroGrafico_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistroGrafico_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pb_regGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet18TiposGraficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposGraficoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pb_regGrafico;
        private System.Windows.Forms.TextBox txt_regGraficoMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_regGraficoTipoG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descGrafico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreGrafico;
        private System.Windows.Forms.Label label3;
        private ges_v01DataSet18TiposGraficos ges_v01DataSet18TiposGraficos;
        private System.Windows.Forms.BindingSource tiposGraficoBindingSource;
        private ges_v01DataSet18TiposGraficosTableAdapters.tiposGraficoTableAdapter tiposGraficoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_registrarGrafico;
    }
}