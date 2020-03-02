namespace PrimerasHU_GES
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Usuario = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_Clave = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(257, 39);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 16);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Usuario:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(246, 85);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 16);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Contraseña:";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Usuario.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_Usuario.Location = new System.Drawing.Point(346, 34);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Usuario.MaxLength = 2;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(92, 26);
            this.txt_Usuario.TabIndex = 3;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            this.txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Usuario_KeyPress);
            // 
            // txt_Clave
            // 
            this.txt_Clave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Clave.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clave.ForeColor = System.Drawing.Color.Black;
            this.txt_Clave.Location = new System.Drawing.Point(346, 80);
            this.txt_Clave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Clave.MaxLength = 20;
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.PasswordChar = '*';
            this.txt_Clave.Size = new System.Drawing.Size(92, 26);
            this.txt_Clave.TabIndex = 4;
            this.txt_Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Clave.TextChanged += new System.EventHandler(this.txt_Clave_TextChanged);
            this.txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clave_KeyPress);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Black;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(232, 134);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(92, 35);
            this.btn_Entrar.TabIndex = 5;
            this.btn_Entrar.Text = "Aceptar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Black;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(346, 134);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(92, 35);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(210, 201);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 201);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Clave;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Entrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}