using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Globalization;

namespace PrimerasHU_GES
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }
        //variable para almacenar la selección del DataGridView
        int posi;

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        //private DataSet datos;
        DateTime fechoraCreacion;


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_BuscarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Imagen.Image = Image.FromFile(openFileDialog1.FileName);
                txt_Archivo.Text = openFileDialog1.FileName;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_NomImg.Text.Trim().Equals("") || txt_Archivo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nombre y Archivo son campos obligatorios!");
                return;
            }
            else
            {
                Conexion.Open();
                SqlDataAdapter existe = new SqlDataAdapter("SELECT nomImagen FROM imagenes WHERE nomImagen=@nomImagen", Conexion);
                DataTable tImagen = new DataTable();
                existe.SelectCommand.Parameters.Add(new SqlParameter("@nomImagen", SqlDbType.VarChar));
                existe.SelectCommand.Parameters["@nomImagen"].Value = txt_NomImg.Text;
                existe.Fill(tImagen);
                if (tImagen.Rows.Count == 0)
                {
                    //comienzo a preparar la info a guardar
                    byte[] file = null;
                    Stream myStream = openFileDialog1.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        myStream.CopyTo(ms);
                        file = ms.ToArray();
                    }

                    adaptador.InsertCommand.Parameters["@codCPlan"].Value = cb_controlPlanImagenes.SelectedValue;
                    adaptador.InsertCommand.Parameters["@nomImagen"].Value = txt_NomImg.Text;
                    adaptador.InsertCommand.Parameters["@imgImagen"].Value = file;
                    fechoraCreacion = DateTime.Today;
                    adaptador.InsertCommand.Parameters["@fechoraCreImagen"].Value = fechoraCreacion;
                    adaptador.InsertCommand.Parameters["@fechoraModImagen"].Value = fechoraCreacion;
                    //termino de preparar la info a guardar
                    try
                    {
                        //Conexion.Open(); >> NO ABRO LA CONEXION PORQUE YA LA ABRI ANTES
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se registró la imagen de manera correcta!");
                        this.imagenesTableAdapter.Fill(this.ges_v01Imagenes4.imagenes);
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
                else
                {
                    MessageBox.Show("Ya existe una imagen con el mismo nombre. Para conocer los nombre utilizados, inspeccione el listado. Presione el botón Ver 'Listado'.","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    Conexion.Close();
                }

            }
        }

        public void alternarColoresDgv(DataGridView dgv_Imagenes)
        {
            dgv_Imagenes.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_Imagenes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void Imagenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01Imagenes4.imagenes' Puede moverla o quitarla según sea necesario.
            this.imagenesTableAdapter.Fill(this.ges_v01Imagenes4.imagenes);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01Imagenes2.controlPlan' Puede moverla o quitarla según sea necesario.
            this.controlPlanTableAdapter.Fill(this.ges_v01Imagenes2.controlPlan);
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            SqlCommand alta = new SqlCommand("INSERT INTO imagenes (codCPlan,nomImagen,imgImagen,fechoraCreImagen,fechoraModImagen) VALUES (@codCPlan,@nomImagen,@imgImagen,@fechoraCreImagen,@fechoraModImagen)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codCPlan", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomImagen", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@imgImagen", SqlDbType.Image));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechoraCreImagen", SqlDbType.DateTime));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechoraModImagen", SqlDbType.DateTime));


            SqlCommand consulta = new SqlCommand("SELECT codImagen AS Código,nomImagen AS Nombre,imgImagen AS Imagen FROM imagenes", Conexion);
            adaptador.SelectCommand = consulta;

            SqlCommand baja = new SqlCommand("DELETE FROM imagenes WHERE codImagen=@codImagen", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codImagen",SqlDbType.Int));

            alternarColoresDgv(dgv_Imagenes);
            fechoraCreacion = DateTime.Now;
            txt_fechoraCreacion.Text = fechoraCreacion.ToString("G");
            txt_fechoraModif.Text = fechoraCreacion.ToString("G");
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txt_NomImg.Text = "";
            txt_Archivo.Text = "";
            pb_Imagen.Image = null;
            fechoraCreacion = DateTime.Now;
            txt_fechoraCreacion.Text = fechoraCreacion.ToString("G");
            txt_fechoraModif.Text = fechoraCreacion.ToString("G");
            this.imagenesTableAdapter.Fill(this.ges_v01Imagenes4.imagenes);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.imagenesTableAdapter.Fill(this.ges_v01Imagenes4.imagenes);
                /*
                Conexion.Open();
                DataTable t = new DataTable();
                adaptador.Fill(t);
                dgv_Imagenes.DataSource = t;
                */
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

        
        private void dgv_Imagenes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgv_Imagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //RECUPERO LOS DATOS DE LA FILA SELECCIONADA EN EL DATAGRIDVIEW
            try
            {
                // RECUPERA LA POSICIÓN SELECCIONADA EN EL DATAGRIDVIEW
                posi = dgv_Imagenes.CurrentRow.Index;

                txt_Codigo.Text = dgv_Imagenes[0, posi].Value.ToString();
                cb_controlPlanImagenes.SelectedItem = dgv_Imagenes[1, posi].Value.ToString();
                txt_NomImg.Text = dgv_Imagenes[2, posi].Value.ToString();
                txt_fechoraCreacion.Text = dgv_Imagenes[3, posi].Value.ToString();
                txt_fechoraModif.Text = dgv_Imagenes[4, posi].Value.ToString();
                //CONVIERTO DE ARRAY DE BITS A IMAGEN
                byte[] img = (byte[])dgv_Imagenes[5, posi].Value;
                MemoryStream ms = new MemoryStream(img,0,img.Length);
                ms.Write(img,0,img.Length);
                Image pb = Image.FromStream(ms,true);
                pb_Imagen.Image = pb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@codImagen"].Value = int.Parse(txt_Codigo.Text);
            try
            {
                if (txt_Codigo.Text == null)
                {
                    MessageBox.Show("No ha seleccionado ninguna imagen para borrar. Debe seleccionar una del listado.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    Conexion.Open();
                    int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El elemento seleccionado no existe.");
                    }
                    else
                    {
                        MessageBox.Show("El elemento elegido ha sido borrado con éxito!. Recuerde actualizar el listado.");
                    }
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conexion.Close();
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
