using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    public partial class UnidadesMedicion : Form
    {
        #region DLLs para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public UnidadesMedicion()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;
        int posicion = 0;

        private void UnidadesMedicion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18_UdeMed2.unidadesMedicion' Puede moverla o quitarla según sea necesario.
            this.unidadesMedicionTableAdapter1.Fill(this.ges_v01DataSet18_UdeMed2.unidadesMedicion);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet20UdeMed.unidadesMedicion' Puede moverla o quitarla según sea necesario.
           // this.unidadesMedicionTableAdapter.Fill(this.ges_v01DataSet20UdeMed.unidadesMedicion);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
        }
        private void LimpiarUdeMed()
        {
            this.unidadesMedicionTableAdapter1.Fill(this.ges_v01DataSet18_UdeMed2.unidadesMedicion);
            txtCodigoUdeMed.Text = "";
            txtDescUdeMed.Text = "";
           // this.unidadesMedicionTableAdapter.Fill(this.ges_v01DataSet20UdeMed.unidadesMedicion);
            busqueda = 0;
        }

        private void LimpiarDGVUdeMed()
        {
            txtCodigoUdeMed.Text = "";
            txtDescUdeMed.Text = "";
            dgvUdeMed.DataSource = "";
        }
        private void btnRegUdeMed_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO unidadesMedicion VALUES (@codUnidMed,@descUnidMed)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codUnidMed", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descUnidMed", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codUnidMed"].Value = txtCodigoUdeMed.Text;
            adaptador.InsertCommand.Parameters["@descUnidMed"].Value = txtDescUdeMed.Text;

            if (string.IsNullOrEmpty(txtDescUdeMed.Text))

            {
                MessageBox.Show("Es obligatorio completar la descripcion de la Unidad de Medicion.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter compcodUnidMed = new SqlDataAdapter("SELECT codUnidMed FROM unidadesMedicion WHERE codUnidMed=@codUnidMed", conexion);
                    DataTable codUnidMed = new DataTable();
                    compcodUnidMed.SelectCommand.Parameters.Add(new SqlParameter("@codUnidMed", SqlDbType.VarChar));
                    compcodUnidMed.SelectCommand.Parameters["@codUnidMed"].Value = txtCodigoUdeMed.Text;
                    compcodUnidMed.Fill(codUnidMed);

                    if (codUnidMed.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar esta nueva Unidad de Medicion?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente la nueva Unidad de medicion.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarUdeMed();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btnModUdeMed_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE unidadesMedicion SET descUnidMed=@descUnidMed WHERE codUnidMed=@codUnidMed", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codUnidMed", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descUnidMed", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codUnidMed"].Value = txtCodigoUdeMed.Text;
            adaptador.UpdateCommand.Parameters["@descUnidMed"].Value = txtDescUdeMed.Text;

            if (string.IsNullOrEmpty(txtCodigoUdeMed.Text) || string.IsNullOrEmpty(txtDescUdeMed.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar la Unidad de Medicion a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente la Unidad de medicion. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea modificar la Unidad de Medicion seleccionada: " + txtCodigoUdeMed.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("La Unidad de Medicion: " + txtCodigoUdeMed.Text + " - " + txtDescUdeMed.Text + ", fue modificada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarUdeMed();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    conexion.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from unidadesMedicion", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUdeMed.DataSource = dt;
            }
        }

        private void btnLimpiarUdeMed_Click(object sender, EventArgs e)
        {
            LimpiarUdeMed();
            LimpiarDGVUdeMed();
        }

        private void btnEliminarUdeMed_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM unidadesMedicion WHERE codUnidMed=@codUnidMed", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codUnidMed", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codUnidMed"].Value = txtCodigoUdeMed.Text;

            if (string.IsNullOrEmpty(txtCodigoUdeMed.Text) || string.IsNullOrEmpty(txtCodigoUdeMed.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar la Unidad de Medicion a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar la Unidad de Medicion a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea eliminar la Unidad de Medicion seleccionada: " + txtCodigoUdeMed.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("La Unidad de Medicion: " + txtCodigoUdeMed.Text + ", fue eliminada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarUdeMed();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from unidadesMedicion", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUdeMed.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void botonVerUdeMed_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from unidadesMedicion", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUdeMed.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvUdeMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvUdeMed.CurrentRow.Index;

            txtCodigoUdeMed.Text = dgvUdeMed[0, posicion].Value.ToString();
            txtDescUdeMed.Text = dgvUdeMed[1, posicion].Value.ToString();
        }

        private void txtDescUdeMed_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == 0)
            {
                int posi = 0;
                char[] tipeo = txtDescUdeMed.Text.ToCharArray();
                string codUdeMed = "";
                int espacio = 0;
                int primeraLetra = 0;
                int segundaLetra = 0;
                int salida = 0;
                do
                {
                    if (posi == 0)
                    {
                        if (string.IsNullOrEmpty(txtDescUdeMed.Text))
                        {
                            posi = -1;
                        }

                        if (posi != -1)
                        {
                            codUdeMed += tipeo[posi];
                            primeraLetra++;
                        }
                    }

                    if (posi != -1)
                    {

                        if (espacio != 0 && segundaLetra == 0)
                        {
                            codUdeMed += tipeo[posi];
                            segundaLetra++;
                        }

                        if (tipeo[posi] == ' ')
                        {
                            espacio++;
                        }
                    }

                    if (posi == tipeo.Length - 1)
                    {
                        salida++;
                    }
                    posi++;
                } while (salida == 0);

                txtCodigoUdeMed.Text = codUdeMed;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UnidadesMedicion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
