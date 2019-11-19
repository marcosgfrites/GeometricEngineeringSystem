using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PrimerasHU_GES
{
    public partial class RegistroGrafico : Form
    {
        public RegistroGrafico(Bitmap bm, string muestra, string[]leyenda)
        {
            InitializeComponent();
            pb_regGrafico.Image = Clipboard.GetImage();
            txt_regGraficoMuestra.Text = muestra;
            string comentario = "Puntos Contenidos en el gráfico: ";
            for(int i=0;i<leyenda.Length;i++)
            {
                comentario += "\n - "+leyenda[i].ToString()+".";
            }
            txt_descGrafico.Text = comentario;
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;

        private void RegistroGrafico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18TiposGraficos.tiposGrafico' Puede moverla o quitarla según sea necesario.
            this.tiposGraficoTableAdapter.Fill(this.ges_v01DataSet18TiposGraficos.tiposGrafico);
            cb_regGraficoTipoG.SelectedItem = "Muestras";

            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //cargar lo siguiente para el movimiento del panel 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RegistroGrafico_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_registrarGrafico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombreGrafico.Text))
            {
                MessageBox.Show("El Nombre es un campo obligatorio para el registro del gráfico.", "Atención!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand registro = new SqlCommand("INSERT INTO graficos(codMuestra,codTiposGraf,nomGrafico,grafica,descGrafico) VALUES (@codMuestra,@codTiposGraf,@nomGrafico,@grafica,@descGrafico)", Conexion);
                adaptador.InsertCommand = registro;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codMuestra", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codTiposGraf", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomGrafico", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@grafica", SqlDbType.Image));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descGrafico", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@codMuestra"].Value = Convert.ToInt32(txt_regGraficoMuestra.Text);
                adaptador.InsertCommand.Parameters["@codTiposGraf"].Value = cb_regGraficoTipoG.SelectedValue;
                adaptador.InsertCommand.Parameters["@nomGrafico"].Value = txt_nombreGrafico.Text;

                MemoryStream ms = new MemoryStream();
                pb_regGrafico.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] file = null;
                file = ms.ToArray();

                adaptador.InsertCommand.Parameters["@grafica"].Value = file;
                
                string auxComentarios = "";
                if (string.IsNullOrEmpty(txt_descGrafico.Text))
                {
                    auxComentarios = null;
                }
                else
                {
                    auxComentarios = txt_descGrafico.Text;
                }
                adaptador.InsertCommand.Parameters["@descGrafico"].Value = auxComentarios;

                try
                {
                    Conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("El gráfico se ha registrado correctamente.","Felicidades!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                }
            }
        }

        private void limpiar()
        {
            txt_descGrafico.Text = "";
            txt_nombreGrafico.Text = "";
            txt_regGraficoMuestra.Text = "";
            pb_regGrafico.Image = null;
            btn_registrarGrafico.Enabled = false;
        }
    }
}
