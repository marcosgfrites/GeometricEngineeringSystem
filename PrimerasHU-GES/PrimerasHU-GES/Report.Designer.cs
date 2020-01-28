﻿namespace PrimerasHU_GES
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.pbGrafico = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbImagen = new System.Windows.Forms.ComboBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.RtxtPlan = new System.Windows.Forms.RichTextBox();
            this.btnClientArea = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnGroupBox = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.ppdForm = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocForm = new System.Drawing.Printing.PrintDocument();
            this.graficosTableAdapter = new PrimerasHU_GES.ges_v01DataSet19TableAdapters.graficosTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rbImagen = new System.Windows.Forms.RadioButton();
            this.rbGrafico = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbInforme.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.groupBox2);
            this.gbInforme.Controls.Add(this.groupBox3);
            this.gbInforme.Controls.Add(this.groupBox4);
            this.gbInforme.Location = new System.Drawing.Point(27, 19);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(809, 463);
            this.gbInforme.TabIndex = 19;
            this.gbInforme.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGrafico);
            this.groupBox2.Controls.Add(this.pbGrafico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 250);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            // 
            // cmbGrafico
            // 
            this.cmbGrafico.DisplayMember = "codGrafico";
            this.cmbGrafico.FormattingEnabled = true;
            this.cmbGrafico.Location = new System.Drawing.Point(14, 39);
            this.cmbGrafico.Name = "cmbGrafico";
            this.cmbGrafico.Size = new System.Drawing.Size(326, 24);
            this.cmbGrafico.TabIndex = 3;
            this.cmbGrafico.ValueMember = "codGrafico";
            this.cmbGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbGrafico_SelectedIndexChanged);
            // 
            // pbGrafico
            // 
            this.pbGrafico.Location = new System.Drawing.Point(6, 21);
            this.pbGrafico.Name = "pbGrafico";
            this.pbGrafico.Size = new System.Drawing.Size(491, 218);
            this.pbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrafico.TabIndex = 1;
            this.pbGrafico.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbImagen);
            this.groupBox3.Controls.Add(this.pbImagen);
            this.groupBox3.Controls.Add(this.RtxtPlan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 250);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // cmbImagen
            // 
            this.cmbImagen.DisplayMember = "codGrafico";
            this.cmbImagen.FormattingEnabled = true;
            this.cmbImagen.Location = new System.Drawing.Point(15, 39);
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.Size = new System.Drawing.Size(228, 24);
            this.cmbImagen.TabIndex = 4;
            this.cmbImagen.ValueMember = "codGrafico";
            this.cmbImagen.SelectedIndexChanged += new System.EventHandler(this.cmbImagen_SelectedIndexChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(6, 21);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(263, 218);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // RtxtPlan
            // 
            this.RtxtPlan.Location = new System.Drawing.Point(316, 309);
            this.RtxtPlan.Name = "RtxtPlan";
            this.RtxtPlan.Size = new System.Drawing.Size(930, 141);
            this.RtxtPlan.TabIndex = 7;
            this.RtxtPlan.Text = "";
            // 
            // btnClientArea
            // 
            this.btnClientArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientArea.Location = new System.Drawing.Point(860, 48);
            this.btnClientArea.Name = "btnClientArea";
            this.btnClientArea.Size = new System.Drawing.Size(75, 23);
            this.btnClientArea.TabIndex = 15;
            this.btnClientArea.Text = "Client Area";
            this.btnClientArea.UseVisualStyleBackColor = true;
            this.btnClientArea.Click += new System.EventHandler(this.btnClientArea_Click_1);
            // 
            // btnPage2
            // 
            this.btnPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage2.Location = new System.Drawing.Point(860, 135);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(75, 23);
            this.btnPage2.TabIndex = 18;
            this.btnPage2.Text = "Page 2";
            this.btnPage2.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            this.btnPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage1.Location = new System.Drawing.Point(860, 106);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(75, 23);
            this.btnPage1.TabIndex = 17;
            this.btnPage1.Text = "Page 1";
            this.btnPage1.UseVisualStyleBackColor = true;
            // 
            // btnGroupBox
            // 
            this.btnGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupBox.Location = new System.Drawing.Point(860, 77);
            this.btnGroupBox.Name = "btnGroupBox";
            this.btnGroupBox.Size = new System.Drawing.Size(75, 23);
            this.btnGroupBox.TabIndex = 16;
            this.btnGroupBox.Text = "GroupBox";
            this.btnGroupBox.UseVisualStyleBackColor = true;
            this.btnGroupBox.Click += new System.EventHandler(this.btnGroupBox_Click);
            // 
            // btnForm
            // 
            this.btnForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForm.Location = new System.Drawing.Point(860, 19);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(75, 23);
            this.btnForm.TabIndex = 14;
            this.btnForm.Text = "Form";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click_1);
            // 
            // ppdForm
            // 
            this.ppdForm.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdForm.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdForm.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdForm.Document = this.pdocForm;
            this.ppdForm.Enabled = true;
            this.ppdForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdForm.Icon")));
            this.ppdForm.Name = "ppdForm";
            this.ppdForm.UseAntiAlias = true;
            this.ppdForm.Visible = false;
            // 
            // pdocForm
            // 
            this.pdocForm.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocForm_PrintPage_1);
            // 
            // graficosTableAdapter
            // 
            this.graficosTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cargar Imagen/Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbImagen
            // 
            this.rbImagen.AutoSize = true;
            this.rbImagen.Location = new System.Drawing.Point(15, 99);
            this.rbImagen.Name = "rbImagen";
            this.rbImagen.Size = new System.Drawing.Size(60, 17);
            this.rbImagen.TabIndex = 21;
            this.rbImagen.TabStop = true;
            this.rbImagen.Text = "Imagen";
            this.rbImagen.UseVisualStyleBackColor = true;
            // 
            // rbGrafico
            // 
            this.rbGrafico.AutoSize = true;
            this.rbGrafico.Location = new System.Drawing.Point(16, 131);
            this.rbGrafico.Name = "rbGrafico";
            this.rbGrafico.Size = new System.Drawing.Size(59, 17);
            this.rbGrafico.TabIndex = 22;
            this.rbGrafico.TabStop = true;
            this.rbGrafico.Text = "Grafico";
            this.rbGrafico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbImagen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbGrafico);
            this.groupBox1.Location = new System.Drawing.Point(842, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 179);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagenes Personalizadas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(763, 158);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(10, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 196);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plan de acción";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.btnClientArea);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.btnGroupBox);
            this.Controls.Add(this.btnForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.gbInforme.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGrafico;
        private System.Windows.Forms.PictureBox pbGrafico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.RichTextBox RtxtPlan;
        private System.Windows.Forms.Button btnClientArea;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnGroupBox;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.PrintPreviewDialog ppdForm;
        private System.Drawing.Printing.PrintDocument pdocForm;
        private ges_v01DataSet19TableAdapters.graficosTableAdapter graficosTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbImagen;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rbImagen;
        private System.Windows.Forms.RadioButton rbGrafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}