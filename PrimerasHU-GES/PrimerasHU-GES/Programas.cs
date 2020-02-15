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
    public partial class Programas : Form
    {
        public Programas()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_ultEstado;

        private void Programas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetProgramas.programas' Puede moverla o quitarla según sea necesario.
            this.programasTableAdapter.Fill(this.ges_v01DataSetProgramas.programas);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetMaquinas.maquinasMedicion' Puede moverla o quitarla según sea necesario.
            this.maquinasMedicionTableAdapter.Fill(this.ges_v01DataSetMaquinas.maquinasMedicion);
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Debe escribir una descripción o nombre.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand existeDesc = new SqlCommand("SELECT descPrograma FROM programas WHERE UPPER(descPrograma) = UPPER('" + txt_descripcion.Text + "')", Conexion);
                adaptador = new SqlDataAdapter(existeDesc);

                DataTable dt_existeDesc = new DataTable();
                adaptador.Fill(dt_existeDesc);
                if (dt_existeDesc.Rows.Count != 0)
                {
                    MessageBox.Show("El nombre del programa que intenta registrar, ya existe. Inténtelo nuevamente o póngase en contacto con el administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand existeCod = new SqlCommand("SELECT codPrograma FROM programas WHERE UPPER(codPrograma) = UPPER('" + txt_codigo.Text + "')", Conexion);
                    adaptador = new SqlDataAdapter(existeCod);

                    DataTable dt_existeCod = new DataTable();
                    adaptador.Fill(dt_existeCod);
                    if (dt_existeCod.Rows.Count != 0)
                    {
                        MessageBox.Show("El código del programa que intenta registrar, ya existe. Inténtelo nuevamente o póngase en contacto con el administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand alta = new SqlCommand("INSERT INTO programas (codPrograma,codMaquina,descPrograma,revPrograma,fecActualizPrograma) VALUES (@codPrograma,@codMaquina,@descPrograma,@revPrograma,GETDATE())", Conexion);
                        adaptador = new SqlDataAdapter();
                        adaptador.InsertCommand = alta;
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codMaquina", SqlDbType.Int));
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descPrograma", SqlDbType.VarChar));
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@revPrograma", SqlDbType.Int));

                        adaptador.InsertCommand.Parameters["@codPrograma"].Value = txt_codigo.Text;
                        adaptador.InsertCommand.Parameters["@codMaquina"].Value = cb_maquina.SelectedValue;
                        adaptador.InsertCommand.Parameters["@descPrograma"].Value = txt_descripcion.Text;
                        adaptador.InsertCommand.Parameters["@revPrograma"].Value = nud_revision.Value;

                        try
                        {
                            Conexion.Open();
                            adaptador.InsertCommand.ExecuteNonQuery();
                            MessageBox.Show("El programa fue registrado con éxito.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void limpiar()
        {
            txt_descripcion.Text = "";
            this.programasTableAdapter.Fill(this.ges_v01DataSetProgramas.programas);
            this.maquinasMedicionTableAdapter.Fill(this.ges_v01DataSetMaquinas.maquinasMedicion);
            btn_registrar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            txt_codigo.Enabled = true;
            txt_codigo.Text = "";
            nud_revision.Value = 0;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv_programas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posi = dgv_programas.CurrentRow.Index;

            txt_codigo.Text = dgv_programas[0, posi].Value.ToString();
            cb_maquina.SelectedValue = dgv_programas[1, posi].Value;
            txt_descripcion.Text = dgv_programas[2, posi].Value.ToString();
            nud_revision.Value = Convert.ToInt32(dgv_programas[3, posi].Value.ToString());

            txt_codigo.Enabled = false;
            btn_registrar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM programas WHERE codPrograma=@codPrograma", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codPrograma"].Value = txt_codigo.Text;

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Es necesario seleccionar del listado el 'Programa' a eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            SqlCommand modifica = new SqlCommand("UPDATE programas SET codMaquina=@codMaquina,descPrograma=@descPrograma,revPrograma=@revPrograma,fecActualizPrograma=GETDATE() WHERE codPrograma=@codPrograma", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codMaquina", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descPrograma", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@revPrograma", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@codPrograma"].Value = txt_codigo.Text;
            adaptador.UpdateCommand.Parameters["@codMaquina"].Value = cb_maquina.SelectedValue;
            adaptador.UpdateCommand.Parameters["@descPrograma"].Value = txt_descripcion.Text;
            adaptador.UpdateCommand.Parameters["@revPrograma"].Value = nud_revision.Value;

            if ((string.IsNullOrEmpty(txt_codigo.Text) || string.IsNullOrEmpty(txt_descripcion.Text)))
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar del listado el 'Programa' a modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Se ha modificado correctamente el 'Programa'.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
