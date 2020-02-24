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
    public partial class TiposDeControl : Form
    {
        public TiposDeControl()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;
        int posicion = 0;

        private void TiposDeControl_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18_TiposDeControl2.tiposControl' Puede moverla o quitarla según sea necesario.
            this.tiposControlTableAdapter1.Fill(this.ges_v01DataSet18_TiposDeControl2.tiposControl);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18.tiposControl' Puede moverla o quitarla según sea necesario.
           // this.tiposControlTableAdapter.Fill(this.ges_v01DataSet18.tiposControl);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
        }

        private void LimpiarTipoControl()
        {
            this.tiposControlTableAdapter1.Fill(this.ges_v01DataSet18_TiposDeControl2.tiposControl);
            txtCodigoTiposControl.Text = "";
            txtDescTiposControl.Text = "";
           // this.tiposControlTableAdapter.Fill(this.ges_v01DataSet18.tiposControl);
            busqueda = 0;
        }

        private void LimpiarDGVTipoControl()
        {
            txtCodigoTiposControl.Text = "";
            txtDescTiposControl.Text = "";
            dgvTiposControl.DataSource = "";
        }

        private void btnRegTiposControl_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO tiposControl VALUES (@codTipoControl, @descTipoControl)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codTipoControl", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descTipoControl", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codTipoControl"].Value = txtCodigoTiposControl.Text;
            adaptador.InsertCommand.Parameters["@descTipoControl"].Value = txtDescTiposControl.Text;

            if (string.IsNullOrEmpty(txtDescTiposControl.Text))

            {
                MessageBox.Show("Es obligatorio completar la descripcion de Tipo de Control.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter compCodTipoCOntrol = new SqlDataAdapter("SELECT codTipoControl FROM tiposControl WHERE codTipoControl=@codTipoControl", conexion);
                    DataTable codTipoControl = new DataTable();
                    compCodTipoCOntrol.SelectCommand.Parameters.Add(new SqlParameter("@codTipoControl", SqlDbType.VarChar));
                    compCodTipoCOntrol.SelectCommand.Parameters["@codTipoControl"].Value = txtCodigoTiposControl.Text;
                    compCodTipoCOntrol.Fill(codTipoControl);

                    if (codTipoControl.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar este nuevo Tipo de Control?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el nuevo Tipo de Control.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTipoControl();
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

        private void btnModTiposControl_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE tiposControl SET descTipoControl=@descTipoControl WHERE codTipoControl=@codTipoControl", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codTipoControl", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descTipoControl", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codTipoControl"].Value = txtCodigoTiposControl.Text;
            adaptador.UpdateCommand.Parameters["@descTipoControl"].Value = txtDescTiposControl.Text;

            if (string.IsNullOrEmpty(txtCodigoTiposControl.Text) || string.IsNullOrEmpty(txtDescTiposControl.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Tipo de Control a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente el Tipo de Control. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea modificar el Tipo de Control seleccionado: " + txtCodigoTiposControl.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Tipo de Control: " + txtCodigoTiposControl.Text + " - " + txtDescTiposControl.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTipoControl();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from tiposControl", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTiposControl.DataSource = dt;
            }
        }

        private void btnLimpiarTiposControl_Click(object sender, EventArgs e)
        {
            LimpiarTipoControl();
            LimpiarDGVTipoControl();
        }

        private void btnEliminarTiposControl_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM tiposControl WHERE codTipoControl=@codTipoControl", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codTipoControl", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codTipoControl"].Value = txtCodigoTiposControl.Text;

            if (string.IsNullOrEmpty(txtCodigoTiposControl.Text) || string.IsNullOrEmpty(txtDescTiposControl.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Tipo de Control a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el Tipo de Control a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Control seleccionado: " + txtCodigoTiposControl.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Tipo de Control: " + txtCodigoTiposControl.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTipoControl();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from tiposControl", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTiposControl.DataSource = dt;
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

        private void botonVerTiposControl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tiposControl", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTiposControl.DataSource = dt;
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

        private void dgvTiposControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvTiposControl.CurrentRow.Index;

            txtCodigoTiposControl.Text = dgvTiposControl[0, posicion].Value.ToString();
            txtDescTiposControl.Text = dgvTiposControl[1, posicion].Value.ToString();
        }

        private void txtDescTiposControl_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == 0)
            {
                int posi = 0;
                char[] tipeo = txtDescTiposControl.Text.ToCharArray();
                string codTipoControl = "";
                int espacio = 0;
                int primeraLetra = 0;
                int segundaLetra = 0;
                int salida = 0;
                do
                {
                    if (posi == 0)
                    {
                        if (string.IsNullOrEmpty(txtDescTiposControl.Text))
                        {
                            posi = -1;
                        }

                        if (posi != -1)
                        {
                            codTipoControl += tipeo[posi];
                            primeraLetra++;
                        }
                    }

                    if (posi != -1)
                    {

                        if (espacio != 0 && segundaLetra == 0)
                        {
                            codTipoControl += tipeo[posi];
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

                txtCodigoTiposControl.Text = codTipoControl;
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
