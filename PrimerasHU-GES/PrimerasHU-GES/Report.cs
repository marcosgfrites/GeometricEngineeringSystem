using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System;
using System.Data.SqlClient;
using System.IO;

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
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;

        
        
        private void Report_Load(object sender, EventArgs e)
        {
          
           
            
            //--------------------------------------------------------------------------------------------
            abrirConexion();
            CargarImagenes(cmbGrafico);
            cmbGrafico.SelectedIndex = 0;
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
                    this.cmbGrafico.Items.Add(sqldr["descGrafico"]);
                }
                sqldr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargaron las imagenes en el ComboBox: " + ex.ToString());
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
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
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
        private Bitmap GetControlImage(Control ctl)
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
       
        private Image ImageToPrint;
        private void PrintImage(Image image)
        {
            //guarda una referencia de la imagen a imprimir
            ImageToPrint = image;

            // Display the dialog.
            ppdForm.ShowDialog();
        }

        // Imprime la pagina
        private void pdocForm_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            // Centra la imagen
            int cx = e.MarginBounds.X + e.MarginBounds.Width / 2;
            int cy = e.MarginBounds.Y + e.MarginBounds.Height / 2;
            Rectangle rect = new Rectangle(
                cx - ImageToPrint.Width / 2, cy - ImageToPrint.Height / 2,
                ImageToPrint.Width, ImageToPrint.Height);

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
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pbGrafico.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }
    }
}
