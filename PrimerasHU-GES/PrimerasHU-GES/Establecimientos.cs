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
    public partial class Establecimientos : Form
    {
        #region DLLs para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public Establecimientos()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;
        int posicion = 0;

        private void Establecimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18_Establecimientos2.establecimientos' Puede moverla o quitarla según sea necesario.
            this.establecimientosTableAdapter1.Fill(this.ges_v01DataSet18_Establecimientos2.establecimientos);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet19.establecimientos' Puede moverla o quitarla según sea necesario.
        //    this.establecimientosTableAdapter.Fill(this.ges_v01DataSet19_Establecimientos.establecimientos);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
        }

        private void LimpiarEstablecimiento()
        {
            this.establecimientosTableAdapter1.Fill(this.ges_v01DataSet18_Establecimientos2.establecimientos);
            txtCodigoEstablecimiento.Text = "";
            txtDescEstablecimiento.Text = "";
           // this.establecimientosTableAdapter.Fill(this.ges_v01DataSet19_Establecimientos.establecimientos);
            busqueda = 0;
        }

        private void LimpiarDGVEstablecimiento()
        {
            txtCodigoEstablecimiento.Text = "";
            txtDescEstablecimiento.Text = "";
            dgvEstablecimiento.DataSource = "";
        }

        private void btnRegEstablecimiento_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO establecimientos VALUES (@codEstablecimiento, @descEstablecimiento)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codEstablecimiento", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descEstablecimiento", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codEstablecimiento"].Value = txtCodigoEstablecimiento.Text;
            adaptador.InsertCommand.Parameters["@descEstablecimiento"].Value = txtDescEstablecimiento.Text;

            if (string.IsNullOrEmpty(txtDescEstablecimiento.Text))

            {
                MessageBox.Show("Es obligatorio completar la descripcion de Establecimiento.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter compcodEstablecimiento = new SqlDataAdapter("SELECT codEstablecimiento FROM establecimientos WHERE codEstablecimiento=@codEstablecimiento", conexion);
                    DataTable codEstablecimiento = new DataTable();
                    compcodEstablecimiento.SelectCommand.Parameters.Add(new SqlParameter("@codEstablecimiento", SqlDbType.VarChar));
                    compcodEstablecimiento.SelectCommand.Parameters["@codEstablecimiento"].Value = txtCodigoEstablecimiento.Text;
                    compcodEstablecimiento.Fill(codEstablecimiento);

                    if (codEstablecimiento.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar esta nuevo Establecimiento?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el nuevo Establecimiento.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEstablecimiento();
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

        private void btnModEstablecimiento_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE establecimientos SET descEstablecimiento=@descEstablecimiento WHERE codEstablecimiento=@codEstablecimiento", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codEstablecimiento", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descEstablecimiento", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codEstablecimiento"].Value = txtCodigoEstablecimiento.Text;
            adaptador.UpdateCommand.Parameters["@descEstablecimiento"].Value = txtDescEstablecimiento.Text;

            if (string.IsNullOrEmpty(txtCodigoEstablecimiento.Text) || string.IsNullOrEmpty(txtDescEstablecimiento.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Establecimiento a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente el Establecimiento. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea modificar el Establecimiento seleccionado: " + txtCodigoEstablecimiento.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Establecimiento: " + txtCodigoEstablecimiento.Text + " - " + txtDescEstablecimiento.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEstablecimiento();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from establecimientos", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEstablecimiento.DataSource = dt;
            }
        }

        private void btnLimpiarEstablecimiento_Click(object sender, EventArgs e)
        {
            LimpiarEstablecimiento();
            LimpiarDGVEstablecimiento();
        }

        private void btnEliminarEstablecimiento_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM establecimientos WHERE codEstablecimiento=@codEstablecimiento", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codEstablecimiento", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codEstablecimiento"].Value = txtCodigoEstablecimiento.Text;

            if (string.IsNullOrEmpty(txtCodigoEstablecimiento.Text) || string.IsNullOrEmpty(txtDescEstablecimiento.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Establecimiento a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el establecimiento a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea eliminar el Establecimiento seleccionado: " + txtCodigoEstablecimiento.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El establecimiento: " + txtCodigoEstablecimiento.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEstablecimiento();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from establecimientos", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEstablecimiento.DataSource = dt;
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

        private void botonVerEstablecimiento_Click(object sender, EventArgs e)
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from establecimientos", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEstablecimiento.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void dgvEstablecimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvEstablecimiento.CurrentRow.Index;

            txtCodigoEstablecimiento.Text = dgvEstablecimiento[0, posicion].Value.ToString();
            txtDescEstablecimiento.Text = dgvEstablecimiento[1, posicion].Value.ToString();
        }

        private void txtDescEstablecimiento_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == 0)
            {
                int posi = 0;
                char[] tipeo = txtDescEstablecimiento.Text.ToCharArray();
                string codEstablecimiento = "";
                int espacio = 0;
                int primeraLetra = 0;
                int segundaLetra = 0;
                int salida = 0;
                do
                {
                    if (posi == 0)
                    {
                        if (string.IsNullOrEmpty(txtDescEstablecimiento.Text))
                        {
                            posi = -1;
                        }

                        if (posi != -1)
                        {
                            codEstablecimiento += tipeo[posi];
                            primeraLetra++;
                        }
                    }

                    if (posi != -1)
                    {

                        if (espacio != 0 && segundaLetra == 0)
                        {
                            codEstablecimiento += tipeo[posi];
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

                txtCodigoEstablecimiento.Text = codEstablecimiento;
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

        private void Establecimientos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
