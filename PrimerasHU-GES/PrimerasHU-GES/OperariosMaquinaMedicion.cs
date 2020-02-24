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
    public partial class OperariosMaquinaMedicion : Form
    {
        #region DLLs para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public OperariosMaquinaMedicion()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;
        int posicion = 0;

        private void OperariosMaquinaMedicion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet8.operariosMaquina' Puede moverla o quitarla según sea necesario.
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet8.operariosMaquina);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
        }
        private void LimpiarOperario()
        {
            txtCodigoOperario.Text = "";
            txtNombreOperario.Text = "";
            //this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet8.operariosMaquina);
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet8.operariosMaquina);
            busqueda = 0;
        }

        private void LimpiarDGVOperarios()
        {
            txtCodigoOperario.Text = "";
            txtNombreOperario.Text = "";
            dgvOperarios.DataSource = "";
        }

        private void BtnRegOperario_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO operariosMaquina (nomOper) VALUES (@nomOper)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
            adaptador.InsertCommand.Parameters["@nomOper"].Value = txtNombreOperario.Text;

            if (string.IsNullOrEmpty(txtNombreOperario.Text))

            {
                MessageBox.Show("Es obligatorio completar el Nombre del operario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter compCodOperario = new SqlDataAdapter("SELECT codOper FROM operariosMaquina WHERE codOper=@codOper", conexion);
                    DataTable codOperario = new DataTable();
                    compCodOperario.SelectCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.VarChar));
                    compCodOperario.SelectCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
                    compCodOperario.Fill(codOperario);

                    if (codOperario.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar este nuevo Operario?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el nuevo Operario de Maquina.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
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

        private void BtnConsultarOperario_Click(object sender, EventArgs e)
        {
            /*SqlCommand consultar = new SqlCommand("SELECT * FROM operariosMaquina WHERE codOper=@codOper", conexion);
            adaptador.SelectCommand = consultar;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));

            adaptador.SelectCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código de Operario' para buscar el Operario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    adaptador.Fill(datos, "operariosMaquina");
                    int registro = int.Parse(datos.Tables["operariosMaquina"].Rows.Count.ToString());
                    if (registro >= 0)
                    {
                        foreach (DataRow fila in datos.Tables["operariosMaquina"].Rows)
                        {
                            txtCodigoOperario.Text = fila["codOper"].ToString();
                            txtNombreOperario.Text = fila["nomOper"].ToString();
                        }
                        busqueda = 1;
                    }
                    else
                    {
                        MessageBox.Show("El 'Código de Operario' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOperarios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }

                finally
                {
                    conexion.Close();
                }
            }*/ 
        }

        private void BtnModOperario_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE operariosMaquina SET nomOper=@nomOper WHERE codOper=@codOper", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
            adaptador.UpdateCommand.Parameters["@nomOper"].Value = txtNombreOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text) || string.IsNullOrEmpty(txtNombreOperario.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Operario a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente al Operario. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                   // adaptador.UpdateCommand.ExecuteNonQuery();
                   // MessageBox.Show("Se ha modificado correctamente el nombre del Operario", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // LimpiarOperario();
                    if (MessageBox.Show("¿Está seguro que desea modificar el Operario seleccionado: " + txtCodigoOperario.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Operario de Maquina: " + txtCodigoOperario.Text + " - " + txtNombreOperario.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOperarios.DataSource = dt;
            }
        }

        private void BtnLimpiarOperario_Click(object sender, EventArgs e)
        {
            LimpiarOperario();
            LimpiarDGVOperarios();
        }

        private void BtnEliminarOperario_Click(object sender, EventArgs e)
        {


            SqlCommand baja = new SqlCommand("DELETE FROM operariosMaquina WHERE codOper=@codOper", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text) || string.IsNullOrEmpty(txtNombreOperario.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Operario a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el Operario a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    /*int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El Operario: " + txtCodigoOperario.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
                    }*/

                    if (MessageBox.Show("¿Está seguro que desea eliminar al Operario seleccionado: " + txtNombreOperario.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Operario: " + txtCodigoOperario.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOperarios.DataSource = dt;
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

        private void BotonVerOperarios_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOperarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void DgvOperarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvOperarios.CurrentRow.Index;

            txtCodigoOperario.Text = dgvOperarios[0, posicion].Value.ToString();
            txtNombreOperario.Text = dgvOperarios[1, posicion].Value.ToString();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OperariosMaquinaMedicion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
