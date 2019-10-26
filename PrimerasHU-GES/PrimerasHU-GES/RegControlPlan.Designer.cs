using System;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    partial class RegControlPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegControlPlan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regDetCPbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.actualizarBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.limpiarTxt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cabeceraDtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.actualDTGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.detallesControlPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ges_v01DataSet12 = new PrimerasHU_GES.ges_v01DataSet12();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox6 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registrarBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nuevoDtgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numDisTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.descSeccionTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.revisionText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.codigoProTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.seccionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.revisionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fechaLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ges_v01DataSet = new PrimerasHU_GES.ges_v01DataSet();
            this.gesv01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesControlPlanTableAdapter = new PrimerasHU_GES.ges_v01DataSet12TableAdapters.detallesControlPlanTableAdapter();
            this.ges_v01DataSet17 = new PrimerasHU_GES.ges_v01DataSet17();
            this.detallesControlPlanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detallesControlPlanTableAdapter1 = new PrimerasHU_GES.ges_v01DataSet17TableAdapters.detallesControlPlanTableAdapter();
            this.idPtoMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasiTipoPtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordXPtoMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordYPtoMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordZPtoMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalPtoMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUnidMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolinferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabeceraDtg)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualDTGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesControlPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet12)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoDtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesv01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesControlPlanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.regDetCPbtn);
            this.panel1.Controls.Add(this.actualizarBtn);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.limpiarTxt);
            this.panel1.Controls.Add(this.cabeceraDtg);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.registrarBtn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 611);
            this.panel1.TabIndex = 2;
            // 
            // regDetCPbtn
            // 
            this.regDetCPbtn.Activecolor = System.Drawing.Color.Lime;
            this.regDetCPbtn.BackColor = System.Drawing.Color.Blue;
            this.regDetCPbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regDetCPbtn.BorderRadius = 0;
            this.regDetCPbtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.regDetCPbtn.ButtonText = "4-Registrar Detalle de Control Plan";
            this.regDetCPbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regDetCPbtn.DisabledColor = System.Drawing.Color.Gray;
            this.regDetCPbtn.Enabled = false;
            this.regDetCPbtn.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDetCPbtn.ForeColor = System.Drawing.Color.White;
            this.regDetCPbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.regDetCPbtn.Iconimage = null;
            this.regDetCPbtn.Iconimage_right = null;
            this.regDetCPbtn.Iconimage_right_Selected = null;
            this.regDetCPbtn.Iconimage_Selected = null;
            this.regDetCPbtn.IconMarginLeft = 0;
            this.regDetCPbtn.IconMarginRight = 0;
            this.regDetCPbtn.IconRightVisible = false;
            this.regDetCPbtn.IconRightZoom = 0D;
            this.regDetCPbtn.IconVisible = false;
            this.regDetCPbtn.IconZoom = 90D;
            this.regDetCPbtn.IsTab = false;
            this.regDetCPbtn.Location = new System.Drawing.Point(526, 448);
            this.regDetCPbtn.Margin = new System.Windows.Forms.Padding(0);
            this.regDetCPbtn.Name = "regDetCPbtn";
            this.regDetCPbtn.Normalcolor = System.Drawing.Color.Blue;
            this.regDetCPbtn.OnHovercolor = System.Drawing.Color.Red;
            this.regDetCPbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.regDetCPbtn.selected = false;
            this.regDetCPbtn.Size = new System.Drawing.Size(117, 88);
            this.regDetCPbtn.TabIndex = 29;
            this.regDetCPbtn.Text = "4-Registrar Detalle de Control Plan";
            this.regDetCPbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regDetCPbtn.Textcolor = System.Drawing.Color.White;
            this.regDetCPbtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDetCPbtn.Click += new System.EventHandler(this.RegDetCPbtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Activecolor = System.Drawing.Color.Lime;
            this.actualizarBtn.BackColor = System.Drawing.Color.Red;
            this.actualizarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.actualizarBtn.BorderRadius = 3;
            this.actualizarBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actualizarBtn.ButtonText = "5- Actualizar Sistema";
            this.actualizarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizarBtn.DisabledColor = System.Drawing.Color.Gray;
            this.actualizarBtn.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarBtn.ForeColor = System.Drawing.Color.White;
            this.actualizarBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.actualizarBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("actualizarBtn.Iconimage")));
            this.actualizarBtn.Iconimage_right = null;
            this.actualizarBtn.Iconimage_right_Selected = null;
            this.actualizarBtn.Iconimage_Selected = null;
            this.actualizarBtn.IconMarginLeft = 0;
            this.actualizarBtn.IconMarginRight = 0;
            this.actualizarBtn.IconRightVisible = false;
            this.actualizarBtn.IconRightZoom = 0D;
            this.actualizarBtn.IconVisible = true;
            this.actualizarBtn.IconZoom = 75D;
            this.actualizarBtn.IsTab = false;
            this.actualizarBtn.Location = new System.Drawing.Point(789, 287);
            this.actualizarBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Normalcolor = System.Drawing.Color.Red;
            this.actualizarBtn.OnHovercolor = System.Drawing.Color.Fuchsia;
            this.actualizarBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.actualizarBtn.selected = false;
            this.actualizarBtn.Size = new System.Drawing.Size(206, 43);
            this.actualizarBtn.TabIndex = 28;
            this.actualizarBtn.Text = "5- Actualizar Sistema";
            this.actualizarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualizarBtn.Textcolor = System.Drawing.Color.White;
            this.actualizarBtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Blue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton2.ButtonText = "1- Cargar Control Plan";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(526, 103);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(117, 77);
            this.bunifuFlatButton2.TabIndex = 27;
            this.bunifuFlatButton2.Text = "1- Cargar Control Plan";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "2- Comparar Nuevo / Actual";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Enabled = false;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(526, 219);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(117, 77);
            this.bunifuFlatButton1.TabIndex = 26;
            this.bunifuFlatButton1.Text = "2- Comparar Nuevo / Actual";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // limpiarTxt
            // 
            this.limpiarTxt.Activecolor = System.Drawing.Color.Lime;
            this.limpiarTxt.BackColor = System.Drawing.Color.Teal;
            this.limpiarTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.limpiarTxt.BorderRadius = 0;
            this.limpiarTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.limpiarTxt.ButtonText = "LIMPIAR";
            this.limpiarTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarTxt.DisabledColor = System.Drawing.Color.Gray;
            this.limpiarTxt.Enabled = false;
            this.limpiarTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarTxt.Iconcolor = System.Drawing.Color.Transparent;
            this.limpiarTxt.Iconimage = null;
            this.limpiarTxt.Iconimage_right = null;
            this.limpiarTxt.Iconimage_right_Selected = null;
            this.limpiarTxt.Iconimage_Selected = null;
            this.limpiarTxt.IconMarginLeft = 0;
            this.limpiarTxt.IconMarginRight = 0;
            this.limpiarTxt.IconRightVisible = true;
            this.limpiarTxt.IconRightZoom = 0D;
            this.limpiarTxt.IconVisible = true;
            this.limpiarTxt.IconZoom = 90D;
            this.limpiarTxt.IsTab = false;
            this.limpiarTxt.Location = new System.Drawing.Point(526, 563);
            this.limpiarTxt.Name = "limpiarTxt";
            this.limpiarTxt.Normalcolor = System.Drawing.Color.Teal;
            this.limpiarTxt.OnHovercolor = System.Drawing.Color.Blue;
            this.limpiarTxt.OnHoverTextColor = System.Drawing.Color.White;
            this.limpiarTxt.selected = false;
            this.limpiarTxt.Size = new System.Drawing.Size(117, 43);
            this.limpiarTxt.TabIndex = 25;
            this.limpiarTxt.Text = "LIMPIAR";
            this.limpiarTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.limpiarTxt.Textcolor = System.Drawing.Color.Black;
            this.limpiarTxt.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarTxt.Click += new System.EventHandler(this.LimpiarTxt_Click);
            // 
            // cabeceraDtg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cabeceraDtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cabeceraDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cabeceraDtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cabeceraDtg.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cabeceraDtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabeceraDtg.CausesValidation = false;
            this.cabeceraDtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cabeceraDtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cabeceraDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cabeceraDtg.DoubleBuffered = true;
            this.cabeceraDtg.EnableHeadersVisualStyles = false;
            this.cabeceraDtg.HeaderBgColor = System.Drawing.Color.Chartreuse;
            this.cabeceraDtg.HeaderForeColor = System.Drawing.Color.Black;
            this.cabeceraDtg.Location = new System.Drawing.Point(180, 289);
            this.cabeceraDtg.Name = "cabeceraDtg";
            this.cabeceraDtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cabeceraDtg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.cabeceraDtg.RowTemplate.Height = 20;
            this.cabeceraDtg.Size = new System.Drawing.Size(320, 49);
            this.cabeceraDtg.TabIndex = 0;
            this.cabeceraDtg.TabStop = false;
            this.cabeceraDtg.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.actualDTGV);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(657, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 226);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle Control Plan Actual";
            // 
            // actualDTGV
            // 
            this.actualDTGV.AllowUserToAddRows = false;
            this.actualDTGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.actualDTGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.actualDTGV.AutoGenerateColumns = false;
            this.actualDTGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.actualDTGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actualDTGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actualDTGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.actualDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actualDTGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPtoMedDataGridViewTextBoxColumn,
            this.denominacionDataGridViewTextBoxColumn,
            this.codEntidadDataGridViewTextBoxColumn,
            this.clasiTipoPtoDataGridViewTextBoxColumn,
            this.codTipoControlDataGridViewTextBoxColumn,
            this.coordXPtoMedDataGridViewTextBoxColumn,
            this.coordYPtoMedDataGridViewTextBoxColumn,
            this.coordZPtoMedDataGridViewTextBoxColumn,
            this.nominalPtoMedDataGridViewTextBoxColumn,
            this.codUnidMedDataGridViewTextBoxColumn,
            this.tolinferior,
            this.tolSuperior});
            this.actualDTGV.DataSource = this.detallesControlPlanBindingSource1;
            this.actualDTGV.DoubleBuffered = true;
            this.actualDTGV.EnableHeadersVisualStyles = false;
            this.actualDTGV.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.actualDTGV.HeaderForeColor = System.Drawing.Color.White;
            this.actualDTGV.Location = new System.Drawing.Point(47, 31);
            this.actualDTGV.Name = "actualDTGV";
            this.actualDTGV.ReadOnly = true;
            this.actualDTGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.actualDTGV.Size = new System.Drawing.Size(603, 195);
            this.actualDTGV.TabIndex = 0;
            // 
            // detallesControlPlanBindingSource
            // 
            this.detallesControlPlanBindingSource.DataMember = "detallesControlPlan";
            this.detallesControlPlanBindingSource.DataSource = this.ges_v01DataSet12;
            // 
            // ges_v01DataSet12
            // 
            this.ges_v01DataSet12.DataSetName = "ges_v01DataSet12";
            this.ges_v01DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox1);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox2);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox4);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox5);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox6);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(36, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(464, 198);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Plan Actual en Sistema";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 71);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Sección";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(8, 100);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(124, 20);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Numero de Diseño";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Enabled = false;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(187, 91);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(264, 29);
            this.bunifuMetroTextbox1.TabIndex = 11;
            this.bunifuMetroTextbox1.Text = "FA00ABA12511.006";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Enabled = false;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(187, 62);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(264, 29);
            this.bunifuMetroTextbox2.TabIndex = 10;
            this.bunifuMetroTextbox2.Text = "CS SCOCCA";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderThickness = 3;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Enabled = false;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(187, 150);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(264, 29);
            this.bunifuMetroTextbox4.TabIndex = 8;
            this.bunifuMetroTextbox4.Text = "08/12/2016";
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox5
            // 
            this.bunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox5.BorderThickness = 3;
            this.bunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox5.Enabled = false;
            this.bunifuMetroTextbox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.isPassword = false;
            this.bunifuMetroTextbox5.Location = new System.Drawing.Point(187, 120);
            this.bunifuMetroTextbox5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextbox5.Name = "bunifuMetroTextbox5";
            this.bunifuMetroTextbox5.Size = new System.Drawing.Size(264, 29);
            this.bunifuMetroTextbox5.TabIndex = 7;
            this.bunifuMetroTextbox5.Text = "3590_CS_Scocca_Rev11";
            this.bunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox6
            // 
            this.bunifuMetroTextbox6.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox6.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox6.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox6.BorderThickness = 3;
            this.bunifuMetroTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox6.Enabled = false;
            this.bunifuMetroTextbox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox6.isPassword = false;
            this.bunifuMetroTextbox6.Location = new System.Drawing.Point(187, 32);
            this.bunifuMetroTextbox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextbox6.Name = "bunifuMetroTextbox6";
            this.bunifuMetroTextbox6.Size = new System.Drawing.Size(264, 29);
            this.bunifuMetroTextbox6.TabIndex = 6;
            this.bunifuMetroTextbox6.Text = "L359016215PS300MM";
            this.bunifuMetroTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(8, 41);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(133, 20);
            this.bunifuCustomLabel6.TabIndex = 1;
            this.bunifuCustomLabel6.Text = "Codigo de Progama";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(8, 129);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(63, 20);
            this.bunifuCustomLabel7.TabIndex = 2;
            this.bunifuCustomLabel7.Text = "Revisión";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(8, 159);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomLabel8.TabIndex = 3;
            this.bunifuCustomLabel8.Text = "Fecha de actualización";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 49);
            this.panel2.TabIndex = 24;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(88, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(419, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "GESTOR DE DOCUMENTOS CONTROL PLAN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.panel4.BackgroundImage = global::PrimerasHU_GES.Properties.Resources.LOGOENCABEZADO_Mesa_de_trabajo_1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 49);
            this.panel4.TabIndex = 7;
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
            this.btn_Salir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Salir.Location = new System.Drawing.Point(1278, 0);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(64, 49);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Volver atrás";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hoja de referencia :";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(48, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Contenuti";
            this.textBox1.Visible = false;
            // 
            // registrarBtn
            // 
            this.registrarBtn.Activecolor = System.Drawing.Color.Lime;
            this.registrarBtn.BackColor = System.Drawing.Color.Blue;
            this.registrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrarBtn.BorderRadius = 0;
            this.registrarBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registrarBtn.ButtonText = "3- Registrar Control Plan en DB";
            this.registrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarBtn.DisabledColor = System.Drawing.Color.Gray;
            this.registrarBtn.Enabled = false;
            this.registrarBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.registrarBtn.Iconimage = null;
            this.registrarBtn.Iconimage_right = null;
            this.registrarBtn.Iconimage_right_Selected = null;
            this.registrarBtn.Iconimage_Selected = null;
            this.registrarBtn.IconMarginLeft = 0;
            this.registrarBtn.IconMarginRight = 0;
            this.registrarBtn.IconRightVisible = true;
            this.registrarBtn.IconRightZoom = 0D;
            this.registrarBtn.IconVisible = true;
            this.registrarBtn.IconZoom = 90D;
            this.registrarBtn.IsTab = false;
            this.registrarBtn.Location = new System.Drawing.Point(526, 332);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Normalcolor = System.Drawing.Color.Blue;
            this.registrarBtn.OnHovercolor = System.Drawing.Color.Yellow;
            this.registrarBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.registrarBtn.selected = false;
            this.registrarBtn.Size = new System.Drawing.Size(117, 77);
            this.registrarBtn.TabIndex = 16;
            this.registrarBtn.Text = "3- Registrar Control Plan en DB";
            this.registrarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registrarBtn.Textcolor = System.Drawing.Color.White;
            this.registrarBtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.Click += new System.EventHandler(this.RegistrarBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.nuevoDtgv);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(657, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 223);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Nuevo Control Plan";
            // 
            // nuevoDtgv
            // 
            this.nuevoDtgv.AllowUserToAddRows = false;
            this.nuevoDtgv.AllowUserToDeleteRows = false;
            this.nuevoDtgv.AllowUserToResizeColumns = false;
            this.nuevoDtgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nuevoDtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.nuevoDtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.nuevoDtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.nuevoDtgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.nuevoDtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nuevoDtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nuevoDtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.nuevoDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nuevoDtgv.DoubleBuffered = true;
            this.nuevoDtgv.EnableHeadersVisualStyles = false;
            this.nuevoDtgv.HeaderBgColor = System.Drawing.Color.Lime;
            this.nuevoDtgv.HeaderForeColor = System.Drawing.Color.Black;
            this.nuevoDtgv.Location = new System.Drawing.Point(47, 32);
            this.nuevoDtgv.Name = "nuevoDtgv";
            this.nuevoDtgv.ReadOnly = true;
            this.nuevoDtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.nuevoDtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nuevoDtgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.nuevoDtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nuevoDtgv.ShowCellErrors = false;
            this.nuevoDtgv.Size = new System.Drawing.Size(603, 185);
            this.nuevoDtgv.TabIndex = 0;
            this.nuevoDtgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.NuevoDtgv_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.DtFecha);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.numDisTxt);
            this.groupBox1.Controls.Add(this.descSeccionTxt);
            this.groupBox1.Controls.Add(this.revisionText);
            this.groupBox1.Controls.Add(this.codigoProTxt);
            this.groupBox1.Controls.Add(this.seccionLabel);
            this.groupBox1.Controls.Add(this.revisionLabel);
            this.groupBox1.Controls.Add(this.fechaLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(36, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(464, 194);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Plan Nuevo";
            // 
            // DtFecha
            // 
            this.DtFecha.Enabled = false;
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFecha.Location = new System.Drawing.Point(187, 152);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(264, 29);
            this.DtFecha.TabIndex = 14;
            this.DtFecha.Value = new System.DateTime(2019, 7, 15, 22, 2, 33, 0);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 71);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Sección";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(124, 20);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Numero de Diseño";
            // 
            // numDisTxt
            // 
            this.numDisTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.numDisTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numDisTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.numDisTxt.BorderThickness = 3;
            this.numDisTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDisTxt.Enabled = false;
            this.numDisTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDisTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numDisTxt.isPassword = false;
            this.numDisTxt.Location = new System.Drawing.Point(187, 91);
            this.numDisTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numDisTxt.Name = "numDisTxt";
            this.numDisTxt.Size = new System.Drawing.Size(264, 29);
            this.numDisTxt.TabIndex = 11;
            this.numDisTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // descSeccionTxt
            // 
            this.descSeccionTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.descSeccionTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descSeccionTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.descSeccionTxt.BorderThickness = 3;
            this.descSeccionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descSeccionTxt.Enabled = false;
            this.descSeccionTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descSeccionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descSeccionTxt.isPassword = false;
            this.descSeccionTxt.Location = new System.Drawing.Point(187, 62);
            this.descSeccionTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.descSeccionTxt.Name = "descSeccionTxt";
            this.descSeccionTxt.Size = new System.Drawing.Size(264, 29);
            this.descSeccionTxt.TabIndex = 10;
            this.descSeccionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // revisionText
            // 
            this.revisionText.BorderColorFocused = System.Drawing.Color.Blue;
            this.revisionText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.revisionText.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.revisionText.BorderThickness = 3;
            this.revisionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.revisionText.Enabled = false;
            this.revisionText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.revisionText.isPassword = false;
            this.revisionText.Location = new System.Drawing.Point(187, 120);
            this.revisionText.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.revisionText.Name = "revisionText";
            this.revisionText.Size = new System.Drawing.Size(264, 29);
            this.revisionText.TabIndex = 7;
            this.revisionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // codigoProTxt
            // 
            this.codigoProTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.codigoProTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codigoProTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.codigoProTxt.BorderThickness = 3;
            this.codigoProTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codigoProTxt.Enabled = false;
            this.codigoProTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoProTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codigoProTxt.isPassword = false;
            this.codigoProTxt.Location = new System.Drawing.Point(187, 32);
            this.codigoProTxt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.codigoProTxt.Name = "codigoProTxt";
            this.codigoProTxt.Size = new System.Drawing.Size(264, 29);
            this.codigoProTxt.TabIndex = 6;
            this.codigoProTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // seccionLabel
            // 
            this.seccionLabel.AutoSize = true;
            this.seccionLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionLabel.Location = new System.Drawing.Point(8, 41);
            this.seccionLabel.Name = "seccionLabel";
            this.seccionLabel.Size = new System.Drawing.Size(133, 20);
            this.seccionLabel.TabIndex = 1;
            this.seccionLabel.Text = "Codigo de Progama";
            // 
            // revisionLabel
            // 
            this.revisionLabel.AutoSize = true;
            this.revisionLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisionLabel.Location = new System.Drawing.Point(8, 129);
            this.revisionLabel.Name = "revisionLabel";
            this.revisionLabel.Size = new System.Drawing.Size(63, 20);
            this.revisionLabel.TabIndex = 2;
            this.revisionLabel.Text = "Revisión";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(8, 159);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(150, 20);
            this.fechaLabel.TabIndex = 3;
            this.fechaLabel.Text = "Fecha de actualización";
            // 
            // ges_v01DataSet
            // 
            this.ges_v01DataSet.DataSetName = "ges_v01DataSet";
            this.ges_v01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gesv01DataSetBindingSource
            // 
            this.gesv01DataSetBindingSource.DataSource = this.ges_v01DataSet;
            this.gesv01DataSetBindingSource.Position = 0;
            // 
            // detallesControlPlanTableAdapter
            // 
            this.detallesControlPlanTableAdapter.ClearBeforeFill = true;
            // 
            // ges_v01DataSet17
            // 
            this.ges_v01DataSet17.DataSetName = "ges_v01DataSet17";
            this.ges_v01DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallesControlPlanBindingSource1
            // 
            this.detallesControlPlanBindingSource1.DataMember = "detallesControlPlan";
            this.detallesControlPlanBindingSource1.DataSource = this.ges_v01DataSet17;
            // 
            // detallesControlPlanTableAdapter1
            // 
            this.detallesControlPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // idPtoMedDataGridViewTextBoxColumn
            // 
            this.idPtoMedDataGridViewTextBoxColumn.DataPropertyName = "idPtoMed";
            this.idPtoMedDataGridViewTextBoxColumn.HeaderText = "Cod. de punto";
            this.idPtoMedDataGridViewTextBoxColumn.Name = "idPtoMedDataGridViewTextBoxColumn";
            this.idPtoMedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denominacionDataGridViewTextBoxColumn
            // 
            this.denominacionDataGridViewTextBoxColumn.DataPropertyName = "denominacion";
            this.denominacionDataGridViewTextBoxColumn.HeaderText = "Denominación";
            this.denominacionDataGridViewTextBoxColumn.Name = "denominacionDataGridViewTextBoxColumn";
            this.denominacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codEntidadDataGridViewTextBoxColumn
            // 
            this.codEntidadDataGridViewTextBoxColumn.DataPropertyName = "codEntidad";
            this.codEntidadDataGridViewTextBoxColumn.HeaderText = "Entidad";
            this.codEntidadDataGridViewTextBoxColumn.Name = "codEntidadDataGridViewTextBoxColumn";
            this.codEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasiTipoPtoDataGridViewTextBoxColumn
            // 
            this.clasiTipoPtoDataGridViewTextBoxColumn.DataPropertyName = "clasiTipoPto";
            this.clasiTipoPtoDataGridViewTextBoxColumn.HeaderText = "Tipo de Punto";
            this.clasiTipoPtoDataGridViewTextBoxColumn.Name = "clasiTipoPtoDataGridViewTextBoxColumn";
            this.clasiTipoPtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTipoControlDataGridViewTextBoxColumn
            // 
            this.codTipoControlDataGridViewTextBoxColumn.DataPropertyName = "codTipoControl";
            this.codTipoControlDataGridViewTextBoxColumn.HeaderText = "Tipologia";
            this.codTipoControlDataGridViewTextBoxColumn.Name = "codTipoControlDataGridViewTextBoxColumn";
            this.codTipoControlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coordXPtoMedDataGridViewTextBoxColumn
            // 
            this.coordXPtoMedDataGridViewTextBoxColumn.DataPropertyName = "coordXPtoMed";
            this.coordXPtoMedDataGridViewTextBoxColumn.HeaderText = "X nominal";
            this.coordXPtoMedDataGridViewTextBoxColumn.Name = "coordXPtoMedDataGridViewTextBoxColumn";
            this.coordXPtoMedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coordYPtoMedDataGridViewTextBoxColumn
            // 
            this.coordYPtoMedDataGridViewTextBoxColumn.DataPropertyName = "coordYPtoMed";
            this.coordYPtoMedDataGridViewTextBoxColumn.HeaderText = "Y nominal";
            this.coordYPtoMedDataGridViewTextBoxColumn.Name = "coordYPtoMedDataGridViewTextBoxColumn";
            this.coordYPtoMedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coordZPtoMedDataGridViewTextBoxColumn
            // 
            this.coordZPtoMedDataGridViewTextBoxColumn.DataPropertyName = "coordZPtoMed";
            this.coordZPtoMedDataGridViewTextBoxColumn.HeaderText = "Z nominal";
            this.coordZPtoMedDataGridViewTextBoxColumn.Name = "coordZPtoMedDataGridViewTextBoxColumn";
            this.coordZPtoMedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominalPtoMedDataGridViewTextBoxColumn
            // 
            this.nominalPtoMedDataGridViewTextBoxColumn.DataPropertyName = "nominalPtoMed";
            this.nominalPtoMedDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalPtoMedDataGridViewTextBoxColumn.Name = "nominalPtoMedDataGridViewTextBoxColumn";
            this.nominalPtoMedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codUnidMedDataGridViewTextBoxColumn
            // 
            this.codUnidMedDataGridViewTextBoxColumn.DataPropertyName = "codUnidMed";
            this.codUnidMedDataGridViewTextBoxColumn.HeaderText = "Unidad de Medición";
            this.codUnidMedDataGridViewTextBoxColumn.Name = "codUnidMedDataGridViewTextBoxColumn";
            this.codUnidMedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tolinferior
            // 
            this.tolinferior.DataPropertyName = "tolinferior";
            this.tolinferior.HeaderText = "tol.Inferior";
            this.tolinferior.Name = "tolinferior";
            this.tolinferior.ReadOnly = true;
            // 
            // tolSuperior
            // 
            this.tolSuperior.DataPropertyName = "tolSuperior";
            this.tolSuperior.HeaderText = "tol. Superior";
            this.tolSuperior.Name = "tolSuperior";
            this.tolSuperior.ReadOnly = true;
            // 
            // RegControlPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegControlPlan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Plan";
            this.Load += new System.EventHandler(this.RegControlPlan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabeceraDtg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actualDTGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesControlPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet12)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuevoDtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesv01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ges_v01DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesControlPlanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton registrarBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox revisionText;
        private Bunifu.Framework.UI.BunifuMetroTextbox codigoProTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel seccionLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel revisionLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel fechaLabel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid cabeceraDtg;
        private ges_v01DataSet ges_v01DataSet;
        private System.Windows.Forms.BindingSource gesv01DataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox numDisTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox descSeccionTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox5;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.Button btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarTxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid actualDTGV;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton actualizarBtn;
        private Bunifu.Framework.UI.BunifuFlatButton regDetCPbtn;
        public Bunifu.Framework.UI.BunifuCustomDataGrid nuevoDtgv;
        private DateTimePicker DtFecha;
        private Panel panel4;
        private Label label8;
        private ges_v01DataSet12 ges_v01DataSet12;
        private BindingSource detallesControlPlanBindingSource;
        private ges_v01DataSet12TableAdapters.detallesControlPlanTableAdapter detallesControlPlanTableAdapter;
        private ges_v01DataSet17 ges_v01DataSet17;
        private BindingSource detallesControlPlanBindingSource1;
        private ges_v01DataSet17TableAdapters.detallesControlPlanTableAdapter detallesControlPlanTableAdapter1;
        private DataGridViewTextBoxColumn idPtoMedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn denominacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codEntidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clasiTipoPtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codTipoControlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coordXPtoMedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coordYPtoMedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coordZPtoMedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nominalPtoMedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codUnidMedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tolinferior;
        private DataGridViewTextBoxColumn tolSuperior;
    }
}