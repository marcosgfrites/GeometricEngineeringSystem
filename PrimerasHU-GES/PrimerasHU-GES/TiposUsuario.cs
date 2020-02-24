using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimerasHU_GES
{
    public partial class TiposUsuario : Form
    {
        public TiposUsuario()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_ultEstado;

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_min_Click(object sender, EventArgs e)
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

        private void TiposUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetTiposUsuario.tiposUsuario' Puede moverla o quitarla según sea necesario.
            this.tiposUsuarioTableAdapter.Fill(this.ges_v01DataSetTiposUsuario.tiposUsuario);
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            recuperarUltimoCodigo();
        }

        private void recuperarUltimoCodigo()
        {
            //HAY QUE TENER EN CUENTA QUE EL CÓDIGO DE MUESTRA ES AUTOINCREMENTABLE, NO LO VAMOS A ASIGNAR NOSOTROS
            //RECUPERO EL ÚLTIMO CÓDIGO DE MUESTRA UTILIZADO Y MUESTRO EL CODIGO NUEVO QUE INGRESARA. EN CASO DE LA TABLA ESTAR VACIA SE LE ASIGNA EL PRIMERO
            SqlCommand ultEstado = new SqlCommand("SELECT TOP 1 codTipoUsu FROM tiposUsuario ORDER BY codTipoUsu DESC", Conexion);
            ad_ultEstado = new SqlDataAdapter(ultEstado);
            DataTable dt_ultEstado = new DataTable();
            ad_ultEstado.Fill(dt_ultEstado);
            if (dt_ultEstado.Rows.Count == 0)
            {
                txt_codigo.Text = "1";
            }
            else
            {
                string aux_codNvo = dt_ultEstado.Rows[0][0].ToString();
                int codNvo = 0;
                codNvo = Convert.ToInt32(aux_codNvo);
                codNvo++;
                txt_codigo.Text = codNvo.ToString(); //PRUEBA DE PUSH/PULL EN GITHUB >> ALGO ESTÁ FALLANDO
            }
        }

        private void limpiar()
        {
            txt_descripcion.Text = "";
            recuperarUltimoCodigo();
            this.tiposUsuarioTableAdapter.Fill(this.ges_v01DataSetTiposUsuario.tiposUsuario);
            btn_registrar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv_tiposUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posi = dgv_tiposUsuario.CurrentRow.Index;

            txt_codigo.Text = dgv_tiposUsuario[0, posi].Value.ToString();
            txt_descripcion.Text = dgv_tiposUsuario[1, posi].Value.ToString();

            btn_registrar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Debe escribir una descripción.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand existeDesc = new SqlCommand("SELECT descTipoUsu FROM tiposUsuario WHERE UPPER(descTipoUsu) = UPPER('" + txt_descripcion.Text + "')", Conexion);
                adaptador = new SqlDataAdapter(existeDesc);

                DataTable dt_existeDesc = new DataTable();
                adaptador.Fill(dt_existeDesc);
                if (dt_existeDesc.Rows.Count != 0)
                {
                    MessageBox.Show("El tipo de usuario que intenta registrar, ya existe. Inténtelo nuevamente o póngase en contacto con el administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand alta = new SqlCommand("INSERT INTO tiposUsuario (descTipoUsu) VALUES (@descTipoUsu)", Conexion);
                    adaptador = new SqlDataAdapter();
                    adaptador.InsertCommand = alta;
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descTipoUsu", SqlDbType.VarChar));
                    adaptador.InsertCommand.Parameters["@descTipoUsu"].Value = txt_descripcion.Text;
                    try
                    {
                        Conexion.Open();
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("El tipo de usuario fue registrado con éxito.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM tiposUsuario WHERE codTipoUsu=@codTipoUsu", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codTipoUsu", SqlDbType.Int));

            adaptador.DeleteCommand.Parameters["@codTipoUsu"].Value = Convert.ToInt32(txt_codigo.Text);

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Es necesario seleccionar del listado el 'Tipo de Usuario' a eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el elemento con código: '" + txt_codigo.Text + "'?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                        if (cantidad == 0)
                        {
                            MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("El 'Código': " + txt_codigo.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiar();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE tiposUsuario SET descTipoUsu=@descTipoUsu WHERE codTipoUsu=@codTipoUsu", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codTipoUsu", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descTipoUsu", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codTipoUsu"].Value = txt_codigo.Text;
            adaptador.UpdateCommand.Parameters["@descTipoUsu"].Value = txt_descripcion.Text;

            if ((string.IsNullOrEmpty(txt_codigo.Text) || string.IsNullOrEmpty(txt_descripcion.Text)))
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar del listado el 'Tipo de Usuario' a modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult modificar = MessageBox.Show("¿Está seguro que desea modificar el elemento con código: '" + txt_codigo.Text + "' (Nueva descripción: " + txt_descripcion.Text + ")?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (modificar == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente el 'Tipo de Usuario'.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiar();
                    }
                }
                else
                {
                    return;
                }
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
