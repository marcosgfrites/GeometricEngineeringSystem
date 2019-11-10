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
using System.Globalization;

namespace PrimerasHU_GES
{
    public partial class IndicadoresCalidad : Form
    {
        public IndicadoresCalidad()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        int posicion = 0;


        private void IndicadoresCalidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18.indicadoresCalidad' Puede moverla o quitarla según sea necesario.
            this.indicadoresCalidadTableAdapter.Fill(this.ges_v01DataSet18.indicadoresCalidad);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();

            SqlCommand alta = new SqlCommand("INSERT INTO indicadoresCalidad values (@fechoraModIndicador,@nomIndicador,@valorIndicador)", conexion);
            adaptador.InsertCommand = alta;

            
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechoraModIndicador", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomIndicador", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@valorIndicador", SqlDbType.Int));

           


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

           

            if (string.IsNullOrEmpty(txtValor.Text) || string.IsNullOrEmpty(txtValor.Text))

            {
                MessageBox.Show("Es obligatorio completar todos los campos para registrar el Indicador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();

                    adaptador.InsertCommand.Parameters["@fechoraModIndicador"].Value = dtFecha.Value;
                    adaptador.InsertCommand.Parameters["@nomIndicador"].Value = txtNomIndi.Text;
                    adaptador.InsertCommand.Parameters["@valorIndicador"].Value = Decimal.Parse(txtValor.Text);

                    adaptador.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Registro de indicador cargado con exito");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    conexion.Close();


                }
                SqlDataAdapter da = new SqlDataAdapter("select * from indicadoresCalidad", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtIndicadores.DataSource = dt;
                LimpiarIndicador();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE indicadoresCalidad SET  fechoraModIndicador=@fechoraModIndicador, nomIndicador=@nomIndicador , valorIndicador=@valorIndicador  WHERE nomIndicador=@nomIndicador", conexion);
            adaptador.UpdateCommand = modificar;

            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechoraModIndicador", SqlDbType.Date));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomIndicador", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@valorIndicador", SqlDbType.Int));

           
            adaptador.UpdateCommand.Parameters["@fechoraModIndicador"].Value = dtFecha.Value.ToString("dd-MM-yyyy");
            adaptador.UpdateCommand.Parameters["@nomIndicador"].Value = txtNomIndi.Text;
            adaptador.UpdateCommand.Parameters["@valorIndicador"].Value = Decimal.Parse(txtValor.Text);

            int busqueda = 0;
            if (string.IsNullOrEmpty(txtNomIndi.Text) || string.IsNullOrEmpty(txtValor.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Indicador a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente al Indicador. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                   
                    if (MessageBox.Show("¿Está seguro que desea modificar el Indicador seleccionado: " + txtNomIndi.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Indicador: " + txtNomIndi.Text + " - " + txtValor.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarIndicador();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from indicadoresCalidad", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtIndicadores.DataSource = dt;
            }
        }
        private void dtIndicadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            posicion = dtIndicadores.CurrentRow.Index;
         
            txtNomIndi.Text = dtIndicadores[2, posicion].Value.ToString();
            txtValor.Text = dtIndicadores[3, posicion].Value.ToString();
            DateTime t = new DateTime();

            if (!DateTime.TryParse(dtIndicadores[1, posicion].Value.ToString(),out t))
            {
                t = Convert.ToDateTime(dtIndicadores[1, posicion].Value.ToString(), System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
            }

            dtFecha.Value = t;

        }

        private void LimpiarIndicador()
        {
            txtNomIndi.Text = "";
            txtValor.Text = "";

            this.indicadoresCalidadTableAdapter.Fill(this.ges_v01DataSet18.indicadoresCalidad);
           
           
        }
    }
}
