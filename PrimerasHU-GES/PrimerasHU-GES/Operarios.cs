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
    public partial class Operarios : Form
    {
        public Operarios()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;

        private void Operarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet11.operariosMaquina' Puede moverla o quitarla según sea necesario.
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet11.operariosMaquina);

            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
        }

        private void LimpiarOperario()
        {
            txtCodigoOperario.Text = "";
            txtNombreOperario.Text = "";
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet11.operariosMaquina);
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
            SqlCommand alta = new SqlCommand("INSERT INTO operariosMaquina (codOper,nomOper) VALUES (@codOper,@nomOper)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));


            if (string.IsNullOrEmpty(txtNombreOperario.Text))

            {
                MessageBox.Show("Es obligatorio completar el Nombre del operario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {   
                try
                {

                    adaptador.InsertCommand.Parameters["@codOper"].Value = Convert.ToInt32(txtCodigoOperario.Text);
                    adaptador.InsertCommand.Parameters["@nomOper"].Value = txtNombreOperario.Text;

                    conexion.Open();

                    SqlDataAdapter compCodOperario = new SqlDataAdapter("SELECT codOper FROM operariosMaquina WHERE codOper=@codOper", conexion);
                    DataTable codOperario = new DataTable();
                    compCodOperario.SelectCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));
                    compCodOperario.SelectCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
                    compCodOperario.Fill(codOperario);


                    if (codOperario.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente El Operario de Maquinas de Medicion.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlCommand consultar = new SqlCommand("SELECT * FROM operariosMaquina WHERE codOper=@codOper", conexion);
            adaptador.SelectCommand = consultar;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));

            adaptador.SelectCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código de Operario' para buscar el Operario a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            }
        }

        private void BotonModificarOperario_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE operariosMaquina SET nomOper=@nomOper WHERE codOper=@codOper", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
            adaptador.UpdateCommand.Parameters["@nomOper"].Value = txtNombreOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text) || string.IsNullOrEmpty(txtNombreOperario.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe realizar la búsqueda del Operario a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha modificado correctamente el nombre del Operario", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarOperario();

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

        private void BotonLimpiarOperario_Click(object sender, EventArgs e)
        {
            LimpiarOperario();
            LimpiarDGVOperarios();
        }

        private void BotonEliminarOperario_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM operariosMaquina WHERE codOper=@codOper", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));

            adaptador.DeleteCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código de Operario' para buscar el Operador a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El Operario: " + txtCodigoOperario.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
                    }

                    SqlDataAdapter da = new SqlDataAdapter("select * from operarios", conexion);
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
    }
}
