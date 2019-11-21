namespace PrimerasHU_GES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btImagen = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.RtxtPlan = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClientArea = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnGroupBox = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.ppdForm = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocForm = new System.Drawing.Printing.PrintDocument();
            this.pbGrafico = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbInforme.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.groupBox2);
            this.gbInforme.Controls.Add(this.groupBox3);
            this.gbInforme.Controls.Add(this.groupBox4);
            this.gbInforme.Location = new System.Drawing.Point(27, 19);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(629, 412);
            this.gbInforme.TabIndex = 19;
            this.gbInforme.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGrafico);
            this.groupBox2.Controls.Add(this.pbGrafico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(277, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 227);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            // 
            // cmbGrafico
            // 
            this.cmbGrafico.DisplayMember = "nomGrafico";
            this.cmbGrafico.FormattingEnabled = true;
            this.cmbGrafico.Location = new System.Drawing.Point(21, 39);
            this.cmbGrafico.Name = "cmbGrafico";
            this.cmbGrafico.Size = new System.Drawing.Size(234, 24);
            this.cmbGrafico.TabIndex = 3;
            this.cmbGrafico.ValueMember = "codGrafico";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btImagen);
            this.groupBox3.Controls.Add(this.txtImagen);
            this.groupBox3.Controls.Add(this.pbImagen);
            this.groupBox3.Controls.Add(this.RtxtPlan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 227);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // btImagen
            // 
            this.btImagen.Location = new System.Drawing.Point(28, 175);
            this.btImagen.Name = "btImagen";
            this.btImagen.Size = new System.Drawing.Size(133, 23);
            this.btImagen.TabIndex = 3;
            this.btImagen.Text = "Cargar Imagen";
            this.btImagen.UseVisualStyleBackColor = true;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(28, 39);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(203, 22);
            this.txtImagen.TabIndex = 8;
            // 
            // RtxtPlan
            // 
            this.RtxtPlan.Location = new System.Drawing.Point(316, 309);
            this.RtxtPlan.Name = "RtxtPlan";
            this.RtxtPlan.Size = new System.Drawing.Size(930, 141);
            this.RtxtPlan.TabIndex = 7;
            this.RtxtPlan.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(10, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 158);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plan de acción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 134);
            this.textBox1.TabIndex = 0;
            // 
            // btnClientArea
            // 
            this.btnClientArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientArea.Location = new System.Drawing.Point(698, 48);
            this.btnClientArea.Name = "btnClientArea";
            this.btnClientArea.Size = new System.Drawing.Size(75, 23);
            this.btnClientArea.TabIndex = 15;
            this.btnClientArea.Text = "Client Area";
            this.btnClientArea.UseVisualStyleBackColor = true;
            // 
            // btnPage2
            // 
            this.btnPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage2.Location = new System.Drawing.Point(698, 135);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(75, 23);
            this.btnPage2.TabIndex = 18;
            this.btnPage2.Text = "Page 2";
            this.btnPage2.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            this.btnPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage1.Location = new System.Drawing.Point(698, 106);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(75, 23);
            this.btnPage1.TabIndex = 17;
            this.btnPage1.Text = "Page 1";
            this.btnPage1.UseVisualStyleBackColor = true;
            // 
            // btnGroupBox
            // 
            this.btnGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupBox.Location = new System.Drawing.Point(698, 77);
            this.btnGroupBox.Name = "btnGroupBox";
            this.btnGroupBox.Size = new System.Drawing.Size(75, 23);
            this.btnGroupBox.TabIndex = 16;
            this.btnGroupBox.Text = "GroupBox";
            this.btnGroupBox.UseVisualStyleBackColor = true;
            // 
            // btnForm
            // 
            this.btnForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForm.Location = new System.Drawing.Point(698, 19);
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
            this.ppdForm.Visible = false;
            // 
            // pbGrafico
            // 
            this.pbGrafico.Location = new System.Drawing.Point(6, 21);
            this.pbGrafico.Name = "pbGrafico";
            this.pbGrafico.Size = new System.Drawing.Size(334, 195);
            this.pbGrafico.TabIndex = 1;
            this.pbGrafico.TabStop = false;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(15, 21);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(236, 195);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.btnClientArea);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.btnGroupBox);
            this.Controls.Add(this.btnForm);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.gbInforme.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGrafico;
        private System.Windows.Forms.PictureBox pbGrafico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btImagen;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.RichTextBox RtxtPlan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClientArea;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnGroupBox;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.PrintPreviewDialog ppdForm;
        private System.Drawing.Printing.PrintDocument pdocForm;
    }
}