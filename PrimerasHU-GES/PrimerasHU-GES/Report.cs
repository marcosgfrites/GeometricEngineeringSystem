using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PrimerasHU_GES
{
    public partial class Report : Form
    {
        
        public Report()
        {
            
            InitializeComponent();
            
        }

        SqlConnection cn;
        
        private SqlCommand cmd;
        private SqlCommand cmd2;
        


        DataSet ds;
        DataSet ds2;
        SqlDataAdapter da;
        SqlDataAdapter da2;

        DataRow dr;
        DataRow dr2;
        SqlDataReader sqldr;
        SqlDataReader sqldr2;

        SqlDataAdapter adaptador;
        SqlDataAdapter adaptador1;
        SqlDataAdapter adaptador2;
       





        public void Report_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet21.analisis' Puede moverla o quitarla según sea necesario.
            this.analisisTableAdapter1.Fill(this.ges_v01DataSet21.analisis);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet20.analisis' Puede moverla o quitarla según sea necesario.
            this.analisisTableAdapter.Fill(this.ges_v01DataSet20.analisis);
            abrirConexion();
            CargarImagenes(cmbGrafico);
            CargarImagenes2(cmbImagen);
            if (cmbGrafico.Items.Count != 0)
            {
                cmbGrafico.SelectedIndex = 0;
            }

            if (cmbImagen.Items.Count != 0)
            {
                cmbImagen.SelectedIndex = 0;
            }
            btnModificar.Enabled = false;

        }
        
        public string abrirConexion()
        {
            try
            {
                cn= new SqlConnection("Data source =.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
                cn.Open();
                return "Conectado";
            }
            catch (Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }
        public void CargarImagenes(ComboBox cmbGrafico)
        {
            try
            {
                cmd = new SqlCommand("Select descGrafico from graficos",cn);
                
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    cmbGrafico.Items.Add(sqldr["descGrafico"]);
                }
                sqldr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargaron las imagenes en el ComboBox: " + ex.ToString());
            }
        }
        public void CargarImagenes2(ComboBox cmbImagen)
        {
            try
            {              
                cmd2 = new SqlCommand("Select nomImagen from imagenes", cn);

                sqldr2 = cmd2.ExecuteReader();

                while (sqldr2.Read())
                {
                    cmbImagen.Items.Add(sqldr2["nomImagen"]);
                }
                sqldr2.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("No se cargaron las imagenes en el ComboBox: " + ex2.ToString());
            }
        }

        private void btImagen_Click(object sender, EventArgs e)
        {
           
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                cn.Close();
            }
           
        }

        //Estos dos metodos permiten ver las imagenes en los picture box , segun la consulta efectuada a la base para llenar los comboBox
        public void verImagen(PictureBox pictureBox, string descripcion)
        {
            try
            {
                da = new SqlDataAdapter("Select grafica from graficos where descGrafico = '" + descripcion + "'",cn);
                ds = new DataSet();
                da.Fill(ds,"graficos");
                byte[] datos = new byte[0];
                dr = ds.Tables["graficos"].Rows[0];
                datos = (byte[])dr["grafica"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbGrafico.Image = System.Drawing.Bitmap.FromStream(ms);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen:" + ex.ToString());
            }
        }
        public void verImagen2(PictureBox pictureBox, string descripcion)
        {
            try
            {
                da2 = new SqlDataAdapter("Select imgImagen from imagenes where nomImagen = '" + descripcion + "'", cn);
                ds2 = new DataSet();
                da2.Fill(ds2, "imagenes");
                byte[] datos2 = new byte[0];
                dr2 = ds2.Tables["imagenes"].Rows[0];
                datos2 = (byte[])dr2["imgImagen"];
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(datos2);
                pbImagen.Image = System.Drawing.Bitmap.FromStream(ms2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen:" + ex.ToString());
            }
            finally
            {
                cn.Close();
            }

        }

            private void btnForm_Click_1(object sender, EventArgs e)
        {
            ShowControlImage(this);
        }

        private void btnClientArea_Click_1(object sender, EventArgs e)
        {

            using (Bitmap bm = GetFormImageWithoutBorders(this))
            {
                PrintImage(bm);
            }
        }

        private void btnGroupBox_Click(object sender, EventArgs e)
        {
            ShowControlImage(gbInforme);
        }
        

        //private void btnPage1_Click(object sender, EventArgs e)
        //{
        //    int selected = tabControl1.SelectedIndex;
        //    tabControl1.SelectedIndex = 0;

        //    ShowControlImage(tabPage1);

        //    tabControl1.SelectedIndex = selected;
        //}

        //private void btnPage2_Click(object sender, EventArgs e)
        //{
        //    int selected = tabControl1.SelectedIndex;
        //    tabControl1.SelectedIndex = 1;

        //    ShowControlImage(tabPage2);

        //    tabControl1.SelectedIndex = selected;
        //}

        private void ShowControlImage(Control ctl)
        {
            using (Bitmap bm = GetControlImage(ctl))
            {
                PrintImage(bm);
                

            }
        }

        // Devuelve un bitmap a la imagen del control
        public Bitmap GetControlImage(Control ctl)
        {
            Bitmap bm = new Bitmap(ctl.Width, ctl.Height);
            ctl.DrawToBitmap(bm, new Rectangle(0, 0, ctl.Width, ctl.Height));
            return bm;
        }

        // imagen del form sin los bordes
        private Bitmap GetFormImageWithoutBorders(Form frm)
        {
            
            using (Bitmap whole_form = GetControlImage(frm))
            {
                // See how far the form's upper left corner is
                // from the upper left corner of its client area.
                Point origin = frm.PointToScreen(new Point(0, 0));
                int dx = origin.X - frm.Left;
                int dy = origin.Y - frm.Top;

                // copia el area del cliente en un nuevo bitmap
                int wid = frm.ClientSize.Width;
                int hgt = frm.ClientSize.Height;
                Bitmap bm = new Bitmap(wid, hgt);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.DrawImage(whole_form, 0, 0,
                        new Rectangle(dx, dy, wid, hgt),
                        GraphicsUnit.Pixel);
                }
                return bm;
            }
        }

        // envia la imagen a un PrintPreviewDialog.
       
        public Image ImageToPrint;
       

        public void PrintImage(Image image)
        {
            //guarda una referencia de la imagen a imprimir
           ImageToPrint = image;
            //Imagen al portapapeles
           Clipboard.SetImage(image);

            // Muestra el dialogo
            ppdForm.ShowDialog();
        }
        public void btnClipboard_Click(object sender, EventArgs e)
        {

            //Obtiene un bitmap del control
            Bitmap cop = GetControlImage(gbInforme);
            //Imagen al portapapeles
            Clipboard.SetImage(cop);
            MessageBox.Show( lbResp.Text +" , tu analisis se copio al portapapeles");

        }

        // Imprime la pagina
        public void pdocForm_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            // Centra la imagen
            int cx = e.MarginBounds.X + e.MarginBounds.Width / 2;
            int cy = e.MarginBounds.Y + e.MarginBounds.Height / 2;
            Rectangle rect = new Rectangle(cx - ImageToPrint.Width / 2, cy - ImageToPrint.Height / 2,ImageToPrint.Width, ImageToPrint.Height);

            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.DrawImage(ImageToPrint, rect);
        }

        private void cmbGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            verImagen(pbGrafico, cmbGrafico.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                string ruta = "C:\\Desktop\\ImagenesControlPlan";

                if (Directory.Exists(ruta))
                {

                }
                else
                {
                    MessageBox.Show("La carpeta no existe , ¡Atencion! sera creada coloque alli las imagenes que desea cargar",
                        "Carpeta no existe", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    if (!(Directory.Exists(ruta)))
                    {
                        Directory.CreateDirectory(ruta);
                    }

                }
                if (rbGrafico.Checked)
                {
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName.Equals("C:\\Desktop\\ImagenesControlPlan") == false)
                    {
                        pbGrafico.Load(openFileDialog1.FileName);
                    }
                }
                  else
                    if (rbImagen.Checked)
                {
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName.Equals("C:\\Desktop\\ImagenesControlPlan") == false)
                    {
                       pbImagen.Load(openFileDialog1.FileName);
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void cmbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            verImagen2(pbImagen, cmbImagen.SelectedItem.ToString());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (cmbGrafico.Items.Count == 0 && cmbImagen.Items.Count == 0)
            {
                MessageBox.Show("Está intentando registrar un análisis que no contiene imágenes. Ambas imágenes de gráfico y/o secciones son obligatorias. Debe seleccionarlas o cargarlas de modo manual (personalizado).", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand alta = new SqlCommand("INSERT INTO analisis (grafica,imgImagen,codUsu,fechAnalisis,descripcion,observacion) VALUES (@grafica,@imgImagen,@codUsu,@fechAnalisis,@descripcion,@observacion)", cn);
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                // adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codAnalisis", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@grafica", SqlDbType.Image));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@imgImagen", SqlDbType.Image));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechAnalisis", SqlDbType.DateTime));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@observacion", SqlDbType.VarChar));




                // adaptador.InsertCommand.Parameters["@codAnalisis"].Value = lbCodAna.Text;
                // Asignando el valor del grafico

                // Stream usado como buffer
                System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                pbGrafico.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el 
                // parámetro.
                adaptador.InsertCommand.Parameters["@grafica"].Value = ms1.GetBuffer();


                // Asignando el valor de la imagen

                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el 
                // parámetro.
                adaptador.InsertCommand.Parameters["@imgImagen"].Value = ms.GetBuffer();



                adaptador.InsertCommand.Parameters["@codUsu"].Value = lbCodUsu.Text;
                adaptador.InsertCommand.Parameters["@fechAnalisis"].Value = dtCreaMod.Value;
                adaptador.InsertCommand.Parameters["@descripcion"].Value = txtDesc.Text;
                adaptador.InsertCommand.Parameters["@observacion"].Value = txtObser.Text;


                try
                {
                    cn.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Se registró el informe de manera correcta!");

                    Limpiar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }
        }

     
        private void Limpiar()
        {
            txtDesc.Text = "";     
            txtObser.Text = "";
            this.analisisTableAdapter1.Fill(this.ges_v01DataSet21.analisis);
            btnRegistro.Enabled = true;
            btnModificar.Enabled = false;
            if (cmbGrafico.Items.Count != 0)
            {
                cmbGrafico.SelectedIndex = 0;
            }

            if (cmbImagen.Items.Count != 0)
            {
                cmbImagen.SelectedIndex = 0;
            }
            verImagen2(pbImagen, cmbImagen.SelectedItem.ToString());
            verImagen(pbGrafico, cmbGrafico.SelectedItem.ToString());

        }
   
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            SqlCommand modifica = new SqlCommand("UPDATE analisis SET grafica=@grafica,imgImagen=@imgImagen,codUsu=@codUsu,fechAnalisis=@fechAnalisis,descripcion=@descripcion,observacion=@observacion WHERE codAnalisis=@codAnalisis",cn);
            adaptador1 = new SqlDataAdapter();
            adaptador1.UpdateCommand = modifica;

            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@codAnalisis", SqlDbType.Int));
            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@grafica", SqlDbType.Image));
            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@imgImagen", SqlDbType.Image));
            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));
            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@fechAnalisis", SqlDbType.DateTime));
            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador1.UpdateCommand.Parameters.Add(new SqlParameter("@observacion", SqlDbType.VarChar));


            adaptador1.UpdateCommand.Parameters["@codAnalisis"].Value = lbCodAna.Text;
            // Stream usado como buffer
            System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            pbGrafico.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.
            adaptador1.UpdateCommand.Parameters["@grafica"].Value = ms1.GetBuffer();


            // Asignando el valor de la imagen

            // Stream usado como buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.
            adaptador1.UpdateCommand.Parameters["@imgImagen"].Value = ms.GetBuffer();
            //label del codigo de usuario que esta oculta
            adaptador1.UpdateCommand.Parameters["@codUsu"].Value = lbCodUsu.Text;
            adaptador1.UpdateCommand.Parameters["@fechAnalisis"].Value = dtCreaMod.Value;
            adaptador1.UpdateCommand.Parameters["@descripcion"].Value = txtDesc.Text;
            adaptador1.UpdateCommand.Parameters["@observacion"].Value = txtObser.Text;
           
            if ((string.IsNullOrEmpty(txtObser.Text) || string.IsNullOrEmpty(txtDesc.Text)))
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar del listado el Analisis a modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult modificar = MessageBox.Show("¿Está seguro que desea modificar el elemento", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (modificar == DialogResult.OK)
                {
                    try
                    {
                        cn.Open();
                        adaptador1.UpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente el Análisis.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        cn.Close();
                       
                    }
                }
                else
                {
                    return;
                }
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posi = dataGridView1.CurrentRow.Index;

            byte[] img1 = (byte[])dataGridView1[1, posi].Value;
            MemoryStream ms1 = new MemoryStream(img1, 0, img1.Length);
            ms1.Write(img1, 0, img1.Length);
            Image pbg = Image.FromStream(ms1, true);
            pbGrafico.Image = pbg;

            byte[] img2 = (byte[])dataGridView1[2, posi].Value;
            MemoryStream ms = new MemoryStream(img2, 0, img2.Length);
            ms.Write(img2, 0, img2.Length);
            Image pbi = Image.FromStream(ms, true);
            pbImagen.Image = pbi;

            lbCodAna.Text = dataGridView1[0, posi].Value.ToString();
            txtDesc.Text = dataGridView1[5, posi].Value.ToString();
            txtObser.Text = dataGridView1[6, posi].Value.ToString();

            btnRegistro.Enabled = false;
            btnModificar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM analisis WHERE codAnalisis=@codAnalisis", cn);
            adaptador2 = new SqlDataAdapter();
            adaptador2.DeleteCommand = baja;
            adaptador2.DeleteCommand.Parameters.Add(new SqlParameter("@codAnalisis", SqlDbType.Int));


            adaptador2.DeleteCommand.Parameters["@codAnalisis"].Value = int.Parse(lbCodAna.Text);
            try
            {
                if (lbCodAna.Text == null)
                {
                    MessageBox.Show("No ha seleccionado ningun registro para borrar. Debe seleccionar una del listado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cn.Open();
                    int cantidad = adaptador2.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El elemento seleccionado no existe.");
                    }
                    else
                    {
                        MessageBox.Show("El elemento elegido ha sido borrado con éxito!");
                    }
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Report_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
