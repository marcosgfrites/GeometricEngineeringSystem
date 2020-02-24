using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    public partial class Entidades : Form
    {
        public Entidades()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;
        int posicion = 0;

        private void Entidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18Entidades2.entidades' Puede moverla o quitarla según sea necesario.
            this.entidadesTableAdapter1.Fill(this.ges_v01DataSet18Entidades2.entidades);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet17.entidades' Puede moverla o quitarla según sea necesario.
            //this.entidadesTableAdapter.Fill(this.ges_v01DataSet17_Entidades.entidades);

            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarEntidad() 
        {
            this.entidadesTableAdapter1.Fill(this.ges_v01DataSet18Entidades2.entidades);
            txtCodigoEntidad.Text = "";
            txtDescEntidad.Text = "";
           // this.entidadesTableAdapter.Fill(this.ges_v01DataSet17_Entidades.entidades);
            busqueda = 0;
        }

        private void LimpiarDGVEntidades() 
        {
            txtCodigoEntidad.Text = "";
            txtDescEntidad.Text = "";
            dgvEntidad.DataSource = "";
        }

        private void btnRegEntidad_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO entidades VALUES (@codEntidad, @descEntidad)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codEntidad", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descEntidad", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codEntidad"].Value = txtCodigoEntidad.Text;
            adaptador.InsertCommand.Parameters["@descEntidad"].Value = txtDescEntidad.Text;

            if (string.IsNullOrEmpty(txtDescEntidad.Text))

            {
                MessageBox.Show("Es obligatorio completar la descripcion de la Entidad.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter compCodEntidad = new SqlDataAdapter("SELECT codEntidad FROM entidades WHERE codEntidad=@codEntidad", conexion);
                    DataTable codEntidad = new DataTable();
                    compCodEntidad.SelectCommand.Parameters.Add(new SqlParameter("@codEntidad", SqlDbType.VarChar));
                    compCodEntidad.SelectCommand.Parameters["@codEntidad"].Value = txtCodigoEntidad.Text;
                    compCodEntidad.Fill(codEntidad);

                    if (codEntidad.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar esta nuevo Entidad?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente la nueva Entidad.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEntidad();
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

        private void btnModEntidad_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE entidades SET descEntidad=@descEntidad WHERE codEntidad=@codEntidad", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codEntidad", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descEntidad", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codEntidad"].Value = txtCodigoEntidad.Text;
            adaptador.UpdateCommand.Parameters["@descEntidad"].Value = txtDescEntidad.Text;

            if (string.IsNullOrEmpty(txtCodigoEntidad.Text) || string.IsNullOrEmpty(txtDescEntidad.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar la Entidad a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente la Entidad. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea modificar la Entidad seleccionada: " + txtCodigoEntidad.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("La Entidad: " + txtCodigoEntidad.Text + " - " + txtDescEntidad.Text + ", fue modificada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEntidad();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from entidades", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEntidad.DataSource = dt;
            }
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            LimpiarEntidad();
            LimpiarDGVEntidades();
        }

        private void btnEliminarEntidad_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM entidades WHERE codEntidad=@codEntidad", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codEntidad", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codEntidad"].Value = txtCodigoEntidad.Text;

            if (string.IsNullOrEmpty(txtCodigoEntidad.Text) || string.IsNullOrEmpty(txtDescEntidad.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar la Entidad a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar la Entidad a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea eliminar la Entidad seleccionada: " + txtCodigoEntidad.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("La Entidad: " + txtCodigoEntidad.Text + ", fue eliminada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEntidad();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from entidades", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEntidad.DataSource = dt;
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

        private void botonVerEntidad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from entidades", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEntidad.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
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

        private void dgvEntidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvEntidad.CurrentRow.Index;

            txtCodigoEntidad.Text = dgvEntidad[0, posicion].Value.ToString();
            txtDescEntidad.Text = dgvEntidad[1, posicion].Value.ToString();
        }

        private void txtDescEntidad_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == 0)
            {
                int posi = 0;
                char[] tipeo = txtDescEntidad.Text.ToCharArray();
                string codEntidad = "";
                int espacio = 0;
                int primeraLetra = 0;
                int segundaLetra = 0;
                int salida = 0;
                do
                {
                    if (posi == 0)
                    {
                        if (string.IsNullOrEmpty(txtDescEntidad.Text))
                        {
                            posi = -1;
                        }

                        if (posi != -1)
                        {
                            codEntidad += tipeo[posi];
                            primeraLetra++;
                        }
                    }

                    if (posi != -1)
                    {

                        if (espacio != 0 && segundaLetra == 0)
                        {
                            codEntidad += tipeo[posi];
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

                txtCodigoEntidad.Text = codEntidad;
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
    }
}