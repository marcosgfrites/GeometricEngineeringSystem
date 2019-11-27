namespace PrimerasHU_GES
{
    partial class CalculoGrafo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.chart_grafo1Calculo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_grafo2Calculo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_ventana1 = new System.Windows.Forms.Label();
            this.btn_registrarGraficoCpk = new System.Windows.Forms.Button();
            this.btn_registrarGraficoCp = new System.Windows.Forms.Button();
            this.lbl_calculo1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafo1Calculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafo2Calculo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 49);
            this.panel1.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(489, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "PREVISUALIZACIÓN DE GRÁFICO PARA CÁLCULOS";
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
            this.btn_Salir.Location = new System.Drawing.Point(981, 0);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 49);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // chart_grafo1Calculo
            // 
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Angle = -90;
            chartArea6.Name = "ChartArea1";
            this.chart_grafo1Calculo.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_grafo1Calculo.Legends.Add(legend6);
            this.chart_grafo1Calculo.Location = new System.Drawing.Point(6, 6);
            this.chart_grafo1Calculo.Name = "chart_grafo1Calculo";
            series6.ChartArea = "ChartArea1";
            series6.EmptyPointStyle.LabelAngle = -90;
            series6.LabelAngle = -90;
            series6.Legend = "Legend1";
            series6.Name = "CP";
            this.chart_grafo1Calculo.Series.Add(series6);
            this.chart_grafo1Calculo.Size = new System.Drawing.Size(988, 463);
            this.chart_grafo1Calculo.TabIndex = 5;
            this.chart_grafo1Calculo.Text = "chart1";
            // 
            // chart_grafo2Calculo
            // 
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Angle = -90;
            chartArea5.Name = "ChartArea1";
            this.chart_grafo2Calculo.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_grafo2Calculo.Legends.Add(legend5);
            this.chart_grafo2Calculo.Location = new System.Drawing.Point(6, 6);
            this.chart_grafo2Calculo.Name = "chart_grafo2Calculo";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.EmptyPointStyle.LabelAngle = -90;
            series5.LabelAngle = -90;
            series5.Legend = "Legend1";
            series5.Name = "CPK";
            this.chart_grafo2Calculo.Series.Add(series5);
            this.chart_grafo2Calculo.Size = new System.Drawing.Size(988, 463);
            this.chart_grafo2Calculo.TabIndex = 6;
            this.chart_grafo2Calculo.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 501);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.btn_registrarGraficoCp);
            this.tabPage1.Controls.Add(this.chart_grafo1Calculo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CP = Capacidad de Proceso";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage2.Controls.Add(this.btn_registrarGraficoCpk);
            this.tabPage2.Controls.Add(this.chart_grafo2Calculo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPK = Capacidad de Centrado";
            // 
            // lbl_ventana1
            // 
            this.lbl_ventana1.AutoSize = true;
            this.lbl_ventana1.Location = new System.Drawing.Point(9, 547);
            this.lbl_ventana1.Name = "lbl_ventana1";
            this.lbl_ventana1.Size = new System.Drawing.Size(68, 13);
            this.lbl_ventana1.TabIndex = 6;
            this.lbl_ventana1.Text = "lbl_ventana1";
            this.lbl_ventana1.Visible = false;
            // 
            // btn_registrarGraficoCpk
            // 
            this.btn_registrarGraficoCpk.BackColor = System.Drawing.Color.Black;
            this.btn_registrarGraficoCpk.Enabled = false;
            this.btn_registrarGraficoCpk.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_registrarGraficoCpk.FlatAppearance.BorderSize = 0;
            this.btn_registrarGraficoCpk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_registrarGraficoCpk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarGraficoCpk.ForeColor = System.Drawing.Color.White;
            this.btn_registrarGraficoCpk.Location = new System.Drawing.Point(898, 45);
            this.btn_registrarGraficoCpk.Name = "btn_registrarGraficoCpk";
            this.btn_registrarGraficoCpk.Size = new System.Drawing.Size(96, 23);
            this.btn_registrarGraficoCpk.TabIndex = 34;
            this.btn_registrarGraficoCpk.Text = "Registrar Gráfico";
            this.btn_registrarGraficoCpk.UseVisualStyleBackColor = false;
            this.btn_registrarGraficoCpk.Visible = false;
            this.btn_registrarGraficoCpk.Click += new System.EventHandler(this.btn_registrarGraficoCpk_Click);
            // 
            // btn_registrarGraficoCp
            // 
            this.btn_registrarGraficoCp.BackColor = System.Drawing.Color.Black;
            this.btn_registrarGraficoCp.Enabled = false;
            this.btn_registrarGraficoCp.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_registrarGraficoCp.FlatAppearance.BorderSize = 0;
            this.btn_registrarGraficoCp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_registrarGraficoCp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarGraficoCp.ForeColor = System.Drawing.Color.White;
            this.btn_registrarGraficoCp.Location = new System.Drawing.Point(898, 45);
            this.btn_registrarGraficoCp.Name = "btn_registrarGraficoCp";
            this.btn_registrarGraficoCp.Size = new System.Drawing.Size(96, 23);
            this.btn_registrarGraficoCp.TabIndex = 35;
            this.btn_registrarGraficoCp.Text = "Registrar Gráfico";
            this.btn_registrarGraficoCp.UseVisualStyleBackColor = false;
            this.btn_registrarGraficoCp.Visible = false;
            this.btn_registrarGraficoCp.Click += new System.EventHandler(this.btn_registrarGraficoCp_Click);
            // 
            // lbl_calculo1
            // 
            this.lbl_calculo1.AutoSize = true;
            this.lbl_calculo1.Location = new System.Drawing.Point(142, 547);
            this.lbl_calculo1.Name = "lbl_calculo1";
            this.lbl_calculo1.Size = new System.Drawing.Size(63, 13);
            this.lbl_calculo1.TabIndex = 8;
            this.lbl_calculo1.Text = "lbl_calculo1";
            this.lbl_calculo1.Visible = false;
            // 
            // CalculoGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 569);
            this.Controls.Add(this.lbl_calculo1);
            this.Controls.Add(this.lbl_ventana1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculoGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculoGrafo";
            this.Load += new System.EventHandler(this.CalculoGrafo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafo1Calculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafo2Calculo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafo1Calculo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafo2Calculo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_ventana1;
        private System.Windows.Forms.Button btn_registrarGraficoCp;
        private System.Windows.Forms.Button btn_registrarGraficoCpk;
        private System.Windows.Forms.Label lbl_calculo1;
    }
}